using System;
using System.Linq;
using Xunit;

namespace ConsoleApp1.Test
{
    public class ConsoleApp1Test
    {
        [Fact]
        public void TestMethod1()
        {
            int expected = 2;
            BinaryTree bt = new BinaryTree();
            bt.Add(2);

            int actual = bt.root.Num;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BlackBoxWhatIlearnd()
        {
            BinaryTree bt = new BinaryTree();

            bt.Add(2);
            bt.Add(1);
            bt.Add(7);
            bt.Add(13);
            bt.Add(14);
            bt.Add(3);
            bt.Add(10);
            bt.Add(5);


            int[] actual = new int[] { 7, 2, 1, 3, 5, 13, 10, 14 };
            bt.ShowTree();
            int[] expected = bt.value;

            for (int i = 0; i < bt.value.Length; i++)
                Assert.Equal(expected[i], actual[i]);
        }

        [Fact]
        public void Whitebox_TestingRotateRR()
        {
            BinaryTree bt = new BinaryTree();

            bt.Add(1);
            bt.Add(2);
            bt.Add(3);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);


            int[] actual = new int[] { 2, 1, 0, 3, 0, 0, 0, 0 };
            bt.ShowTree();
            int[] expected = bt.value;

            for (int i = 0; i < bt.value.Length; i++)
                Assert.Equal(expected[i], actual[i]);
        }

        [Fact]
        public void Whitebox_TestingRotateLL()
        {
            BinaryTree bt = new BinaryTree();

            bt.Add(3);
            bt.Add(2);
            bt.Add(1);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);


            int[] actual = new int[] { 2, 1, 0, 3, 0, 0, 0, 0, 1 };
            bt.ShowTree();
            int[] expected = bt.value;

            for (int i = 0; i < bt.value.Length; i++)
                Assert.Equal(expected[i], actual[i]);
        }

        [Fact]
        public void Whitebox_TestingRotateLR()
        {
            BinaryTree bt = new BinaryTree();

            bt.Add(3);
            bt.Add(0);
            bt.Add(1);
            bt.Add(2);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);


            int[] actual = new int[] { 1, 0, 3, 2, 0, 0, 0, 0 };
            bt.ShowTree();
            int[] expected = bt.value;

            for (int i = 0; i < bt.value.Length; i++)
                Assert.Equal(expected[i], actual[i]);
        }

        [Fact]
        public void Whitebox_TestingRotateRL()
        {
            BinaryTree bt = new BinaryTree();

            bt.Add(0);
            bt.Add(3);
            bt.Add(1);
            bt.Add(2);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);
            bt.Add(0);


            int[] actual = new int[] { 1, 0, 3, 2, 0, 0, 0, 0 };
            bt.ShowTree();
            int[] expected = bt.value;

            for (int i = 0; i < bt.value.Length; i++)
                Assert.Equal(expected[i], actual[i]);
        }
    }

}
