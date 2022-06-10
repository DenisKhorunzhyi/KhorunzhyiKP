using System;
using System.Windows.Forms;

namespace KhorunzhyyKP
{
    public class GraphClient
    {
        public GraphFI FI { get; private set; }
        public bool Biconnected { get; private set; }

        private PictureBox panel;
        
        public GraphClient(PictureBox panel){
            this.panel = panel;
        }
        
        public void CreateGraph(string FI){
            Biconnected = false;
            try{
                this.FI = new GraphFI(FI);
            }
            catch{
                throw new Exception("Помилка при заданні графу");
            }
            try{
                Biconnected biconnected = new Biconnected(this.FI.Matrix);
                Biconnected = biconnected.IsBC();
            }
            catch{
                throw new Exception("Помилка при розрахунку двозв'язності");
            }
            try
            {
                BuildGraph build = new BuildGraph(panel, this.FI.Matrix);
                build.DrawGraph();
            }
            catch
            {
                throw new Exception("Помилка при малювані графа(ів)");
            }
        }
    }
}