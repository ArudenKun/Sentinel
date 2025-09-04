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
public static partial class SukiDesktopEnvironment_MarkupExtensions
{
//================= Properties ======================//
 // DesktopBackgroundImageSource

/*ValueSetterGenerator*/
public static T DesktopBackgroundImageSource<T>(this T control, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._set(() => control.DesktopBackgroundImageSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T DesktopBackgroundImageSource<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DesktopBackgroundImageSource<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty, ps, () => control.DesktopBackgroundImageSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DesktopBackgroundImageSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DesktopBackgroundImageSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DesktopBackgroundImageSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty, ps, () => control.DesktopBackgroundImageSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HomeImageSource

/*ValueSetterGenerator*/
public static T HomeImageSource<T>(this T control, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._set(() => control.HomeImageSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T HomeImageSource<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HomeImageSource<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty, ps, () => control.HomeImageSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HomeImageSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HomeImageSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HomeImageSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty, ps, () => control.HomeImageSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Softwares

/*ValueSetterGenerator*/
public static T Softwares<T>(this T control, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware> value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._set(() => control.Softwares = value!);

/*BindFromExpressionSetterGenerator*/
public static T Softwares<T>(this T control, Func<System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware>> func, Action<System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Softwares<T>(this T control,System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty, ps, () => control.Softwares = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Softwares<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Softwares<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
   => control._set(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Softwares<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> control._setEx(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty, ps, () => control.Softwares = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // DesktopBackgroundImageSource

/*ValueStyleSetterGenerator*/
public static Style<T> DesktopBackgroundImageSource<T>(this Style<T> style, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DesktopBackgroundImageSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.DesktopBackgroundImageSourceProperty, binding);


 // HomeImageSource

/*ValueStyleSetterGenerator*/
public static Style<T> HomeImageSource<T>(this Style<T> style, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HomeImageSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.HomeImageSourceProperty, binding);


 // Softwares

/*ValueStyleSetterGenerator*/
public static Style<T> Softwares<T>(this Style<T> style, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.DesktopEnvironment.SDESoftware> value) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Softwares<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment 
=> style._addSetter(SukiUI.Controls.Experimental.DesktopEnvironment.SukiDesktopEnvironment.SoftwaresProperty, binding);



}
