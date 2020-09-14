using System;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ScrappingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnScrapping_Click(object sender, EventArgs e)
        {            
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtPrecioOferta.Text = string.Empty;
            txtPrecioOfertaTarjeta.Text = string.Empty;

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(txtURL.Text);

                if (rdbFalabella.Checked)
                {
                    txtNombre.Text = driver.FindElement(By.CssSelector("div[class*=product-name]")).Text;

                    if (ScrappingHelpers.ContainsClass(driver, "price-0"))
                    {
                        txtPrecio.Text = driver.FindElement(By.CssSelector("li[class*=price-0]")).Text;
                    }

                    if (ScrappingHelpers.ContainsClass(driver, "price-1"))
                    {
                        txtPrecioOferta.Text = driver.FindElement(By.CssSelector("li[class*=price-1]")).Text;
                    }

                    if (ScrappingHelpers.ContainsClass(driver, "price-2"))
                    {
                        txtPrecioOfertaTarjeta.Text = driver.FindElement(By.CssSelector("li[class*=price-2]")).Text;
                    }
                }
                else
                {                    
                    txtNombre.Text = driver.FindElement(By.XPath("//section[contains(@class,'product-header')]/h1")).InnerHTML();
                    
                    if (ScrappingHelpers.ContainsClass(driver, "product-normal-price"))
                    {
                        txtPrecio.Text = driver.FindElement(By.XPath("//li[contains(@class,'product-normal-price')]/span[contains(@class,'product-price__line-thru')]")).InnerHTML();
                    }
                    
                    if (ScrappingHelpers.ContainsClass(driver, "product-internet-price-not-best"))
                    {
                        txtPrecioOferta.Text = driver.FindElement(By.XPath("//li[contains(@class,'product-internet-price-not-best')]/span[@class='product-price']")).InnerHTML();
                    }
                    
                    if (ScrappingHelpers.ContainsClass(driver, "product-ripley-price"))
                    {
                        txtPrecioOfertaTarjeta.Text = driver.FindElement(By.XPath("//li[@class='product-ripley-price']/span[@class='product-price']")).Text;
                    }
                    
                }

                driver.Close();
            }
        }

        private void btnScrappingHtml_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtPrecioOferta.Text = string.Empty;
            txtPrecioOfertaTarjeta.Text = string.Empty;


            var web = new HtmlWeb();
            var doc = web.Load(txtURL.Text);


            if (rdbFalabella.Checked)
            {
                var nodes = doc.DocumentNode.SelectNodes($"//div[contains(@class,'product-name')]");
                txtNombre.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-0')]");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecio.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-1')]");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecioOferta.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'price-2')]");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecioOfertaTarjeta.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }
            }
            else 
            {
                var nodes = doc.DocumentNode.SelectNodes($"//section[contains(@class,'product-header')]/h1");
                txtNombre.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-normal-price')]/span[contains(@class,'product-price__line-thru')]");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecio.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-internet-price-not-best')]/span[@class='product-price']");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecioOferta.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }
                else
                {
                    nodes = doc.DocumentNode.SelectNodes($"//li[contains(@class,'product-internet-price')]/span[@class='product-price']");
                    txtPrecioOferta.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

                nodes = doc.DocumentNode.SelectNodes($"//li[@class='product-ripley-price']/span[@class='product-price']");
                if (nodes != null && nodes.Count > 0)
                {
                    txtPrecioOfertaTarjeta.Text = HttpUtility.HtmlDecode(nodes[0].InnerText);
                }

            }
            
        }
    }
}
