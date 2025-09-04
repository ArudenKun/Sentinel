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
public static partial class SukiTransitioningContentControl_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiTransitioningContentControl 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiTransitioningContentControl 
   => control._set(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiTransitioningContentControl 
=> control._setEx(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiTransitioningContentControl 
   => control._set(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiTransitioningContentControl 
   => control._set(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiTransitioningContentControl 
=> control._setEx(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiTransitioningContentControl 
=> style._addSetter(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiTransitioningContentControl 
=> style._addSetter(SukiUI.Controls.SukiTransitioningContentControl.ContentProperty, binding);



}
