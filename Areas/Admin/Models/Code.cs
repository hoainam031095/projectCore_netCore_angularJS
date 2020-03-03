using CongThongTin.App_Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CongThongTin.Areas.Admin.Models
{
    public class Code
    {
        public static void SyncTbRoutes()
        {
            congthongtinContext db = new congthongtinContext();
            List<string> listControllerSkipRoutes = new List<string>() { "Logout", "GetCaptcha", "Home", "Login" };
            var rt = new List<TbRoute>();

            var assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Controller)) && t.IsPublic && !t.IsAbstract);
            var tt = assembly.GetTypes().Where(m => m.IsSubclassOf(typeof(Controller)) && m.IsPublic && !m.IsAbstract);
            foreach (var type in tt)
            {
                string _namespace = type.Namespace;
                string _controllerName = type.Name.Substring(0, type.Name.IndexOf("Controller", System.StringComparison.InvariantCulture));

                if (!listControllerSkipRoutes.Contains(_controllerName)) //Bỏ qua các controller trong danh sách không thêm vào route
                {
                    if (type.CustomAttributes.Where(c => c.AttributeType == typeof(Permission)).Any())
                    {
                        var methods = type.GetMethods().Where(x => x.IsPublic && x.DeclaringType.Equals(type));
                        foreach (var method in methods)
                        {
                            string _actionName = method.Name;
                            rt.Add(new TbRoute()
                            {
                                Namespace = _namespace,
                                ControllerName = _controllerName,
                                ActionName = _actionName,
                                Name = _actionName
                            });
                        }
                    }
                    else
                    {
                        var methods = type.GetMethods()
                        .Where(x => x.CustomAttributes.Where(c => c.AttributeType == typeof(Permission)).Any() && x.IsPublic && x.DeclaringType.Equals(type));
                        foreach (var method in methods)
                        {
                            string _actionName = method.Name;
                            rt.Add(new TbRoute()
                            {
                                Namespace = _namespace,
                                ControllerName = _controllerName,
                                ActionName = _actionName,
                                Name = _actionName
                            });
                        }
                    }

                }
            }

            //Remove route from db when non exist in new list route
            db.TbRoute
                .AsEnumerable()
                .Where(p => !rt.Any(p2 => p2.Namespace == p.Namespace && p2.ControllerName == p.ControllerName && p2.ActionName == p.ActionName))
                .ToList()
                .All(p =>
                {
                    db.TbRoute.Remove(p);
                    db.SaveChanges();
                    return true;
                });

            //Add route from new list route when non exist in db
            rt.Where(p => !db.TbRoute.Any(p2 => p2.Namespace == p.Namespace && p2.ControllerName == p.ControllerName && p2.ActionName == p.ActionName))
                .All(p =>
                {
                    db.TbRoute.Add(p);
                    db.SaveChanges();
                    return true;
                });

            //Remove action from db when non exist in new list page
            db.TbAction
                .AsEnumerable()
                .Where(p => !rt.GroupBy(p2 => new
                {
                    p2.Namespace,
                    p2.ControllerName,
                    p2.ActionName
                }, p2 => p2, (key, g) => new
                {
                    key,
                    g
                })
                .Any(p2 => p2.key.Namespace == p.Namespace && p2.key.ControllerName == p.ControllerName && p2.key.ActionName == p.Action))
                .ToList()
                .All(p =>
                {
                    db.TbAction.Remove(p);
                    db.SaveChanges();
                    return true;
                });

            //Remove controller from db when non exist in new list page
            db.TbController
                .AsEnumerable()
                .Where(p => !rt.GroupBy(p2 => new
                {
                    p2.Namespace,
                    p2.ControllerName
                }, p2 => p2, (key, g) => new
                {
                    key,
                    g
                })
                .Any(p2 => (p2.key.Namespace == p.Namespace && p2.key.ControllerName == p.Controller) || (p.ParentId == null && p.Level == 1)))
                .ToList()
                .All(p =>
                {
                    db.TbController.Remove(p);
                    db.SaveChanges();
                    return true;
                });

            //Add action from new list page when non exist in db
            rt.GroupBy(p2 => new
            {
                p2.Namespace,
                p2.ControllerName,
                p2.ActionName
            }, p2 => p2, (key, g) => new
            {
                key,
                g
            }).Where(p2 => !db.TbAction.Any(p => p2.key.Namespace == p.Namespace && p2.key.ControllerName == p.ControllerName && p2.key.ActionName == p.Action))
                .ToList().ForEach(p =>
                {
                    var ctrl = db.TbController.FirstOrDefault(ct => ct.Namespace == p.key.Namespace && ct.Controller == p.key.ControllerName);
                    var newAction = new TbAction()
                    {
                        Action = p.key.ActionName,
                        Name = p.key.ActionName,
                        Display = p.key.ActionName,
                        Url = "/" + p.key.ActionName,
                        Namespace = p.key.Namespace,
                        ControllerName = p.key.ControllerName,
                        IsActive = true,
                        IsDelete = false
                    };
                    if (ctrl != null)
                    {
                        newAction.Controller = ctrl;
                    }
                    else
                    {
                        newAction.Controller = new TbController()
                        {
                            Controller = p.key.ControllerName,
                            Name = p.key.ControllerName,
                            Display = p.key.ControllerName,
                            Namespace = p.key.Namespace,
                            Url = "/admin/" + p.key.ControllerName,
                            Level = 2,
                            ParentId = 1,
                            IsActive = true,
                            IsDelete = false
                        };
                    }

                    db.TbAction.Add(newAction);

                    db.SaveChanges();
                });
        }
    }
}
