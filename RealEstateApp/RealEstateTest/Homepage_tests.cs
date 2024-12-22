using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;
using RealEstateApp;

namespace RealEstateTest
{
    [TestFixture]
    public class HomepageTests
    {
        private Homepage form;

        [SetUp]
        public void Setup()
        {
            form = new Homepage();
            form.Show(); // Formu oluştur ve göster
        }

        [TearDown]
        public void TearDown()
        {
            form.Close(); // Testten sonra formu kapat
        }

        [Test]
        public void FormComponents_ShouldBeInitialized()
        {
            // Form başlığını kontrol et
            ClassicAssert.AreEqual("Homepage", form.Text, "Form başlığı doğru değil.");

            // Panel1'in varlığını ve özelliklerini kontrol et
            var panel1 = form.Controls.Find("panel1", true)[0] as Panel;
            ClassicAssert.IsNotNull(panel1, "Panel1 bulunamadı.");
            ClassicAssert.AreEqual(DockStyle.Top, panel1.Dock, "Panel1'in Dock ayarı yanlış.");

            // Panel2'nin varlığını ve özelliklerini kontrol et
            var panel2 = form.Controls.Find("panel2", true)[0] as Panel;
            ClassicAssert.IsNotNull(panel2, "Panel2 bulunamadı.");
            ClassicAssert.AreEqual(DockStyle.Fill, panel2.Dock, "Panel2'nin Dock ayarı yanlış.");
        }

        [Test]
        public void Navbar_ShouldBeInitialized()
        {
            // Navbar bileşeninin varlığını ve özelliklerini kontrol et
            var navbarControl = form.Controls.Find("navbar1", true)[0] as Control; // 'navbarControl' adını kullandık
            ClassicAssert.IsNotNull(navbarControl, "Navbar bileşeni bulunamadı.");
            ClassicAssert.AreEqual(typeof(navbar), navbarControl.GetType(), "Navbar bileşeninin tipi yanlış.");
            ClassicAssert.AreEqual(DockStyle.Fill, navbarControl.Dock, "Navbar'ın Dock ayarı yanlış.");
        }

        [Test]
        public void Panel1_ShouldContainNavbar()
        {
            // Panel1'in içinde Navbar'ın olduğunu kontrol et
            var panel1 = form.Controls.Find("panel1", true)[0] as Panel;
            ClassicAssert.IsNotNull(panel1, "Panel1 bulunamadı.");

            var navbarControl = panel1.Controls.Find("navbar1", true)[0]; // 'navbarControl' adını kullandık
            ClassicAssert.IsNotNull(navbarControl, "Navbar Panel1 içinde bulunamadı.");
        }
    }
}
