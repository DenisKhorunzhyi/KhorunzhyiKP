using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KhorunzhyyKP;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private readonly string FI_correct_no_b_1 = "5 0 3 0 2 4 5 0 3 5 0 1 3 4 0";
        private readonly string FI_correct_no_b_2 = "3 0 4 5 6 0 1 0 2 0 2 6 0 2 5 0";
        private readonly string FI_correct_b_1 = "2 7 0 1 3 0 2 4 0 3 5 0 4 6 0 5 7 0 1 6 0";
        private readonly string FI_correct_b_2 = "3 6 7 8 9 0 3 4 5 7 9 0 1 2 0 2 7 0 2 6 9 0 1 5 9 0 1 2 4 0 1 9 0 1 2 5 6 8 0";
        private readonly string FI_incorrect_minus = "3 0 4 5 6 0 1 0 2 0 2 6 0 2 5 0";
        private readonly string FI_incorrect = "2 5 0 1 3 4 5 0 2 4 0 2 3 6 0 1 2 4 0";
        private readonly string FI_null = null;

        [TestMethod]
        public void check_correct_FI_test(){
            GraphFI fi = new GraphFI(FI_correct_no_b_1);
            Assert.AreEqual(true, fi.CheckFI(fi.FI));
        }
        [TestMethod]
        public void check_incorrect_minus_FI_test(){
            try{
                GraphFI fi = new GraphFI(FI_incorrect_minus);
            }
            catch{
                Assert.IsFalse(true);
            }
        }
        [TestMethod]
        public void check_incorrect_FI_test() {
            try {
                GraphFI fi = new GraphFI(FI_incorrect);
            }
            catch {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void check_nulled_graph_FI_test() {
            try {
                GraphFI fi = new GraphFI(FI_null);
            }
            catch {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void check_1_b() {
            GraphFI fi = new GraphFI(FI_correct_b_1);
            Biconnected biconnected = new Biconnected(fi.Matrix);
            Assert.AreEqual(true, biconnected.IsBC());
        }
        [TestMethod]
        public void check_2_b() {
            GraphFI fi = new GraphFI(FI_correct_b_2);
            Biconnected biconnected = new Biconnected(fi.Matrix);
            Assert.AreEqual(true, biconnected.IsBC());
        }
        [TestMethod]
        public void check_1_no_b() {
            GraphFI fi = new GraphFI(FI_correct_no_b_1);
            Biconnected biconnected = new Biconnected(fi.Matrix);
            Assert.AreEqual(false, biconnected.IsBC());
        }
        [TestMethod]
        public void check_2_no_b() {
            GraphFI fi = new GraphFI(FI_correct_no_b_2);
            Biconnected biconnected = new Biconnected(fi.Matrix);
            Assert.AreEqual(false, biconnected.IsBC());
        }
    }
}
