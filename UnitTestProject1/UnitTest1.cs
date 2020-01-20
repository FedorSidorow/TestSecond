using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyFirstTestBlackBox_AddedisExist()
        {
            int expected = 2;
            BinaryTree bt = new BinaryTree();
            bt.Add(2);

            int actual = bt.root.Num;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
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
                Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
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
                Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
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
                Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
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
                Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
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
                Assert.AreEqual(expected[i], actual[i]);
        }
    }
}
