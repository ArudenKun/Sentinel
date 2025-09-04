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
public static partial class SukiMessageBoxHost_MarkupExtensions
{
//================= Properties ======================//
 // UseAlternativeHeaderStyle

/*ValueSetterGenerator*/
public static T UseAlternativeHeaderStyle<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.UseAlternativeHeaderStyle = value!);

/*BindFromExpressionSetterGenerator*/
public static T UseAlternativeHeaderStyle<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UseAlternativeHeaderStyle<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty, ps, () => control.UseAlternativeHeaderStyle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseAlternativeHeaderStyle<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseAlternativeHeaderStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UseAlternativeHeaderStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty, ps, () => control.UseAlternativeHeaderStyle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconPreset

/*ValueSetterGenerator*/
public static T IconPreset<T>(this T control, System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.IconPreset = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconPreset<T>(this T control, Func<System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons>> func, Action<System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconPreset<T>(this T control,System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty, ps, () => control.IconPreset = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconPreset<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconPreset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconPreset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty, ps, () => control.IconPreset = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconPresetSize

/*ValueSetterGenerator*/
public static T IconPresetSize<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.IconPresetSize = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconPresetSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconPresetSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty, ps, () => control.IconPresetSize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconPresetSize<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconPresetSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconPresetSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty, ps, () => control.IconPresetSize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowHeaderContentSeparator

/*ValueSetterGenerator*/
public static T ShowHeaderContentSeparator<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.ShowHeaderContentSeparator = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowHeaderContentSeparator<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowHeaderContentSeparator<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty, ps, () => control.ShowHeaderContentSeparator = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowHeaderContentSeparator<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowHeaderContentSeparator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowHeaderContentSeparator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty, ps, () => control.ShowHeaderContentSeparator = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FooterLeftItemsSource

/*ValueSetterGenerator*/
public static T FooterLeftItemsSource<T>(this T control, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.FooterLeftItemsSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T FooterLeftItemsSource<T>(this T control, Func<Avalonia.Controls.Controls> func, Action<Avalonia.Controls.Controls>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FooterLeftItemsSource<T>(this T control,Avalonia.Controls.Controls value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty, ps, () => control.FooterLeftItemsSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FooterLeftItemsSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FooterLeftItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FooterLeftItemsSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Controls> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty, ps, () => control.FooterLeftItemsSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActionButtonsSource

/*ValueSetterGenerator*/
public static T ActionButtonsSource<T>(this T control, Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.ActionButtonsSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActionButtonsSource<T>(this T control, Func<Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button>> func, Action<Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActionButtonsSource<T>(this T control,Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty, ps, () => control.ActionButtonsSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActionButtonsSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActionButtonsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActionButtonsSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty, ps, () => control.ActionButtonsSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActionButtonsPreset

/*ValueSetterGenerator*/
public static T ActionButtonsPreset<T>(this T control, System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.ActionButtonsPreset = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActionButtonsPreset<T>(this T control, Func<System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons>> func, Action<System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActionButtonsPreset<T>(this T control,System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty, ps, () => control.ActionButtonsPreset = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActionButtonsPreset<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActionButtonsPreset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActionButtonsPreset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty, ps, () => control.ActionButtonsPreset = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemsSpacing

/*ValueSetterGenerator*/
public static T ItemsSpacing<T>(this T control, System.Int32 value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._set(() => control.ItemsSpacing = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemsSpacing<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemsSpacing<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty, ps, () => control.ItemsSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsSpacing<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiMessageBoxHost 
   => control._set(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemsSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiMessageBoxHost 
=> control._setEx(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty, ps, () => control.ItemsSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // UseAlternativeHeaderStyle

/*ValueStyleSetterGenerator*/
public static Style<T> UseAlternativeHeaderStyle<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseAlternativeHeaderStyle<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.UseAlternativeHeaderStyleProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconProperty, binding);


 // IconPreset

/*ValueStyleSetterGenerator*/
public static Style<T> IconPreset<T>(this Style<T> style, System.Nullable<SukiUI.MessageBox.SukiMessageBoxIcons> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconPreset<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconPresetProperty, binding);


 // IconPresetSize

/*ValueStyleSetterGenerator*/
public static Style<T> IconPresetSize<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconPresetSize<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.IconPresetSizeProperty, binding);


 // ShowHeaderContentSeparator

/*ValueStyleSetterGenerator*/
public static Style<T> ShowHeaderContentSeparator<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowHeaderContentSeparator<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ShowHeaderContentSeparatorProperty, binding);


 // FooterLeftItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> FooterLeftItemsSource<T>(this Style<T> style, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FooterLeftItemsSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.FooterLeftItemsSourceProperty, binding);


 // ActionButtonsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ActionButtonsSource<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<Avalonia.Controls.Button> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ActionButtonsSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsSourceProperty, binding);


 // ActionButtonsPreset

/*ValueStyleSetterGenerator*/
public static Style<T> ActionButtonsPreset<T>(this Style<T> style, System.Nullable<SukiUI.MessageBox.SukiMessageBoxButtons> value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ActionButtonsPreset<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ActionButtonsPresetProperty, binding);


 // ItemsSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSpacing<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSpacing<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiMessageBoxHost 
=> style._addSetter(SukiUI.Controls.SukiMessageBoxHost.ItemsSpacingProperty, binding);



}
