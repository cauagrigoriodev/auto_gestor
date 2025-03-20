var builder = WebApplication.CreateBuilder(args);
// Cria um novo objeto WebApplicationBuilder para configurar o aplicativo ASP.NET Core.


// Adiciona serviços ao contêiner de injeção de dependências.
builder.Services.AddControllersWithViews();
// Habilita o uso do padrão MVC com suporte a Views.

var app = builder.Build();
// Constrói a aplicação com as configurações definidas anteriormente.


// Configura o pipeline de requisições HTTP.
if (!app.Environment.IsDevelopment())
// Verifica se o ambiente **não** é de desenvolvimento.
{
    app.UseExceptionHandler("/Home/Error");
    // Define um manipulador de erros que redireciona para a página "Home/Error".

    app.UseHsts();
    // Habilita a política de HTTP Strict Transport Security (HSTS) para forçar conexões seguras (HTTPS).
}

// Middleware para redirecionamento de HTTP para HTTPS.
app.UseHttpsRedirection();

// Middleware para servir arquivos estáticos (CSS, JS, imagens, etc.).
app.UseStaticFiles();

// Middleware para definir o roteamento das requisições HTTP.
app.UseRouting();

// Middleware para controle de autenticação e autorização.
app.UseAuthorization();

// Define a rota padrão do MVC.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Isso significa que a URL padrão chamará o controlador "Home" e a ação "Index".
// O parâmetro "id?" é opcional.

app.Run();
// Inicia a aplicação e começa a escutar as requisições.
