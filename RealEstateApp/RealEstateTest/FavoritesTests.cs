using System;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using RealEstateApp.Forms; // Favorites formunun bulunduğu namespace'i eklediğinizden emin olun

namespace RealEstateTests
{
    [TestFixture]
    public class FavoritesFormTests
    {
        private Favorites _favoritesForm;

        [SetUp]
        public void SetUp()
        {
            // Favorites formu nesnesini oluşturuyoruz
            _favoritesForm = new Favorites();
            _favoritesForm.Show(); // Formun görünür olduğundan emin olun
        }

        [TearDown]
        public void TearDown()
        {
            // Testlerden sonra formu kapatıyoruz
            _favoritesForm.Close();
        }

        [Test]
        public void Test_Panel1_ShouldExist()
        {
            // Arrange
            var panel1 = GetControl<Panel>(_favoritesForm, "panel1");

            // Act & Assert
            ClassicAssert.IsNotNull(panel1, "Panel1 formda mevcut olmalı.");
        }

        [Test]
        public void Test_FlowLayoutPanelFavorites_ShouldExist()
        {
            // Arrange
            var flowLayoutPanelFavorites = GetControl<FlowLayoutPanel>(_favoritesForm, "flowLayoutPanelFavorites");

            // Act & Assert
            ClassicAssert.IsNotNull(flowLayoutPanelFavorites, "flowLayoutPanelFavorites formda mevcut olmalı.");
        }



        [Test]
        public void Test_Panel3_ShouldExist()
        {
            // Arrange
            var panel3 = GetControl<Panel>(_favoritesForm, "panel3");

            // Act & Assert
            ClassicAssert.IsNotNull(panel3, "Panel3 formda mevcut olmalı.");
        }

        [Test]
        public void Test_FlowLayoutPanelFaves_ShouldExist()
        {
            // Arrange
            var flowLayoutPanelFaves = GetControl<FlowLayoutPanel>(_favoritesForm, "flowLayoutPanelFaves");

            // Act & Assert
            ClassicAssert.IsNotNull(flowLayoutPanelFaves, "flowLayoutPanelFaves formda mevcut olmalı.");
        }

        [Test]
        public void Test_Panel4_ShouldExist()
        {
            // Arrange
            var panel4 = GetControl<Panel>(_favoritesForm, "panel4");

            // Act & Assert
            ClassicAssert.IsNotNull(panel4, "Panel4 formda mevcut olmalı.");
        }

        private T GetControl<T>(Control parent, string controlName) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == controlName)
                    return control as T;

                if (control.HasChildren)
                {
                    var childControl = GetControl<T>(control, controlName);
                    if (childControl != null)
                        return childControl;
                }
            }

            return null;
        }
    }
}
