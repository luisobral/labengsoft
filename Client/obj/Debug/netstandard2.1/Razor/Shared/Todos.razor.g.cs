#pragma checksum "C:\Users\User\source\repos\app\Client\Shared\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7083b9697b83ab1e4268117479dcef872fb2f0ab"
// <auto-generated/>
#pragma warning disable 1591
namespace app.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using app.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using app.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\app\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
using BlazorAppProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Text>(0);
            __builder.AddAttribute(1, "typeof", "utf-8");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "col-md-12");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<h1>Lista de afazeres</h1>\r\n        ");
                __builder2.OpenComponent<Blazorise.Container>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.Addons>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Addon>(14);
                        __builder4.AddAttribute(15, "AddonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.AddonType>(
#nullable restore
#line 8 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                  AddonType.Body

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.TextEdit>(18);
                            __builder5.AddAttribute(19, "Placeholder", "Coisas a fazer");
                            __builder5.AddAttribute(20, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                                                       newTodo

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(21, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTodo = __value, newTodo))));
                            __builder5.AddAttribute(22, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTodo));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(23, "\r\n\r\n\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Addon>(25);
                        __builder4.AddAttribute(26, "AddonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.AddonType>(
#nullable restore
#line 13 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                  AddonType.End

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(28, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Button>(29);
                            __builder5.AddAttribute(30, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 14 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                   Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                                            AddTask

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(33, "Add");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(34, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.Alert>(37);
                    __builder3.AddAttribute(38, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 17 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                          Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(40, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.AlertMessage>(41);
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(43, "Adicionado com sucesso!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(45);
                        __builder4.AddAttribute(46, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                       Hide_add

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n            ");
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 17 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                               sucesso = (Blazorise.Alert)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.Alert>(50);
                    __builder3.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 21 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                          Color.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(53, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.AlertMessage>(54);
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(56, "Insira uma mensagem!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(58);
                        __builder4.AddAttribute(59, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                       Hide_add

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n            ");
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(61, (__value) => {
#nullable restore
#line 21 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                              erro = (Blazorise.Alert)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenComponent<Blazorise.Table>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.TableHeader>(67);
                    __builder3.AddAttribute(68, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 27 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                        ThemeContrast.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.TableBody>(70);
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(72, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Addons>(73);
                        __builder4.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(75, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Switch<bool>>(76);
                            __builder5.AddAttribute(77, "style", "margin-right:50px;");
                            __builder5.AddAttribute(78, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 30 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                                          tipo

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(79, "CheckedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tipo = __value, tipo))));
                            __builder5.AddAttribute(80, "CheckedExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => tipo));
                            __builder5.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(82, "Qual tipo deseja visualizar?");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(83, "\r\n");
#nullable restore
#line 31 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                     if (tipo)
                    {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(84, "                        ");
                            __builder5.OpenComponent<Blazorise.TableRow>(85);
                            __builder5.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(87, "\r\n                            ");
                                __builder6.AddMarkupContent(88, "<h6>Itens a fazer</h6>\r\n                        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\r\n");
#nullable restore
#line 36 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(90, "                        ");
                            __builder5.OpenComponent<Blazorise.TableRow>(91);
                            __builder5.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(93, "\r\n                            ");
                                __builder6.AddMarkupContent(94, "<h6>Itens feitos</h6>\r\n                        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(95, "\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                    }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(96, "                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(97, "\r\n");
#nullable restore
#line 44 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                 foreach (var item in listaTodo)
                {
                    if (tipo == true)
                    {
                        if (!(item.Feito))
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(98, "                            ");
                        __builder4.OpenComponent<Blazorise.TableRow>(99);
                        __builder4.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(101, "\r\n                                ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(102);
                            __builder5.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(104, "\r\n                                    ");
                                __builder6.OpenComponent<Blazorise.Check<bool>>(105);
                                __builder6.AddAttribute(106, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 52 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                                                          item.Feito

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(107, "CheckedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Feito = __value, item.Feito))));
                                __builder6.AddAttribute(108, "CheckedExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => item.Feito));
                                __builder6.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(110, 
#nullable restore
#line 52 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                                                                       item.Titulo

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(111, "\r\n\r\n                                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(112, "\r\n\r\n                            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(113, "\r\n");
#nullable restore
#line 57 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"

                        }
                    }
                    else
                    {
                        if (item.Feito)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(114, "                            ");
                        __builder4.OpenComponent<Blazorise.TableRow>(115);
                        __builder4.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(117, "\r\n                                ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(118);
                            __builder5.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(120, "\r\n                                    ");
                                __builder6.OpenElement(121, "h6");
                                __builder6.AddContent(122, 
#nullable restore
#line 66 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
                                         item.Titulo

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(123, "\r\n                                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(124, "\r\n\r\n                            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(125, "\r\n");
#nullable restore
#line 70 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"

                        }
                    }
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(126, "            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\User\source\repos\app\Client\Shared\Todos.razor"
      
    Alert sucesso;
    Alert erro;
    bool tipo = true;


    public string newTodo { get; set; }

    private void Alerta(Alert alerta)
    {
        alerta.Show();
    }

    private void AddTask()
    {
        if (newTodo != null)
        {
            listaTodo.Add(new Todo() { Titulo = newTodo });
            Alerta(sucesso);
        }
        else
        {
            Alerta(erro);
        }
    }

    void Hide_add()
    {
        sucesso.Hide();
        erro.Hide();
    }

    List<Todo> listaTodo;
    protected override void OnInitialized()
    {
        listaTodo = new List<Todo>();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
