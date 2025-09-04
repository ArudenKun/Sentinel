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
public static partial class InfoBadge_MarkupExtensions
{
//================= Properties ======================//
 // Appearance

/*ValueSetterGenerator*/
public static T Appearance<T>(this T control, Avalonia.Controls.Notifications.NotificationType value) where T : SukiUI.Controls.InfoBadge 
=> control._set(() => control.Appearance = value!);

/*BindFromExpressionSetterGenerator*/
public static T Appearance<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.AppearanceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Appearance<T>(this T control,Avalonia.Controls.Notifications.NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.AppearanceProperty, ps, () => control.Appearance = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Appearance<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.AppearanceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Appearance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.AppearanceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Appearance<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.AppearanceProperty, ps, () => control.Appearance = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CornerPosition

/*ValueSetterGenerator*/
public static T CornerPosition<T>(this T control, SukiUI.Enums.CornerPosition value) where T : SukiUI.Controls.InfoBadge 
=> control._set(() => control.CornerPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T CornerPosition<T>(this T control, Func<SukiUI.Enums.CornerPosition> func, Action<SukiUI.Enums.CornerPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.CornerPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CornerPosition<T>(this T control,SukiUI.Enums.CornerPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.CornerPositionProperty, ps, () => control.CornerPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CornerPosition<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.CornerPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CornerPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.CornerPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CornerPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.CornerPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.CornerPositionProperty, ps, () => control.CornerPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDot

/*ValueSetterGenerator*/
public static T IsDot<T>(this T control, System.Boolean value) where T : SukiUI.Controls.InfoBadge 
=> control._set(() => control.IsDot = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDot<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.IsDotProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDot<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.IsDotProperty, ps, () => control.IsDot = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDot<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.IsDotProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDot<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.IsDotProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDot<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.IsDotProperty, ps, () => control.IsDot = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Overflow

/*ValueSetterGenerator*/
public static T Overflow<T>(this T control, System.Int32 value) where T : SukiUI.Controls.InfoBadge 
=> control._set(() => control.Overflow = value!);

/*BindFromExpressionSetterGenerator*/
public static T Overflow<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.OverflowProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Overflow<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.OverflowProperty, ps, () => control.Overflow = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Overflow<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.OverflowProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Overflow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBadge 
   => control._set(SukiUI.Controls.InfoBadge.OverflowProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Overflow<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBadge 
=> control._setEx(SukiUI.Controls.InfoBadge.OverflowProperty, ps, () => control.Overflow = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Appearance

/*ValueStyleSetterGenerator*/
public static Style<T> Appearance<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.AppearanceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Appearance<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.AppearanceProperty, binding);


 // CornerPosition

/*ValueStyleSetterGenerator*/
public static Style<T> CornerPosition<T>(this Style<T> style, SukiUI.Enums.CornerPosition value) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.CornerPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerPosition<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.CornerPositionProperty, binding);


 // IsDot

/*ValueStyleSetterGenerator*/
public static Style<T> IsDot<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.IsDotProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDot<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.IsDotProperty, binding);


 // Overflow

/*ValueStyleSetterGenerator*/
public static Style<T> Overflow<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.OverflowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Overflow<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBadge 
=> style._addSetter(SukiUI.Controls.InfoBadge.OverflowProperty, binding);



}
