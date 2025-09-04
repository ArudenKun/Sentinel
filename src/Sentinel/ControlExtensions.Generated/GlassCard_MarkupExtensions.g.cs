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
public static partial class GlassCard_MarkupExtensions
{
//================= Properties ======================//
 // CornerRadius

/*ValueSetterGenerator*/
// public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : SukiUI.Controls.GlassCard 
// => control._set(() => control.CornerRadius = value!);
//
// /*BindFromExpressionSetterGenerator*/
// public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
//    => control._set(SukiUI.Controls.GlassCard.CornerRadiusProperty!, func, onChanged, expression);
//
// /*ValueOverloadsSetterGenerator*/
//
// public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
// public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
// public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
//
// /*MagicalSetterGenerator*/
// [Obsolete]
// public static T CornerRadius<T>(this T control,Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
// => control._setEx(SukiUI.Controls.GlassCard.CornerRadiusProperty, ps, () => control.CornerRadius = value!, bindingMode, converter, bindingSource);
//
// /*BindSetterGenerator*/
// public static T CornerRadius<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
//    => control._set(SukiUI.Controls.GlassCard.CornerRadiusProperty, binding);
//
// /*AvaloniaPropertyBindSetterGenerator*/
// public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
//    => control._set(SukiUI.Controls.GlassCard.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
//
// /*MagicalSetterWithConverterGenerator*/
// [Obsolete]
// public static T CornerRadius<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
// => control._setEx(SukiUI.Controls.GlassCard.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.BorderThickness = value!);

/*BindFromExpressionSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.BorderThicknessProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

// public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
// public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
// public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : SukiUI.Controls.GlassCard 
//    => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));
//
// /*MagicalSetterGenerator*/
// [Obsolete]
// public static T BorderThickness<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
// => control._setEx(SukiUI.Controls.GlassCard.BorderThicknessProperty, ps, () => control.BorderThickness = value!, bindingMode, converter, bindingSource);
//
// /*BindSetterGenerator*/
// public static T BorderThickness<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
//    => control._set(SukiUI.Controls.GlassCard.BorderThicknessProperty, binding);
//
// /*AvaloniaPropertyBindSetterGenerator*/
// public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
//    => control._set(SukiUI.Controls.GlassCard.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
//
// /*MagicalSetterWithConverterGenerator*/
// [Obsolete]
// public static T BorderThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
// => control._setEx(SukiUI.Controls.GlassCard.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAnimated

/*ValueSetterGenerator*/
public static T IsAnimated<T>(this T control, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.IsAnimated = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAnimated<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsAnimatedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAnimated<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsAnimatedProperty, ps, () => control.IsAnimated = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAnimated<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsAnimatedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAnimated<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsAnimatedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAnimated<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsAnimatedProperty, ps, () => control.IsAnimated = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsOpaque

/*ValueSetterGenerator*/
public static T IsOpaque<T>(this T control, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.IsOpaque = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsOpaque<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsOpaqueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsOpaque<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsOpaqueProperty, ps, () => control.IsOpaque = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpaque<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsOpaqueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpaque<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsOpaqueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsOpaque<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsOpaqueProperty, ps, () => control.IsOpaque = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsInteractive

/*ValueSetterGenerator*/
public static T IsInteractive<T>(this T control, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.IsInteractive = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsInteractive<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsInteractiveProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsInteractive<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsInteractiveProperty, ps, () => control.IsInteractive = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsInteractive<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsInteractiveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsInteractive<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.IsInteractiveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsInteractive<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.IsInteractiveProperty, ps, () => control.IsInteractive = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.Command = value!);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.CommandProperty, ps, () => control.Command = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.CommandProperty, ps, () => control.Command = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : SukiUI.Controls.GlassCard 
=> control._set(() => control.CommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.CommandParameterProperty, ps, () => control.CommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.GlassCard 
   => control._set(SukiUI.Controls.GlassCard.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.GlassCard 
=> control._setEx(SukiUI.Controls.GlassCard.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : SukiUI.Controls.GlassCard 
   => style._addSetter(SukiUI.Controls.GlassCard.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // IsAnimated

/*ValueStyleSetterGenerator*/
public static Style<T> IsAnimated<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsAnimatedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAnimated<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsAnimatedProperty, binding);


 // IsOpaque

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpaque<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsOpaqueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpaque<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsOpaqueProperty, binding);


 // IsInteractive

/*ValueStyleSetterGenerator*/
public static Style<T> IsInteractive<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsInteractiveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInteractive<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.IsInteractiveProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.GlassCard 
=> style._addSetter(SukiUI.Controls.GlassCard.CommandParameterProperty, binding);



}
