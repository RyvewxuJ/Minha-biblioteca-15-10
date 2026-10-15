namespace Minha_biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoLivroToolStripMenuItem = new ToolStripMenuItem();
            editarLivroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            buscarLivrosToolStripMenuItem = new ToolStripMenuItem();
            deletarLivrosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem1 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, buscarToolStripMenuItem, configuraçõesToolStripMenuItem, arquivoToolStripMenuItem1, sobreToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowCheckMargin = true;
            contextMenuStrip1.Size = new Size(203, 136);
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoLivroToolStripMenuItem, editarLivroToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(202, 22);
            arquivoToolStripMenuItem.Text = "Arquivo";
            arquivoToolStripMenuItem.Click += arquivoToolStripMenuItem_Click;
            // 
            // novoLivroToolStripMenuItem
            // 
            novoLivroToolStripMenuItem.Name = "novoLivroToolStripMenuItem";
            novoLivroToolStripMenuItem.Size = new Size(132, 22);
            novoLivroToolStripMenuItem.Text = "Novo Livro";
            // 
            // editarLivroToolStripMenuItem
            // 
            editarLivroToolStripMenuItem.Name = "editarLivroToolStripMenuItem";
            editarLivroToolStripMenuItem.Size = new Size(132, 22);
            editarLivroToolStripMenuItem.Text = "Editar livro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(132, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarLivrosToolStripMenuItem, deletarLivrosToolStripMenuItem });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(202, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // buscarLivrosToolStripMenuItem
            // 
            buscarLivrosToolStripMenuItem.Name = "buscarLivrosToolStripMenuItem";
            buscarLivrosToolStripMenuItem.Size = new Size(142, 22);
            buscarLivrosToolStripMenuItem.Text = "Buscar livros";
            // 
            // deletarLivrosToolStripMenuItem
            // 
            deletarLivrosToolStripMenuItem.Name = "deletarLivrosToolStripMenuItem";
            deletarLivrosToolStripMenuItem.Size = new Size(142, 22);
            deletarLivrosToolStripMenuItem.Text = "Deletar livros";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impressorasToolStripMenuItem, bancoDeDadosToolStripMenuItem, usuariosToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(202, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(158, 22);
            impressorasToolStripMenuItem.Text = "Impressoras";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(158, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(158, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gerenciarUsuariosToolStripMenuItem
            // 
            gerenciarUsuariosToolStripMenuItem.Name = "gerenciarUsuariosToolStripMenuItem";
            gerenciarUsuariosToolStripMenuItem.Size = new Size(172, 22);
            gerenciarUsuariosToolStripMenuItem.Text = "Gerenciar Usuarios";
            // 
            // arquivoToolStripMenuItem1
            // 
            arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            arquivoToolStripMenuItem1.Size = new Size(202, 22);
            arquivoToolStripMenuItem1.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(202, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 364);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 63);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minha biblioteca";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem novoLivroToolStripMenuItem;
        private ToolStripMenuItem editarLivroToolStripMenuItem;
        private ToolStripMenuItem buscarLivrosToolStripMenuItem;
        private ToolStripMenuItem deletarLivrosToolStripMenuItem;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem gerenciarUsuariosToolStripMenuItem;
        private ToolStripMenuItem arquivoToolStripMenuItem1;
        private Label label1;
    }
}
