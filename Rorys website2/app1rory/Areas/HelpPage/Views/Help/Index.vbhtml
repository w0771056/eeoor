@Imports System.Web.Http
@Imports System.Web.Http.Controllers
@Imports System.Web.Http.Description
@Imports System.Collections.ObjectModel
@Imports app1rory.Areas.HelpPage
@ModelType Collection(Of ApiDescription)

@Code
    ViewData("Title") = "Rory"

    ' Group APIs by controller
    Dim apiGroups As ILookup(Of HttpControllerDescriptor, ApiDescription) = Model.ToLookup(Function(api) api.ActionDescriptor.ControllerDescriptor)
End Code

<link type="text/css" href="~/Areas/HelpPage/HelpPage.css" rel="stylesheet" />
<header class="help-page">
    <div class="content-wrapper">
        <div class="float-left">
            <h1>@ViewData("Title")</h1>
        </div>
    </div>
</header>
<div id="body" class="help-page">
    <section class="featured">
        <div class="content-wrapper">
            <h2>Introduction</h2>
            <p>
                The more I learn the more I realize it's as if I know nothing at all.
            </p>
            <img src="~/Resources/pic8.jpg" alt="Choppers" width="300" height="300" />
        </div>
     </section>
</div>
