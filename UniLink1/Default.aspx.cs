using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
 
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Mongodb bd = new Mongodb();
        String[] values = bd.login("User","Correo", TextBox1.Text, TextBox2.Text);
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = (values[i].Substring(values[i].LastIndexOf(':') + 2)).Replace("\"", "");
        }
        if (values.Length != 1)
        {

            if (values[4] == TextBox2.Text)
            {
                Session["Usuario"] = values[1];
                Session["Apellido"] = values[2];
                Session["Correo"] = values[3];
                Session["Carrera"] = values[5];
                Session["Semestre"] = values[6];
                Session["Busqueda"] = "Buscar en Empleos";
                Response.Redirect("Index.aspx");
                mensaje("Inicio Correcto");
            }
        }
        else
        {
            mensaje("Correo o contraseña incorrecto, intente nuevamente");
        }

    }
    public void mensaje(String mensaje)
    {
        string script = "alert(\"" + mensaje + "\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }
}