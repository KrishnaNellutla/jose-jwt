using Jose;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ArraysTest
    {
        [Test]
        public void FirstHalf()
        {
            //given
            byte[] data = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

            //then
            Assert.That(Arrays.FirstHalf(data), Is.EqualTo(new byte[] {0, 1, 2, 3, 4}));
        }

        [Test]
        public void SecondHalf()
        {
            //given
            byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //then
            Assert.That(Arrays.SecondHalf(data), Is.EqualTo(new byte[] {5, 6, 7, 8, 9}));
        }

        [Test]
        public void SixtyFourBitLength()
        {
            //given
            byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //then
            Assert.That(Arrays.SixtyFourBitLength(data), Is.EqualTo(new byte[] {0, 0, 0, 0, 0, 0, 0, 80}));            
        }

        [Test]
        public void Concat()
        {
            //given
            byte[] first = {0, 1};
            byte[] second = {2, 3, 4, 5};
            byte[] third = {6, 7, 8, 9};
            
            //then
            Assert.That(Arrays.Concat(first, second, third), Is.EqualTo(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        [Test]
        public void Slice()
        {
            //given
            byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            //when
            byte[][] test = Arrays.Slice(data, 3);

            //then
            Assert.That(test[0], Is.EqualTo(new byte[] {0, 1, 2}));
            Assert.That(test[1], Is.EqualTo(new byte[] {3, 4, 5}));
            Assert.That(test[2], Is.EqualTo(new byte[] {6, 7, 8}));
        }

        [Test]
        public void Xor()
        {
            //given
            byte[] data = { 0xFF, 0x00, 0xF0, 0x0F, 0x55, 0xAA, 0xBB, 0xCC};

            //when
            byte[] test = Arrays.Xor(data, 0x00FF0FF0AA554433);
            byte[] test2 = Arrays.Xor(data, -1);

            //then
            Assert.That(test, Is.EqualTo(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }));
            Assert.That(test2, Is.EqualTo(new byte[] { 0x00, 0xFF, 0x0F, 0xF0, 0xAA, 0x55, 0x44, 0x33 }));
        }
    }
}