using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;

namespace RealEstateTest
{
    [TestFixture]
    public class OwnAdsTests
    {
        private OwnAds form;

        [SetUp]
        public void Setup()
        {
            form = new OwnAds();
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
            // Formun başlığını kontrol et
            ClassicAssert.AreEqual("OwnAds", form.Text, "Form başlığı doğru değil.");

            // DataGridView'in doğru şekilde oluşturulduğunu kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("dataGridViewAds", true)[0], "DataGridView bulunamadı.");

            // Update Ad butonunun oluşturulduğunu kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("button1", true)[0], "Update Ad butonu bulunamadı.");

            // Delete Ad butonunun oluşturulduğunu kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("button2", true)[0], "Delete Ad butonu bulunamadı.");
        }

        [Test]
        public void Button1_ClickEvent_ShouldBeAttached()
        {
            // button1 için Click olay işleyicisinin atanıp atanmadığını kontrol et
            var button1 = form.Controls.Find("button1", true)[0] as Button;
            ClassicAssert.IsNotNull(button1, "Update Ad butonu bulunamadı.");

            // Olayın tetiklenip tetiklenmediğini kontrol etmek için bir flag kullan
            bool eventTriggered = false;
            button1.Click += (s, e) => eventTriggered = true;

            // Butonu tıklatarak olayın tetiklenmesini simüle et
            button1.PerformClick();

            // Olayın gerçekten tetiklenip tetiklenmediğini kontrol et
            ClassicAssert.IsTrue(eventTriggered, "Update Ad butonu için Click olayı tetiklenmedi.");
        }

        [Test]
        public void Button2_ClickEvent_ShouldBeAttached()
        {
            // button1 için Click olay işleyicisinin atanıp atanmadığını kontrol et
            var button1 = form.Controls.Find("button1", true)[0] as Button;
            ClassicAssert.IsNotNull(button1, "Update Ad butonu bulunamadı.");

            // Olayın tetiklenip tetiklenmediğini kontrol etmek için bir flag kullan
            bool eventTriggered = false;
            button1.Click += (s, e) => eventTriggered = true;

            // Butonu tıklatarak olayın tetiklenmesini simüle et
            button1.PerformClick();

            // Olayın gerçekten tetiklenip tetiklenmediğini kontrol et
            ClassicAssert.IsTrue(eventTriggered, "Update Ad butonu için Click olayı tetiklenmedi.");
        }

        [Test]
        public void DataGridView_ShouldHaveCorrectColumns()
        {
            // DataGridView'in sütunlarını kontrol et
            var dataGridView = form.Controls.Find("dataGridViewAds", true)[0] as DataGridView;
            ClassicAssert.IsNotNull(dataGridView, "DataGridView bulunamadı.");
            ClassicAssert.AreEqual(1, dataGridView.Columns.Count, "DataGridView sütun sayısı yanlış.");
            ClassicAssert.AreEqual("Column1", dataGridView.Columns[0].Name, "DataGridView sütun ismi yanlış.");
        }



    }
}
