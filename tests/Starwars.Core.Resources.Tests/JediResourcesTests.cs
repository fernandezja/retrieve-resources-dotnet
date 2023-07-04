namespace Starwars.Core.Resources.Tests
{
    public class JediResourcesTests
    {
        [Fact]
        public void GetResourcesStringTypeFromClassLibrary()
        {
            var quote1 = Starwars.Core.Resources.JediResources.Quote1;
            var quote2 = Starwars.Core.Resources.JediResources.Quote2;

            Assert.Equal("Do or do not. There is no try.", quote1);
            Assert.Equal("You must unlearn what you have learned.", quote2);
        }


        [Fact]
        public void GetResourcesImageTypeFromClassLibrary()
        {
            var imageYoda = Starwars.Core.Resources.JediResources.Yoda001;

            Assert.NotEmpty(imageYoda);
            Assert.Equal(25992, imageYoda.Length);
        }


        [Fact]
        public void GetResourcesStringFromFileTextWithBuildActionContent()
        {
            var coreResourceMain = new CoreResourcesMain();

            var result = coreResourceMain.GetResources2ContentLeiaQuotes();

            Assert.Equal("Aren't you a little short for a Stormtrooper?", result);
        }



        [Fact]
        public void GetResourcesImageFromFileWithBuildActionContent()
        {
            var coreResourceMain = new CoreResourcesMain();

            var imageLeia = coreResourceMain.GetResources2ContentLeiaImage();

            Assert.NotEmpty(imageLeia);
            Assert.Equal(91901, imageLeia.Length);
        }


        [Fact]
        public void GetResourcesStringFromFileTextWithBuildActionEmbeddedResource()
        {
            var coreResourceMain = new CoreResourcesMain();

            var result = coreResourceMain.GetResources3EmbeddedResourceDarthVaderQuotes();

            Assert.Equal("No, I Am Your Father.", result);
        }


        [Fact]
        public void GetResourcesImageFromFileWithBuildActionEmbeddedResource()
        {
            var coreResourceMain = new CoreResourcesMain();

            var imageDarthVader = coreResourceMain.GetResources3EmbeddedResourceDarthVaderImage();

            Assert.NotEmpty(imageDarthVader);
            Assert.Equal(182238, imageDarthVader.Length);
        }
    }
}