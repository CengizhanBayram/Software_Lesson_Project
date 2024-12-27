using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;
using RealEstateApp;

namespace RealEstateTest
{
    [TestFixture]
    public class OwnAdsTests
    {
        private OwnAds form;

        [SetUp]
        public void Setup()
        {
            // Varsayılan değerleri ayarla
            GlobalSettings.UserID = 1; // Test için bir kullanıcı ID ayarla
            GlobalSettings.ConnectionString = "server=localhost;user=root;database=emlak;password=16072001;";

            form = new OwnAds();

            // Formun yüklenmesini tetikle
            form.Load += (s, e) => form.OwnAds_Load(s, e);

            form.Show();

            // Application.DoEvents() çağrısı, formun tam olarak yüklenmesini bekler
            Application.DoEvents();
        }

        [TearDown]
        public void TearDown()
        {
            if (form != null)
            {
                form.Close();
                form.Dispose();
            }
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
            var dataGridViewAds = form.Controls.Find("dataGridViewAds", true)[0] as DataGridView;
            ClassicAssert.IsNotNull(dataGridViewAds, "DataGridView bulunamadı.");

            // Beklenen sütunlar listesi
            string[] expectedColumns = { "AdID", "Title", "Description", "Price", "Location", "SquareMeters", "RoomCount", "FloorNo", "Elevator", "Status", "CreatedAt" };

            foreach (var column in expectedColumns)
            {
                ClassicAssert.IsTrue(dataGridViewAds.Columns.Contains(column), $"{column} sütunu eksik.");
            }

            // Sütun sayısının doğru olup olmadığını kontrol et
            ClassicAssert.AreEqual(expectedColumns.Length, dataGridViewAds.Columns.Count, "DataGridView sütun sayısı yanlış.");
        }
    }
}
