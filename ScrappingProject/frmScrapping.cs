using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ScrappingProject
{
    public partial class frmScrapping : Form
    {
        public frmScrapping()
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

            StoreScrapper storeScrapper = new StoreScrapper();

            var storeName = rdbFalabella.Checked ? "Falabella" : "Ripley";

            var productExtractResult = storeScrapper.ExtractProductData(txtURL.Text, storeName);

            if (productExtractResult != null)
            {
                txtNombre.Text = productExtractResult.Name;
                txtPrecio.Text = productExtractResult.Price;
                txtPrecioOferta.Text = productExtractResult.DiscountPrice;
                txtPrecioOfertaTarjeta.Text = productExtractResult.DiscountPriceWithCard;
            }
            
        }
    }
}
