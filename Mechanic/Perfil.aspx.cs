using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perfil : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    Mongodb bd = new Mongodb();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {

                Label5.Text = Session["Usuario"].ToString();
                Label6.Text = Session["Apellido"].ToString();
                Label7.Text = Session["Carrera"].ToString();
                Label8.Text = Session["Semestre"].ToString();
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Empresa");
                dt.Columns.Add("Cargo");
                dt.Columns.Add("Fecha Inicio");
                dt.Columns.Add("Fecha Fin");
                dt.Columns.Add("Correo registrado");
                String[] datos = bd.ofertas("Trabajo", "Correo Registrado", Session["Correo"].ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    String[] aux = datos[i].Split(',');
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (j != 0)
                        {
                            aux[j] = (aux[j].Substring(aux[j].LastIndexOf(':') + 2)).Replace("\"", "");
                        }
                        else
                        {
                            aux[j] = aux[j].Replace(")", "");
                            aux[j] = (aux[j].Substring(aux[j].LastIndexOf('(') + 2)).Replace("\"", "");
                        }
                    }
                    dt.Rows.Add(aux);

                }
                GridView1.DataSource = dt;
                /*GridView1.Columns[1].Visible = false;*/
                GridView1.DataBind();

            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Empleos.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SubirTrabajo.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Amigos.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Default.aspx");
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}