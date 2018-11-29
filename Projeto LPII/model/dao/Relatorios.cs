using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class Relatorios
    {

        private ProjetoDAO daoProj = new ProjetoDAO();
        private EtapaDAO daoEtapa = new EtapaDAO();

        public bool Cliente (Cliente c)
        {
            bool state = false;
            /* Cria um documento */
            Document doc = new Document(PageSize.A4);
            doc.AddCreationDate();

            List<Projeto> list = daoProj.ListByClient(c.Codigo);

            try
            {
                /* Cria o arquivo PDF */
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc,
                    new FileStream("cliente.pdf", FileMode.Create));

                /* Abre o documento criado */
                doc.Open();

                /* Título do Relatório */
                Paragraph p = new Paragraph();
                p.Alignment = Element.ALIGN_CENTER;
                p.Add("Relatório de Cliente\n");
                p.Add("Emitido em: " + DateTime.Now.ToShortDateString() + "     " +
                    DateTime.Now.ToShortTimeString() + "\n\n\n");

                doc.Add(p);

                p = new Paragraph("Código: " + c.Codigo.ToString() + "     Nome: " + c.Nome);
                doc.Add(p);
                p = new Paragraph("CNPJ: " + c.Cnpj + "     Email: " + c.Email + "     Telefone: " + c.Telefone);
                doc.Add(p);
                p = new Paragraph("Responsável: " + c.Responsavel);
                doc.Add(p);
                p = new Paragraph("   ");
                doc.Add(p);
                p = new Paragraph("Endereço: ");
                doc.Add(p);
                p = new Paragraph(c.Rua + ", " + c.Numero.ToString() + " - CEP: " + c.Cep);
                doc.Add(p);
                p = new Paragraph("Cidade: " + c.Cidade + " / " + c.Estado);
                doc.Add(p);
                p = new Paragraph("   ");
                doc.Add(p);

                if (list.Count > 0)
                {
                    p = new Paragraph("PROJETOS");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p = new Paragraph("   ");
                    doc.Add(p);

                    foreach (Projeto projeto in list)
                    {
                        p = new Paragraph("Código: " + projeto.Codigo.ToString() + "     Nome: " + projeto.Nome);
                        doc.Add(p);
                        p = new Paragraph("Situação: " + projeto.Situacao);
                        doc.Add(p);
                        p = new Paragraph("Data de Início: " + projeto.DataInicio.ToString() + "     Previsão de término: " + projeto.PrevisaoTermino.ToString());
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                    }
                }
                else
                {
                    p = new Paragraph("** Não há projetos vinculados ao cliente");
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                }
                
                doc.Close();

                state = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar relatório de cliente.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return state;
        }

        public bool Colaborador(Colaborador c)
        {
            bool state = false;
            /* Cria um documento */
            Document doc = new Document(PageSize.A4);
            doc.AddCreationDate();

            List<Projeto> list = daoProj.ListByCollaborator(c.Codigo);

            try
            {
                /* Cria o arquivo PDF */
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc,
                    new FileStream("colaborador.pdf", FileMode.Create));

                /* Abre o documento criado */
                doc.Open();

                /* Título do Relatório */
                Paragraph p = new Paragraph();
                p.Alignment = Element.ALIGN_CENTER;
                p.Add("Relatório de Colaborador\n");
                p.Add("Emitido em: " + DateTime.Now.ToShortDateString() + "     " +
                    DateTime.Now.ToShortTimeString() + "\n\n\n");

                doc.Add(p);

                p = new Paragraph("Código: " + c.Codigo.ToString() + "     Nome: " + c.Nome);
                doc.Add(p);
                p = new Paragraph("Email: " + c.Email);
                doc.Add(p);
                p = new Paragraph("Telefone: " + c.Telefone);
                doc.Add(p);
                p = new Paragraph("Cargo: " + c.Cargo);
                doc.Add(p);
                p = new Paragraph("Número do RH: " + c.NroRh.ToString());
                doc.Add(p);
                p = new Paragraph("   ");
                doc.Add(p);

                if (list.Count > 0)
                {
                    p = new Paragraph("PROJETOS");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p = new Paragraph("   ");
                    doc.Add(p);

                    foreach (Projeto projeto in list)
                    {
                        p = new Paragraph("Código: " + projeto.Codigo.ToString() + "     Nome: " + projeto.Nome);
                        doc.Add(p);
                        p = new Paragraph("Situação: " + projeto.Situacao);
                        doc.Add(p);
                        p = new Paragraph("Data de Início: " + projeto.DataInicio.ToString() + "     Previsão de término: " + projeto.PrevisaoTermino.ToString());
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                    }
                }
                else
                {
                    p = new Paragraph("** Não há projetos vinculados ao colaborador");
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                }


                doc.Close();

                state = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar relatório de colaborador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return state;
        }

        public bool Projeto(Projeto proj)
        {
            bool state = false;
            /* Cria um documento */
            Document doc = new Document(PageSize.A4);
            doc.AddCreationDate();

            List<Etapa> list = daoEtapa.ListInProject(proj.Codigo);

            try
            {
                /* Cria o arquivo PDF */
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc,
                    new FileStream("projeto.pdf", FileMode.Create));

                /* Abre o documento criado */
                doc.Open();

                /* Título do Relatório */
                Paragraph p = new Paragraph();
                p.Alignment = Element.ALIGN_CENTER;
                p.Add("Relatório de Projeto\n");
                p.Add("Emitido em: " + DateTime.Now.ToShortDateString() + "     " +
                    DateTime.Now.ToShortTimeString() + "\n\n\n");

                doc.Add(p);

                p = new Paragraph("Código: " + proj.Codigo.ToString() + "     Nome: " + proj.Nome);
                doc.Add(p);
                p = new Paragraph("Situação: " + proj.Situacao);
                doc.Add(p);
                p = new Paragraph("Data de Início: " + proj.DataInicio.ToString() + "     Previsão de término: " + proj.PrevisaoTermino.ToString());
                doc.Add(p);
                p = new Paragraph("   ");
                doc.Add(p);

                if (list.Count > 0)
                {
                    p = new Paragraph("ETAPAS");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p = new Paragraph("   ");
                    doc.Add(p);

                    foreach (Etapa e in list)
                    {
                        p = new Paragraph("Código: " + e.Codigo.ToString() + "     Nome: " + e.Nome + "     Situação: " + e.Situacao);
                        doc.Add(p);
                        p = new Paragraph("Data de Início: " + e.DataInicio.ToString() + "     Previsão de término: " + e.PrevisaoTermino.ToString());
                        doc.Add(p);
                        p = new Paragraph("Descrição: ");
                        doc.Add(p);
                        p = new Paragraph(e.Descricao);
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                        p = new Paragraph("   ");
                        doc.Add(p);
                    }
                }
                else
                {
                    p = new Paragraph("** Não há etapas vinculadas ao projeto");
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                }

                doc.Close();

                state = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar relatório de projeto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return state;
        }
    }
}
