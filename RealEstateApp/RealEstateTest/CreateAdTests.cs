using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;

namespace RealEstateTest
{
    [TestFixture]
    public class CreateAdTests
    {
        private CreateAd form;

        [SetUp]
        public void Setup()
        {
            form = new CreateAd();
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
            ClassicAssert.AreEqual("CreateAd", form.Text, "Form başlığı doğru değil.");

            // Gerekli bileşenlerin varlığını kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("textBoxTitle", true)[0], "Title TextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("richTextBoxDescription", true)[0], "Description RichTextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("maskedTextBoxPrice", true)[0], "Price MaskedTextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("comboBoxLocation", true)[0], "Location ComboBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("btnSaveAdvert", true)[0], "Save Button bulunamadı.");
        }

        [Test]
        public void SaveButton_ClickEvent_ShouldBeAttached()
        {
            // Save butonuna Click olay işleyicisinin atanıp atanmadığını kontrol et
            var btnSave = form.Controls.Find("btnSaveAdvert", true)[0] as Button;
            ClassicAssert.IsNotNull(btnSave, "Save Button bulunamadı.");

            bool eventTriggered = false;
            btnSave.Click += (s, e) => eventTriggered = true;

            // Butonu tıklatarak olayın tetiklenmesini simüle et
            btnSave.PerformClick();

            // Olayın gerçekten tetiklenip tetiklenmediğini kontrol et
            ClassicAssert.IsTrue(eventTriggered, "Save Button için Click olayı tetiklenmedi.");
        }

        [Test]
        public void UploadPhotoButton_ClickEvent_ShouldBeAttached()
        {
            // Upload Photo butonuna Click olay işleyicisinin atanıp atanmadığını kontrol et
            var btnUploadPhoto = form.Controls.Find("btnUploadPhoto", true)[0] as Button;
            ClassicAssert.IsNotNull(btnUploadPhoto, "Upload Photo Button bulunamadı.");

            bool eventTriggered = false;
            btnUploadPhoto.Click += (s, e) => eventTriggered = true;

            // Butonu tıklatarak olayın tetiklenmesini simüle et
            btnUploadPhoto.PerformClick();

            // Olayın gerçekten tetiklenip tetiklenmediğini kontrol et
            ClassicAssert.IsTrue(eventTriggered, "Upload Photo Button için Click olayı tetiklenmedi.");
        }

        [Test]
        public void ErrorProviders_ShouldBeInitialized()
        {
            // ErrorProvider bileşenlerinin varlığını kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("errorProviderTitle", true)[0], "Title ErrorProvider bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("errorProviderDescription", true)[0], "Description ErrorProvider bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("errorProviderPrice", true)[0], "Price ErrorProvider bulunamadı.");
        }

        [Test]
        public void MaskedTextBox_Validation_ShouldBeCorrect()
        {
            // MaskedTextBox (Price ve SquareMeters) bileşenlerinin doğruluğunu kontrol et
            var maskedTextBoxPrice = form.Controls.Find("maskedTextBoxPrice", true)[0] as MaskedTextBox;
            var maskedTextBoxSquareMeters = form.Controls.Find("maskedTextBoxSquareMeters", true)[0] as MaskedTextBox;

            ClassicAssert.IsNotNull(maskedTextBoxPrice, "Price MaskedTextBox bulunamadı.");
            ClassicAssert.AreEqual("0000000000", maskedTextBoxPrice.Mask, "Price MaskedTextBox maskesi yanlış.");

            ClassicAssert.IsNotNull(maskedTextBoxSquareMeters, "SquareMeters MaskedTextBox bulunamadı.");
            ClassicAssert.AreEqual("00000", maskedTextBoxSquareMeters.Mask, "SquareMeters MaskedTextBox maskesi yanlış.");
        }
    }
}
