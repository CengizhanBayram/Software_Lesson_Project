using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;
using RealEstateApp;

namespace RealEstateTest
{
    [TestFixture]
    public class FavoritesTests
    {
        private Favorites form;

        [SetUp]
        public void Setup()
        {
            form = new Favorites();
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
            // Form başlığının doğru şekilde ayarlandığını kontrol et
            ClassicAssert.AreEqual("Favorites", form.Text, "Form başlığı doğru değil.");

            // Panel1'in varlığını ve özelliklerini kontrol et
            var panel1 = form.Controls.Find("panel1", true)[0] as Panel;
            ClassicAssert.IsNotNull(panel1, "Panel1 bulunamadı.");
            ClassicAssert.AreEqual(DockStyle.Top, panel1.Dock, "Panel1 dock ayarı yanlış.");

            // Panel2'nin varlığını ve özelliklerini kontrol et
            var panel2 = form.Controls.Find("panel2", true)[0] as Panel;
            ClassicAssert.IsNotNull(panel2, "Panel2 bulunamadı.");
            ClassicAssert.AreEqual(DockStyle.Fill, panel2.Dock, "Panel2 dock ayarı yanlış.");
        }

        [Test]
        public void Navbar_ShouldBeInitialized()
        {
            // Navbar'ın varlığını ve özelliklerini kontrol et
            var navbar = form.Controls.Find("navbar1", true)[0] as Control;
            ClassicAssert.IsNotNull(navbar, "Navbar bulunamadı.");
            ClassicAssert.AreEqual(typeof(navbar), navbar.GetType(), "Navbar tipi yanlış.");
            ClassicAssert.AreEqual(DockStyle.Fill, navbar.Dock, "Navbar dock ayarı yanlış.");
        }
    }
}
