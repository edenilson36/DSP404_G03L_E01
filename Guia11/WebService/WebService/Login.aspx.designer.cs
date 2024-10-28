//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código. 
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace WebService {
    
    
    public partial class Login {
        
        /// <summary>
        /// Control Head1.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlHead Head1;
        
        /// <summary>
        /// Control form1.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;
        
       try
 {
 //Variable que guardar URL de acceso a los recursos del API
 string sURL;
        sURL = "https://localhost:54910/api/Logins";
 //variable para acceso a datos a traves de HTTP
 WebRequest wrGETURL;
        wrGETURL = WebRequest.Create(sURL);
 //Variable para almacenar los valores de lectura del REST
 Stream objStream;
        objStream = wrGETURL.GetResponse().GetResponseStream();
        //Objeto para realizar lectura de los datos obtenidos
        StreamReader objReader = new StreamReader(objStream);
        //Variable para almacenar la respuesta
        string jsonText = "";
        int i = 0;//contador
        int errordatos = 0;//bandera de error
                           //almacenamiento de datos JSON
        jsonText = objReader.ReadLine();
 if (jsonText != null)
 {
 //parseo de String a objeto json
 var jss = new JavaScriptSerializer();
        dynamic result = jss.DeserializeObject(jsonText);
 //Recorre al conjunto de datos devueltos de tabla Login
 for (i = 0; i<result.Length; i++)
 {
 //verificacion de crendenciales
 if (result[i]["Usuario"] == TxtUsuario.Text && result[i]["contrasenia"] == TxtPassword.Text)
 {
 int cant;
        //de consulta, retorna cantidad de contactos del usuario
        cant = result[i]["Contactoes"].Length;
 //si usuario y contraseña son correctos permitir ingreso
 Session.Add("usuario", TxtUsuario.Text);
 Session.Add("cant", cant);
 Response.Redirect("Index.aspx");
 errordatos = 0;
 break;
 }
 else
 {
 errordatos++;
 }
 }
 if (errordatos > 0)
{
    LblError.Text = "Usuario o Contraseña incorrecta, verifique sus datos";
}
 }
 else
{
    LblError.Text = "La respuesta del Servidor de Datos ya tardo mucho, Lamentamos el inconveniente";
}

 }
 catch(Exception ex){
 LblError.Text = "Error con Servicio de Datos, Lamentamos el inconveniente";
 }

        protected global::System.Web.UI.WebControls.Button BtnEntrar;
        
        /// <summary>
        /// Control TxtUsuario.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox TxtUsuario;
        
        /// <summary>
        /// Control TxtPassword.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox TxtPassword;
        
        /// <summary>
        /// Control LblError.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label LblError;
    }
}
