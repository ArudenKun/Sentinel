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
public static partial class SukiBackground_MarkupExtensions
{
//================= Properties ======================//
 // Style

/*ValueSetterGenerator*/
public static T Style<T>(this T control, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.Style = value!);

/*BindFromExpressionSetterGenerator*/
public static T Style<T>(this T control, Func<SukiUI.Enums.SukiBackgroundStyle> func, Action<SukiUI.Enums.SukiBackgroundStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.StyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Style<T>(this T control,SukiUI.Enums.SukiBackgroundStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.StyleProperty, ps, () => control.Style = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Style<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.StyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Style<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.StyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Style<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.SukiBackgroundStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.StyleProperty, ps, () => control.Style = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShaderFile

/*ValueSetterGenerator*/
public static T ShaderFile<T>(this T control, System.String value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.ShaderFile = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShaderFile<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderFileProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShaderFile<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ShaderFileProperty, ps, () => control.ShaderFile = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShaderFile<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderFileProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShaderFile<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderFileProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShaderFile<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ShaderFileProperty, ps, () => control.ShaderFile = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShaderCode

/*ValueSetterGenerator*/
public static T ShaderCode<T>(this T control, System.String value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.ShaderCode = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShaderCode<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderCodeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShaderCode<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ShaderCodeProperty, ps, () => control.ShaderCode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShaderCode<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderCodeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShaderCode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ShaderCodeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShaderCode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ShaderCodeProperty, ps, () => control.ShaderCode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AnimationEnabled

/*ValueSetterGenerator*/
public static T AnimationEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.AnimationEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T AnimationEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.AnimationEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AnimationEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.AnimationEnabledProperty, ps, () => control.AnimationEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AnimationEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.AnimationEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AnimationEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.AnimationEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AnimationEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.AnimationEnabledProperty, ps, () => control.AnimationEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TransitionsEnabled

/*ValueSetterGenerator*/
public static T TransitionsEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.TransitionsEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T TransitionsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TransitionsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty, ps, () => control.TransitionsEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransitionsEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransitionsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TransitionsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty, ps, () => control.TransitionsEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TransitionTime

/*ValueSetterGenerator*/
public static T TransitionTime<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.TransitionTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T TransitionTime<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TransitionTime<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.TransitionTimeProperty, ps, () => control.TransitionTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransitionTime<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransitionTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.TransitionTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TransitionTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.TransitionTimeProperty, ps, () => control.TransitionTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ForceSoftwareRendering

/*ValueSetterGenerator*/
public static T ForceSoftwareRendering<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> control._set(() => control.ForceSoftwareRendering = value!);

/*BindFromExpressionSetterGenerator*/
public static T ForceSoftwareRendering<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ForceSoftwareRendering<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty, ps, () => control.ForceSoftwareRendering = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ForceSoftwareRendering<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ForceSoftwareRendering<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiBackground 
   => control._set(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ForceSoftwareRendering<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiBackground 
=> control._setEx(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty, ps, () => control.ForceSoftwareRendering = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Style

/*ValueStyleSetterGenerator*/
public static Style<T> Style<T>(this Style<T> style, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.StyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Style<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.StyleProperty, binding);


 // ShaderFile

/*ValueStyleSetterGenerator*/
public static Style<T> ShaderFile<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ShaderFileProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShaderFile<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ShaderFileProperty, binding);


 // ShaderCode

/*ValueStyleSetterGenerator*/
public static Style<T> ShaderCode<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ShaderCodeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShaderCode<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ShaderCodeProperty, binding);


 // AnimationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> AnimationEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.AnimationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AnimationEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.AnimationEnabledProperty, binding);


 // TransitionsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> TransitionsEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransitionsEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.TransitionsEnabledProperty, binding);


 // TransitionTime

/*ValueStyleSetterGenerator*/
public static Style<T> TransitionTime<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.TransitionTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransitionTime<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.TransitionTimeProperty, binding);


 // ForceSoftwareRendering

/*ValueStyleSetterGenerator*/
public static Style<T> ForceSoftwareRendering<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ForceSoftwareRendering<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiBackground 
=> style._addSetter(SukiUI.Controls.SukiBackground.ForceSoftwareRenderingProperty, binding);



}
