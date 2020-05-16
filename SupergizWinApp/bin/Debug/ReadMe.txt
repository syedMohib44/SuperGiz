=========================================================================
For C/C++, Delphi, Java... languages, you can take POSLink.dll as a COM.
=========================================================================
1. Install .Net Framework 4.0.
2. Register POSLink.dll(Assembly) with COM. You can use RegisterCOMx64_Net4.0.bat to register. 
   After you Register, you can not move the POSLink.dll to another folder. 
   If you want to move the position, you must register again.
3. Call COM interface in your project.
3.1 Some IDEs like C/C++ of Visual Studio, can import the TLB file to generate code. Then use call POSLink API.
3.2 Other IDEs can not use TLB. Call COM interface by name. You can get the name from API Guide.
4. If you want to remove POSLink.dll from your computer, unregister POSLink.dll first. You can use UnregisterCOMx64_Net4.0.bat to unregister.


===========================================================================
For C# program use .Net Framework. you can take POSLink.dll as an Assembly.
Note: POSLink.dll depends on msvcr100.dll and msvcp100.dll.
===========================================================================
1. Add reference to your C# project.
2. Copy dependence dlls to the folder where your application run.
2.1 For windows applications, you can copy the dependence dlls to debug/release folder with POSLink.dll
2.2 For Web applications like IIS, POSLink.dll will copy to a very special folder.
    You can not copy dependence dlls to that folder directly. You should install Microsoft Visual C++ 2010 Redistributable Package (x64) (recommended) or copy dependence dlls to system32 folder(not recommended) 
