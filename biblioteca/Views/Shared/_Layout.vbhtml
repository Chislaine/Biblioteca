<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title Biblioteca </title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

    <style>

        .espacoMenu {
            margin-left: 90px;
        }

        .criaConta{
            margin-left:50px;
        }
    </style>
</head>

 
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Biblioteca", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="espacoMenu">@Html.ActionLink("Início", "Index", "Home")</li>
                    <li>@Html.ActionLink("Sobre", "About", "Home")</li>
                    <li>@Html.ActionLink("Contato", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Lançamentos", "releases", "Home")</li>
                    <li>@Html.ActionLink("Eventos", "Events", "Home")</li>
                    <li>@Html.ActionLink("Categorias", "categories", "Home")</li>
                    <li>@Html.ActionLink("Livros", "books", "Home")</li>
                    <li>@Html.ActionLink("eBooks", "eBooks", "Home")</li>
                    <li>@Html.ActionLink("Infantil", "childish", "Home")</li>
                    <li class="criaConta">@Html.ActionLink("CRIE SUA CONTA", "CREATE YOUR ACCOUNT", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Desenvolvido por Chislaine Vorel</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
