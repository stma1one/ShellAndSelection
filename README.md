# DIExample - פרויקט הדגמה להזרקת תלות (Dependency Injection) ב-MAUI

פרויקט זה משמש כבסיס לימודי להדגמת מימוש ארכיטקטורת MVVM ושילוב של הזרקת תלות (Dependency Injection) באפליקציית .NET MAUI. הפרויקט כולל דוגמה מעשית לניהול ציוני שחקנים ותצוגתם.

## מבנה הפרויקט

הפרויקט מאורגן בצורה היררכית המפרידה בין הלוגיקה העסקית (Models), הלוגיקה של התצוגה (ViewModels) והתצוגה עצמה (Views).

### 1. תיקיית Models
מכילה את האובייקטים המייצגים את הנתונים ואת מחלקות הבסיס.
* **PlayerScore.cs**: מגדיר את מבנה הנתונים של שחקן (שם וציון).
* **ObservableObject.cs**: מחלקת בסיס המממשת את ממשק `INotifyPropertyChanged`, המאפשרת לממשק המשתמש להתעדכן אוטומטית בשינויי נתונים.

### 2. תיקיית ViewModels
מכילה את הלוגיקה המחברת בין ה-Model ל-View.
* **ViewModelBase.cs**: מחלקת בסיס לכל ה-ViewModels בפרויקט.
* **ScorePageViewModel.cs**: מנהל את רשימת הציונים, הוספת ציונים חדשים ועדכון התצוגה.

### 3. תיקיית Views
מכילה את הגדרות ממשק המשתמש (XAML) והקוד שמאחוריהן.
* **ScorePage.xaml / ScorePage.xaml.cs**: דף התצוגה הראשי המציג את רשימת הציונים ומאפשר אינטראקציה.

### 4. קובצי הגדרה וליבה
* **MauiProgram.cs**: נקודת הכניסה של האפליקציה שבה מתבצע הרישום של ה-Services, ה-ViewModels וה-Views לתוך ה-Dependency Injection Container.
* **App.xaml / AppShell.xaml**: הגדרות המשאבים הגלובליים ומבנה הניווט של האפליקציה.

## עקרונות מימוש מרכזיים

### הזרקת תלות (Dependency Injection)
הפרויקט מדגים כיצד לרשום שירותים ודפים בקובץ `MauiProgram.cs` באמצעות:
```csharp
builder.Services.AddTransient<ScorePage>();
builder.Services.AddTransient<ScorePageViewModel>();
