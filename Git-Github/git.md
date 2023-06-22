# Git & Github 

You can access to my presentation file from this <a href="https://github.com/yasaminashoori/Good-Stuffs/blob/master/Git-Github/Intro-to-Git.pdf">link</a>

# درمورد  version control 

"کنترل نسخه" چیست و چرا باید به آن اهمیت دهید؟ نسخه کنترل سیستمی است که به مرور زمان یک فایل یا مجموعه ای از فایل هایی که تغییر می کنند را ردیابی می‌کند
    تا بتوانید نسخه های خاصی را که به آن نیاز دارید بعداً فراخوانی کنید. 
    
به عنوان مثال در این کتاب، شما از کد منبع نرم افزار به عنوان فایل های تحت کنترل نسخه استفاده خواهید کرد، اگرچه شما می توانید این کار را با تقریباً هر نوع فایلی در رایانه انجام دهید. 
اگر یک طراح گرافیک یا وب هستید و می خواهید هر نسخه از یک تصویر یا layout را نگه دارید (که مطمئناً می خواهید)، یک سیستم کنترل نسخه (VCS) یک چیز بسیار عاقلانه برای استفاده است. 

این به شما اجازه می دهد فایل های انتخاب شده را به حالت قبلی برگردانید، کل پروژه را به حالت قبلی برگردانید، تغییرات را در طول زمان مقایسه کنید،
ببینید چه کسی آخرین بار چیزی را که ممکن است باعث تغییر شده باشد، تغییر داده است، چه کسی و چه زمانی یک issue  را معرفی کرده است و موارد دیگر. 

استفاده از VCS همچنین به طور کلی به این معنی است که اگر چیزها را خراب کنید یا فایل ها را گم کنید، به راحتی می توانید آن را بازیابی کنید. علاوه بر این، شما همه اینها را برای هزینه ای بسیار کم دریافت می کنید.
در ادامه با انوع VCS آشنا خواهیم شد..

# Local Version Control Systems

روش انتخابی بسیاری از افراد برای کنترل نسخه، کپی کردن فایل ها در پوشه دیگری است. این رویکرد بسیار رایج است زیرا بسیار ساده است،
اما همچنین به طور باور نکردنی ای مستعد خطا است. 

به راحتی می توان فراموش کرد که در کدام دایرکتوری هستید و به طور تصادفی به فایل اشتباهی بنویسید یا روی فایل هایی که قصد ندارید کپی کنید.
برای مقابله با این موضوع، برنامه نویسان مدت ها پیش VCS 
های محلی را توسعه دادند که یک پایگاه داده ساده داشت که تمام تغییرات فایل ها را تحت کنترل بازبینی نگه می‌داشت

یکی از محبوب‌ترین ابزارهای VCS، سیستمی به نام RCS بود که هنوز در بین بسیاری توزیع می‌شود.
کامپیوترهای امروزی RCS با نگه داشتن مجموعه های پچ (یعنی تفاوت بین فایل ها)  روی فرمت ویژه ای روی دیسک کار می‌کند؛
سپس می‌تواند با جمع کردن همه فایل‌ها را در هر نقطه از زمان دوباره تکه ها را ایجاد کند.

# What is Git and why do we need it?

# About Version Control
What is “version control”, and why should you care? Version control is a system that records
changes to a file or set of files over time so that you can recall specific versions later. For the
examples in this book, you will use software source code as the files being version controlled,
though in reality you can do this with nearly any type of file on a computer.
If you are a graphic or web designer and want to keep every version of an image or layout (which
you would most certainly want to), a Version Control System (VCS) is a very wise thing to use. It
allows you to revert selected files back to a previous state, revert the entire project back to a
previous state, compare changes over time, see who last modified something that might be causing
a problem, who introduced an issue and when, and more. Using a VCS also generally means that if
you screw things up or lose files, you can easily recover. In addition, you get all this for very little
overhead.

So! now you can answer to this question that what did we do before knowing anything about git ? 

<img src="images\girl.PNG">

Yes! the answer is Copy or as it known as Local Version Control Systems.

Many people’s version-control method of choice is to copy files into another directory (perhaps a
time-stamped directory, if they’re clever). This approach is very common because it is so simple, but
it is also incredibly error prone. It is easy to forget which directory you’re in and accidentally write
to the wrong file or copy over files you don’t mean to.
To deal with this issue, programmers long ago developed local VCSs that had a simple database that
kept all the changes to files under revision control.



