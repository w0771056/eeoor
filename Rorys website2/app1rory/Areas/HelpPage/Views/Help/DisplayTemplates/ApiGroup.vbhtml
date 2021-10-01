@Imports System.Web.Http
@Imports System.Web.Http.Controllers
@Imports System.Web.Http.Description
@Imports app1rory.Areas.HelpPage
@ModelType IGrouping(Of HttpControllerDescriptor, ApiDescription)

@Code
    Dim controllerDocumentation As String = If(Not ViewData("DocumentationProvider") Is Nothing,
        ViewData("DocumentationProvider").GetDocumentation(Model.Key),
        Nothing)
End Code

<h2 id="@Model.Key.ControllerName">@Model.Key.ControllerName</h2>
@If Not controllerDocumentation Is Nothing Then
    @<p>@controllerDocumentation</p>
End If
<div>
    <p>I have a vast collection of beautiful pictures.</p>
    <img src="~/Resources/pic8.jpg" alt="Choppers" width="300" height="300" />
</div>
 