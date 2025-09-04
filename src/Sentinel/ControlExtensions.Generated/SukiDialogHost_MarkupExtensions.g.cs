#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class SukiDialogHost_MarkupExtensions
{
//================= Properties ======================//
 // Manager

/*ValueSetterGenerator*/
public static T Manager<T>(this T control, SukiUI.Dialogs.ISukiDialogManager value) where T : SukiUI.Controls.SukiDialogHost 
=> control._set(() => control.Manager = value!);

/*BindFromExpressionSetterGenerator*/
public static T Manager<T>(this T control, Func<SukiUI.Dialogs.ISukiDialogManager> func, Action<SukiUI.Dialogs.ISukiDialogManager>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialogHost 
   => control._set(SukiUI.Controls.SukiDialogHost.ManagerProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Manager<T>(this T control,SukiUI.Dialogs.ISukiDialogManager value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialogHost 
=> control._setEx(SukiUI.Controls.SukiDialogHost.ManagerProperty, ps, () => control.Manager = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Manager<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialogHost 
   => control._set(SukiUI.Controls.SukiDialogHost.ManagerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Manager<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialogHost 
   => control._set(SukiUI.Controls.SukiDialogHost.ManagerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Manager<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Dialogs.ISukiDialogManager> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialogHost 
=> control._setEx(SukiUI.Controls.SukiDialogHost.ManagerProperty, ps, () => control.Manager = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Manager

/*ValueStyleSetterGenerator*/
public static Style<T> Manager<T>(this Style<T> style, SukiUI.Dialogs.ISukiDialogManager value) where T : SukiUI.Controls.SukiDialogHost 
=> style._addSetter(SukiUI.Controls.SukiDialogHost.ManagerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Manager<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialogHost 
=> style._addSetter(SukiUI.Controls.SukiDialogHost.ManagerProperty, binding);



}
