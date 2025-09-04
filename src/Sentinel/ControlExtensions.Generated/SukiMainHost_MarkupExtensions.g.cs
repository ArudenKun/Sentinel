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
public static partial class SukiMainHost_MarkupExtensions
{
//================= Properties ======================//
 // BackgroundAnimationEnabled

/*ValueSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundAnimationEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundAnimationEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty, ps, () => control.BackgroundAnimationEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundAnimationEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty, ps, () => control.BackgroundAnimationEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundStyle

/*ValueSetterGenerator*/
public static T BackgroundStyle<T>(this T control, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundStyle = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundStyle<T>(this T control, Func<SukiUI.Enums.SukiBackgroundStyle> func, Action<SukiUI.Enums.SukiBackgroundStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundStyle<T>(this T control,SukiUI.Enums.SukiBackgroundStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty, ps, () => control.BackgroundStyle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundStyle<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.SukiBackgroundStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty, ps, () => control.BackgroundStyle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundShaderFile

/*ValueSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, System.String value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundShaderFile = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundShaderFile<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty, ps, () => control.BackgroundShaderFile = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundShaderFile<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty, ps, () => control.BackgroundShaderFile = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundShaderCode

/*ValueSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, System.String value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundShaderCode = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundShaderCode<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty, ps, () => control.BackgroundShaderCode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundShaderCode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty, ps, () => control.BackgroundShaderCode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundTransitionsEnabled

/*ValueSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundTransitionsEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundTransitionsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty, ps, () => control.BackgroundTransitionsEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundTransitionsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty, ps, () => control.BackgroundTransitionsEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundTransitionTime

/*ValueSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundTransitionTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundTransitionTime<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty, ps, () => control.BackgroundTransitionTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundTransitionTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty, ps, () => control.BackgroundTransitionTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundForceSoftwareRendering

/*ValueSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.BackgroundForceSoftwareRendering = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundForceSoftwareRendering<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty, ps, () => control.BackgroundForceSoftwareRendering = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundForceSoftwareRendering<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty, ps, () => control.BackgroundForceSoftwareRendering = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Hosts

/*ValueSetterGenerator*/
public static T Hosts<T>(this T control, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiMainHost 
=> control._set(() => control.Hosts = value!);

/*BindFromExpressionSetterGenerator*/
public static T Hosts<T>(this T control, Func<Avalonia.Controls.Controls> func, Action<Avalonia.Controls.Controls>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.HostsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Hosts<T>(this T control,Avalonia.Controls.Controls value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.HostsProperty, ps, () => control.Hosts = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Hosts<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.HostsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Hosts<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMainHost 
   => control._set(SukiUI.Controls.SukiMainHost.HostsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Hosts<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Controls> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMainHost 
=> control._setEx(SukiUI.Controls.SukiMainHost.HostsProperty, ps, () => control.Hosts = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // BackgroundAnimationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundAnimationEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundAnimationEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundAnimationEnabledProperty, binding);


 // BackgroundStyle

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundStyle<T>(this Style<T> style, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundStyle<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundStyleProperty, binding);


 // BackgroundShaderFile

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundShaderFile<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundShaderFile<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundShaderFileProperty, binding);


 // BackgroundShaderCode

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundShaderCode<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundShaderCode<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundShaderCodeProperty, binding);


 // BackgroundTransitionsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundTransitionsEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundTransitionsEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundTransitionsEnabledProperty, binding);


 // BackgroundTransitionTime

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundTransitionTime<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundTransitionTime<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundTransitionTimeProperty, binding);


 // BackgroundForceSoftwareRendering

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundForceSoftwareRendering<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundForceSoftwareRendering<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.BackgroundForceSoftwareRenderingProperty, binding);


 // Hosts

/*ValueStyleSetterGenerator*/
public static Style<T> Hosts<T>(this Style<T> style, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.HostsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Hosts<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMainHost 
=> style._addSetter(SukiUI.Controls.SukiMainHost.HostsProperty, binding);



}
