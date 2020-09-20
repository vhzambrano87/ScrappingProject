using HtmlAgilityPack;
using System.Web;

namespace ScrappingProject
{
    public class StoreScrapper
    {
        public ProductExtractModel ExtractProductData(string url, string storeName) 
        {
            ProductExtractModel result = new ProductExtractModel();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            if (storeName.Equals("Falabella"))
            {
                var nodes = doc.DocumentNode.SelectNodes($"//div[contains(@class,'product-name')]");
                result.Name = HttpUtility.HtmlDecode(nodes[0].InnerText);

                nodes = doc.DocumentNode.SelectNodes($"//span[@class='jsx-3408573263']");
                if (nodes != null && nodes.Count > 0)
                {
                    result.SKU = HttpUtility.HtmlDecode(nodes[0].InnerText).Replace("Código: ","");
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-0')]");
                if (nodes != null && nodes.Count > 0)
                {
                    result.Price = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-1')]");
                if (nodes != null && nodes.Count > 0)
                {
                    result.DiscountPrice = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-2')]");
                if (nodes != null && nodes.Count > 0)
                {
                    result.DiscountPriceWithCard = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }
            }
            else
            {
                var nodes = doc.DocumentNode.SelectNodes($"//section[contains(@class,'product-header')]/h1");
                result.Name = HttpUtility.HtmlDecode(nodes[0].InnerText);

                nodes = doc.DocumentNode.SelectNodes($"//span[@class='sku']");
                if (nodes != null && nodes.Count > 0)
                {
                    result.SKU = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-normal-price')]/span[contains(@class,'product-price__line-thru')]");
                if (nodes != null && nodes.Count > 0)
                {
                    result.Price = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-internet-price-not-best')]/span[@class='product-price']");
                if (nodes != null && nodes.Count > 0)
                {
                    result.DiscountPrice = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }
                else
                {
                    nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-internet-price')]/span[@class='product-price']");
                    result.DiscountPrice = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[@class='product-ripley-price']/span[@class='product-price']");
                if (nodes != null && nodes.Count > 0)
                {
                    result.DiscountPriceWithCard = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

            }

            return result;        
        }
        

    }


    public class ProductExtractModel
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string DiscountPrice { get; set; }
        public string DiscountPriceWithCard { get; set; }
    }

}
