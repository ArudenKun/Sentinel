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
public static partial class TextEraserButton_MarkupExtensions
{
//================= Properties ======================//
 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : SukiUI.Theme.TextEraserButton 
=> control._set(() => control.Text = value!);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Theme.TextEraserButton 
   => control._set(SukiUI.Theme.TextEraserButton.TextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Theme.TextEraserButton 
=> control._setEx(SukiUI.Theme.TextEraserButton.TextProperty, ps, () => control.Text = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : SukiUI.Theme.TextEraserButton 
   => control._set(SukiUI.Theme.TextEraserButton.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Theme.TextEraserButton 
   => control._set(SukiUI.Theme.TextEraserButton.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Theme.TextEraserButton 
=> control._setEx(SukiUI.Theme.TextEraserButton.TextProperty, ps, () => control.Text = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : SukiUI.Theme.TextEraserButton 
=> style._addSetter(SukiUI.Theme.TextEraserButton.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : SukiUI.Theme.TextEraserButton 
=> style._addSetter(SukiUI.Theme.TextEraserButton.TextProperty, binding);



}
