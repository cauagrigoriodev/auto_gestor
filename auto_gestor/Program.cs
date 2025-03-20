var builder = WebApplication.CreateBuilder(args);
// Cria um novo objeto WebApplicationBuilder para configurar o aplicativo ASP.NET Core.


// Adiciona servi�os ao cont�iner de inje��o de depend�ncias.
builder.Services.AddControllersWithViews();
// Habilita o uso do padr�o MVC com suporte a Views.

var app = builder.Build();
// Constr�i a aplica��o com as configura��es definidas anteriormente.


// Configura o pipeline de requisi��es HTTP.
if (!app.Environment.IsDevelopment())
// Verifica se o ambiente **n�o** � de desenvolvimento.
{
    app.UseExceptionHandler("/Home/Error");
    // Define um manipulador de erros que redireciona para a p�gina "Home/Error".

    app.UseHsts();
    // Habilita a pol�tica de HTTP Strict Transport Security (HSTS) para for�ar conex�es seguras (HTTPS).
}

// Middleware para redirecionamento de HTTP para HTTPS.
app.UseHttpsRedirection();

// Middleware para servir arquivos est�ticos (CSS, JS, imagens, etc.).
app.UseStaticFiles();

// Middleware para definir o roteamento das requisi��es HTTP.
app.UseRouting();

// Middleware para controle de autentica��o e autoriza��o.
app.UseAuthorization();

// Define a rota padr�o do MVC.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Isso significa que a URL padr�o chamar� o controlador "Home" e a a��o "Index".
// O par�metro "id?" � opcional.

app.Run();
// Inicia a aplica��o e come�a a escutar as requisi��es.
