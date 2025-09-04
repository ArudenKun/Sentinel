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
public static partial class ChatUI_MarkupExtensions
{
//================= Properties ======================//
 // Messages

/*ValueSetterGenerator*/
public static T Messages<T>(this T control, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage> value) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._set(() => control.Messages = value!);

/*BindFromExpressionSetterGenerator*/
public static T Messages<T>(this T control, Func<System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage>> func, Action<System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.MessagesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Messages<T>(this T control,System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.MessagesProperty, ps, () => control.Messages = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Messages<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.MessagesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Messages<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.MessagesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Messages<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.MessagesProperty, ps, () => control.Messages = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._set(() => control.Text = value!);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.TextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.TextProperty, ps, () => control.Text = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.TextProperty, ps, () => control.Text = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UserImageSource

/*ValueSetterGenerator*/
public static T UserImageSource<T>(this T control, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._set(() => control.UserImageSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T UserImageSource<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UserImageSource<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty, ps, () => control.UserImageSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UserImageSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UserImageSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UserImageSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty, ps, () => control.UserImageSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FriendImageSource

/*ValueSetterGenerator*/
public static T FriendImageSource<T>(this T control, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._set(() => control.FriendImageSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T FriendImageSource<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FriendImageSource<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty, ps, () => control.FriendImageSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FriendImageSource<T>(this T control, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FriendImageSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Experimental.ChatUI 
   => control._set(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FriendImageSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Experimental.ChatUI 
=> control._setEx(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty, ps, () => control.FriendImageSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Messages

/*ValueStyleSetterGenerator*/
public static Style<T> Messages<T>(this Style<T> style, System.Collections.ObjectModel.ObservableCollection<SukiUI.Controls.Experimental.ChatMessage> value) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.MessagesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Messages<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.MessagesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.TextProperty, binding);


 // UserImageSource

/*ValueStyleSetterGenerator*/
public static Style<T> UserImageSource<T>(this Style<T> style, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UserImageSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.UserImageSourceProperty, binding);


 // FriendImageSource

/*ValueStyleSetterGenerator*/
public static Style<T> FriendImageSource<T>(this Style<T> style, Avalonia.Media.IImage value) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FriendImageSource<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Experimental.ChatUI 
=> style._addSetter(SukiUI.Controls.Experimental.ChatUI.FriendImageSourceProperty, binding);



}
