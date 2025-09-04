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
public static partial class LucideIcon_MarkupExtensions
{
//================= Properties ======================//
 // Size

/*ValueSetterGenerator*/
public static T Size<T>(this T control, System.Double value) where T : Lucide.Avalonia.LucideIcon 
=> control._set(() => control.Size = value!);

/*BindFromExpressionSetterGenerator*/
public static T Size<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.SizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Size<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.SizeProperty, ps, () => control.Size = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Size<T>(this T control, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.SizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Size<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Size<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.SizeProperty, ps, () => control.Size = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Lucide.Avalonia.LucideIcon 
=> control._set(() => control.Foreground = value!);

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.ForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.ForegroundProperty, ps, () => control.Foreground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StrokeWidth

/*ValueSetterGenerator*/
public static T StrokeWidth<T>(this T control, System.Double value) where T : Lucide.Avalonia.LucideIcon 
=> control._set(() => control.StrokeWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T StrokeWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.StrokeWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StrokeWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.StrokeWidthProperty, ps, () => control.StrokeWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeWidth<T>(this T control, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.StrokeWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.StrokeWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StrokeWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.StrokeWidthProperty, ps, () => control.StrokeWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Kind

/*ValueSetterGenerator*/
public static T Kind<T>(this T control, System.Nullable<Lucide.Avalonia.LucideIconKind> value) where T : Lucide.Avalonia.LucideIcon 
=> control._set(() => control.Kind = value!);

/*BindFromExpressionSetterGenerator*/
public static T Kind<T>(this T control, Func<System.Nullable<Lucide.Avalonia.LucideIconKind>> func, Action<System.Nullable<Lucide.Avalonia.LucideIconKind>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.KindProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Kind<T>(this T control,System.Nullable<Lucide.Avalonia.LucideIconKind> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.KindProperty, ps, () => control.Kind = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Kind<T>(this T control, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.KindProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Kind<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Lucide.Avalonia.LucideIcon 
   => control._set(Lucide.Avalonia.LucideIcon.KindProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Kind<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<Lucide.Avalonia.LucideIconKind>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Lucide.Avalonia.LucideIcon 
=> control._setEx(Lucide.Avalonia.LucideIcon.KindProperty, ps, () => control.Kind = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Size

/*ValueStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, System.Double value) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.SizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.SizeProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.ForegroundProperty, binding);


 // StrokeWidth

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeWidth<T>(this Style<T> style, System.Double value) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.StrokeWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeWidth<T>(this Style<T> style, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.StrokeWidthProperty, binding);


 // Kind

/*ValueStyleSetterGenerator*/
public static Style<T> Kind<T>(this Style<T> style, System.Nullable<Lucide.Avalonia.LucideIconKind> value) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.KindProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Kind<T>(this Style<T> style, IBinding binding) where T : Lucide.Avalonia.LucideIcon 
=> style._addSetter(Lucide.Avalonia.LucideIcon.KindProperty, binding);



}
