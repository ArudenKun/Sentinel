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
public static partial class SukiStackPage_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiStackPage 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Limit

/*ValueSetterGenerator*/
public static T Limit<T>(this T control, System.Int32 value) where T : SukiUI.Controls.SukiStackPage 
=> control._set(() => control.Limit = value!);

/*BindFromExpressionSetterGenerator*/
public static T Limit<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.LimitProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Limit<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.LimitProperty, ps, () => control.Limit = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Limit<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.LimitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Limit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.LimitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Limit<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.LimitProperty, ps, () => control.Limit = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AlwaysGoBackToFirstPage

/*ValueSetterGenerator*/
public static T AlwaysGoBackToFirstPage<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiStackPage 
=> control._set(() => control.AlwaysGoBackToFirstPage = value!);

/*BindFromExpressionSetterGenerator*/
public static T AlwaysGoBackToFirstPage<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AlwaysGoBackToFirstPage<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty, ps, () => control.AlwaysGoBackToFirstPage = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AlwaysGoBackToFirstPage<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlwaysGoBackToFirstPage<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiStackPage 
   => control._set(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AlwaysGoBackToFirstPage<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiStackPage 
=> control._setEx(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty, ps, () => control.AlwaysGoBackToFirstPage = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.ContentProperty, binding);


 // Limit

/*ValueStyleSetterGenerator*/
public static Style<T> Limit<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.LimitProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Limit<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.LimitProperty, binding);


 // AlwaysGoBackToFirstPage

/*ValueStyleSetterGenerator*/
public static Style<T> AlwaysGoBackToFirstPage<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AlwaysGoBackToFirstPage<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiStackPage 
=> style._addSetter(SukiUI.Controls.SukiStackPage.AlwaysGoBackToFirstPageProperty, binding);



}
