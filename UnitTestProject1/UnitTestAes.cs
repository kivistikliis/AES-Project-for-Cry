﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aes;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestAes
    {
        [TestMethod]
        public void TestSubBytes()
        {
            //test vector: according to Caspar Schellekes
            string s = "12345689abcdefgh";
            byte[] expectedStateData = { 0xc7, 0x23, 0xc3, 0x18, 
                                     0x96, 0x05, 0x07, 0x12, 
                                     0xef, 0xaa, 0xfb, 0x43, 
                                     0x4d, 0x33, 0x85, 0x45 };
            State expectedState = new State(expectedStateData);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] inputPlain = encoding.GetBytes(s);

            State start = new State(inputPlain);

            start = start.subBytes();

            Console.Out.WriteLine("subBytes:\n" + start);
            Assert.AreEqual(start.ToString(), expectedState.ToString());
        }
        [TestMethod]
        public void TestShiftRows()
        {
            string s = "12345689abcdefgh";
            byte[] expectedStateData = { 0x31, 0x36, 0x63, 0x68, 
                                         0x35, 0x62, 0x67, 0x34, 
                                         0x61, 0x66, 0x33, 0x39, 
                                         0x65, 0x32, 0x38, 0x64  };
            State expectedState = new State(expectedStateData);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] inputPlain = encoding.GetBytes(s);

            State start = new State(inputPlain);

            start = start.shiftRows();

            Console.Out.WriteLine("shift:\n" + start);
            Assert.AreEqual(start.ToString(), expectedState.ToString());
        }
        [TestMethod]
        public void TestMixColumns()
        {
            string s = "12345789abcdexyz";
            byte[] expectedStateData = { 0x33, 0x34, 0x39, 0x3a, 
                                         0x32, 0x2a, 0x39, 0x22, 
                                         0x63, 0x64, 0x69, 0x6a, 
                                         0x41, 0x64, 0x61, 0x5a };
            State expectedState = new State(expectedStateData);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] inputPlain = encoding.GetBytes(s);

            State start = new State(inputPlain);

            start = start.mixColumns();

            Console.Out.WriteLine("mix:\n" + start);
            Assert.AreEqual(start.ToString(), expectedState.ToString());
        }
        [TestMethod]
        public void TestKeyExpansion()
        {
            byte[] inputKey = { 0x11, 0x22, 0x33, 0x44, 
                                0x55, 0x66, 0x77, 0x88, 
                                0x99, 0x00, 0xaa, 0xbb, 
                                0xcc, 0xdd, 0xee, 0xff };
            string expectedKeyString = "11 55 99 CC D1 84 1D D1 1B 9F 82 53 AF 30 B2 E1 35 05 B7 56 53 56 E1 B7 E3 B5 54 E3 1B AE FA 19 07 A9 53 4A EE 47 14 5E 78 3F 2B 75 \n" +
                                       "22 66 00 DD 0A 6C 6C B1 4D 21 4D FC E4 C5 88 74 36 F3 7B 0F 11 E2 99 96 77 95 0C 9A 1F 8A 86 1C 14 9E 18 04 C5 5B 43 47 10 4B 08 4F \n" +
                                       "33 77 AA EE 25 52 F8 16 0B 59 A1 B7 30 69 C8 7F E3 8A 42 3D 26 AC EE D3 66 CA 24 F7 87 4D 69 9E EB A6 CF 51 8D 2B E4 B5 C4 EF 0B BE \n" +
                                       "44 88 BB FF 0F 87 3C C3 31 B6 8A 49 DC 6A E0 A9 24 4E AE 07 95 DB 75 72 3C E7 92 E0 2D CA 58 B8 F9 33 6B D3 2F 1C 77 A4 77 6B 1C B8 \n";

            Key key = new Key(inputKey);

            Console.Out.WriteLine("key:\n" + key);
            Assert.AreEqual(expectedKeyString, key.ToString());
        }
        [TestMethod]
        public void TestAddRoundKey0()
        {
            string s = "12345689abcdefgh";
            byte[] inputKey = { 0x11, 0x22, 0x33, 0x44, 
                                0x55, 0x66, 0x77, 0x88, 
                                0x99, 0x00, 0xaa, 0xbb, 
                                0xcc, 0xdd, 0xee, 0xff };
            byte[] expectedStateData = { 32, 16, 0, 112, 96, 80, 79, 177, 248, 98, 201, 223, 169, 187, 137, 151 };
            State expectedState = new State(expectedStateData);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] inputPlain = encoding.GetBytes(s);

            Key key = new Key(inputKey);
            State start = new State(inputPlain);

            start = start.addRoundKey(key, 0);

            Console.Out.WriteLine("add0:\n" + start);
            Assert.AreEqual(start.ToString(), expectedState.ToString());
        }
        [TestMethod]
        public void TestAddRoundKey7()
        {
            string s = "12345689abcdefgh";
            byte[] inputKey = { 0x11, 0x22, 0x33, 0x44, 
                                0x55, 0x66, 0x77, 0x88, 
                                0x99, 0x00, 0xaa, 0xbb, 
                                0xcc, 0xdd, 0xee, 0xff };
            byte[] expectedStateData = { 42, 45, 180, 25, 155, 188, 117, 243, 155, 228, 10, 60, 124, 122, 249, 208 };
            State expectedState = new State(expectedStateData);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] inputPlain = encoding.GetBytes(s);

            Key key = new Key(inputKey);
            State start = new State(inputPlain);

            start = start.addRoundKey(key, 7);

            Console.Out.WriteLine("add7:\n" + start);
            Assert.AreEqual(start.ToString(), expectedState.ToString());
        }


        [TestMethod]
        public void TestSubBytesInv()
        {
            byte[] StartingStateData = { 0x10, 0x11, 0x12, 0x13, 
                                     0x14, 0x15, 0x16, 0x17, 
                                     0x18, 0x19, 0x20, 0x21, 
                                     0x22, 0x23, 0x24, 0x25 };
            State StartState = new State(StartingStateData);


            byte[] expectedStateData = {0x7c, 0xe3, 0x39, 0x82,
                                   0x9b, 0x2f, 0xff, 0x87,
                                   0x34, 0x8e, 0x54, 0x7b,
                                   0x94, 0x32, 0xa6, 0xc2};

            State expectedState = new State(expectedStateData);

            State testState = StartState.subBytesInv();

            Console.Out.WriteLine("InversesubBytes:\n" + testState.ToString());
            Assert.AreEqual(expectedState.ToString(), testState.ToString());

        }

        [TestMethod]
        public void TestMixColumnsInv()
        {
            byte[] StartingStateData = { 0x10, 0x11, 0x12, 0x13, 
                                     0x14, 0x15, 0x16, 0x17, 
                                     0x18, 0x19, 0x20, 0x21, 
                                     0x22, 0x23, 0x24, 0x25 };
            State StartState = new State(StartingStateData);


            byte[] expectedStateData = {0x1a, 0x1f, 0x18, 0x1d,
                                   0x1e, 0x1b, 0x1c, 0x19,
                                   0xfa, 0x8b, 0xc2, 0xb3,
                                   0x38, 0x35, 0x3e, 0x33};

            State expectedState = new State(expectedStateData);

            State testState = StartState.mixColumnsInv();

            Console.Out.WriteLine("InversesubBytes:\n" + testState.ToString());
            Assert.AreEqual(expectedState.ToString(), testState.ToString());
        }

        [TestMethod]
        public void TestShiftRowsInv()
        {
            byte[] StartingStateData = { 0x10, 0x11, 0x12, 0x13, 
                                     0x14, 0x15, 0x16, 0x17, 
                                     0x18, 0x19, 0x20, 0x21, 
                                     0x22, 0x23, 0x24, 0x25 };
            State StartState = new State(StartingStateData);

            byte[] expectedStateData = { 0x10, 0x23, 0x20, 0x17, 
                                         0x14, 0x11, 0x24, 0x21, 
                                         0x18, 0x15, 0x12, 0x25, 
                                         0x22, 0x19, 0x16, 0x13  };
            State expectedState = new State(expectedStateData);

            StartState = StartState.shiftRowsInv();

            Console.Out.WriteLine("shift:\n" + StartState);
            Assert.AreEqual(StartState.ToString(), expectedState.ToString());
        }
    }
}
