#
# spec file for package monodevelop
#
# Copyright (c) 2014 SUSE LINUX Products GmbH, Nuernberg, Germany.
#
# All modifications and additions to the file contributed by third parties
# remain the property of their copyright owners, unless otherwise agreed
# upon. The license for this file, and modifications and additions to the
# file, is the same license as for the pristine package itself (unless the
# license for the pristine package is not an Open Source License, in which
# case the license is the MIT License). An "Open Source License" is a
# license that conforms to the Open Source Definition (Version 1.9)
# published by the Open Source Initiative.

# Please submit bugfixes or comments via http://bugs.opensuse.org/
#


Name:           monodevelop
BuildRequires:  mono-devel >= 5.8
BuildRequires:  monodoc-core >= 5.8
BuildRequires:  mono-data
BuildRequires:  fsharp >= 4.1.25
BuildRequires:  mono-mvc
BuildRequires:  pkgconfig(glib-sharp-2.0) >= 2.12.20
BuildRequires:  pkgconfig(gtk-sharp-2.0) >= 2.12.20
BuildRequires:  pkgconfig(glade-sharp-2.0) >= 2.12.20
BuildRequires:  autoconf
BuildRequires:  automake
BuildRequires:  cmake
BuildRequires:  msbuild
BuildRequires:  libmonosgen-2_0-1
BuildRequires:  libmono-2_0-1
%if 0%{?rhel} <= 7
BuildRequires:  libssh2-devel
BuildRequires:  openssl-devel
%else
BuildRequires:	compat-openssl10
%endif
BuildRequires:  libcurl-devel
BuildRequires:  fdupes
BuildRequires:  git
BuildRequires:  hicolor-icon-theme
BuildRequires:  intltool
BuildRequires:  libtool
BuildRequires:  shared-mime-info
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
%else
BuildRequires:  update-desktop-files
%endif
BuildRequires:  pkgconfig(mono)
# mono-find-requires searches for libmono-2.0.so.1:
BuildRequires:  pkgconfig(mono-2)
BuildRequires:  pkgconfig(wcf)
# Mono.Cecil.dll requires rsync after it's build
BuildRequires:  rsync
Url:            http://www.monodevelop.com/
%define __majorver 7.8.2
%define __minorver 1
Version:	%{__majorver}.%{__minorver}
Release:	0.xamarin.3
Summary:        Full-Featured IDE for Mono and Gtk-Sharp
License:        LGPL-2.1 and MIT
Group:          Development/Tools/IDE
Source:         %{name}-%{version}.tar.bz2
Patch0:		no-ssh-please-were-british.patch
Patch1:		fixautoreconf.patch
BuildRoot:      %{_tmppath}/%{name}-%{version}-build
#BuildArch:      noarch
Requires:       mono-basic
Requires:       mono-web
Requires:       pkgconfig
Requires:       xsp
Requires:       mono-devel
Requires:       NUnit

%define _use_internal_dependency_generator 0
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
%define __find_provides env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/redhat/find-provides && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-provides ; } | sort | uniq'
%define __find_requires env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/redhat/find-requires && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-requires ; } | sort | uniq | grep -v \\(ARMClient.Authentication\\) | grep -v \\(Autofac\\) | grep -v \\(EnvDTE | grep -v \\(FSharp.Compiler.Service\\) | grep -v \\(ICSharpCode.SharpZipLib\\) | grep -v \\(Microsoft | grep -v \\(mscorlib\\) | grep -v \\(Newtonsoft.Json\\) | grep -v \\(PresentationCore\\) | grep -v \\(PresentationFramework\\) | grep -v \\(System\\) | grep -v \\(System.Collections.Immutable\\) | grep -v \\(System.Composition.AttributedModel\\) | grep -v \\(System.Core\\) | grep -v \\(System.Data.SqlServerCe\\) | grep -v \\(System.Diagnostics.StackTrace\\) | grep -v \\(System.DirectoryServices.AccountManagement\\) | grep -v \\(System.IdentityModel\\) | grep -v \\(System.IO.Compression\\) | grep -v \\(System.Management.Automation\\) | grep -v \\(System.Net | grep -v \\(System.Runtime.InteropServices.RuntimeInformation\\) | grep -v \\(System.Runtime.Loader\\) | grep -v \\(System.ServiceModel.Web\\) | grep -v \\(System.Text.Encoding.CodePages\\) | grep -v \\(System.Web.DataVisualization\\) | grep -v \\(System.Web.Http\\) | grep -v \\(System.Xml.Linq\\) | grep -v \\(System.Xml.XPath.XDocument\\) | grep -v \\(VsWebSite.Interop\\) | grep -v \\(System.ValueTuple\\) | grep -v \\(ICSharpCode.Decompiler\\) | grep -v \\(SQLitePCLRaw.batteries_v2\\) | grep -v \\(SQLitePCLRaw.core\\) | grep -v \\(System.IO.Pipes.AccessControl\\) | grep -v \\(System.Security.Cryptography.Algorithms\\) | grep -v \\(StreamJsonRpc\\) | grep -v 0\\.0\\.0\\.0'
%else
%define __find_provides env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/find-provides && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-provides ; } | sort | uniq'
%define __find_requires env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/find-requires && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-requires ; } | sort | uniq | grep -v \\(ARMClient.Authentication\\) | grep -v \\(Autofac\\) | grep -v \\(EnvDTE | grep -v \\(FSharp.Compiler.Service\\) | grep -v \\(ICSharpCode.SharpZipLib\\) | grep -v \\(Microsoft | grep -v \\(mscorlib\\) | grep -v \\(Newtonsoft.Json\\) | grep -v \\(PresentationCore\\) | grep -v \\(PresentationFramework\\) | grep -v \\(System\\) | grep -v \\(System.Collections.Immutable\\) | grep -v \\(System.Composition.AttributedModel\\) | grep -v \\(System.Core\\) | grep -v \\(System.Data.SqlServerCe\\) | grep -v \\(System.Diagnostics.StackTrace\\) | grep -v \\(System.DirectoryServices.AccountManagement\\) | grep -v \\(System.IdentityModel\\) | grep -v \\(System.IO.Compression\\) | grep -v \\(System.Management.Automation\\) | grep -v \\(System.Net | grep -v \\(System.Runtime.InteropServices.RuntimeInformation\\) | grep -v \\(System.Runtime.Loader\\) | grep -v \\(System.ServiceModel.Web\\) | grep -v \\(System.Text.Encoding.CodePages\\) | grep -v \\(System.Web.DataVisualization\\) | grep -v \\(System.Web.Http\\) | grep -v \\(System.Xml.Linq\\) | grep -v \\(System.Xml.XPath.XDocument\\) | grep -v \\(VsWebSite.Interop\\) | grep -v \\(System.ValueTuple\\) | grep -v \\(ICSharpCode.Decompiler\\) | grep -v \\(SQLitePCLRaw.batteries_v2\\) | grep -v \\(SQLitePCLRaw.core\\) | grep -v \\(System.IO.Pipes.AccessControl\\) | grep -v \\(System.Security.Cryptography.Algorithms\\) | grep -v \\(StreamJsonRpc\\) | grep -v 0\\.0\\.0\\.0'
%endif

%description
MonoDevelop is a full-featured integrated development
environment (IDE) for Mono and Gtk-Sharp primarily designed
for C-Sharp and other .NET languages. It allows to quickly
create desktop and ASP.NET Web applications. Support
for Visual Studio file formats eases porting to Linux.

%package devel
Summary:        Development files for MonoDevelop
Group:          Development/Languages/Mono
Requires:       monodevelop = %{version}

%description devel
MonoDevelop is a full-featured integrated development
environment (IDE) for Mono and Gtk-Sharp. It was originally
a port of SharpDevelop 0.98.

This package contains development files for the IDE and plugins.

%prep
%setup -q -n monodevelop-7.8
%patch1 -p1
%if 0%{?rhel} >= 8
%patch0 -p1
%endif

%build
%{?env_options}

%if 0%{?rhel} >= 8
autoreconf -vi
%endif
%configure --libdir=%{_prefix}/lib --disable-update-mimedb
make

%install
%{?env_options}
make install DESTDIR=%{buildroot} GACUTIL_FLAGS="/package monodevelop /root %{buildroot}%{_prefix}/lib"
#
mkdir -p %{buildroot}%{_prefix}/share/pkgconfig
mv %{buildroot}%{_prefix}/lib/pkgconfig/* %{buildroot}%{_datadir}/pkgconfig
%find_lang %{name}
%if 0%{?suse_version} > 1220
%fdupes %buildroot/%{_prefix}
%endif
%ifarch %{ix86}
cp packages/SQLitePCLRaw.lib.e_sqlite3.linux.*/runtimes/linux-x86/native/libe_sqlite3.so %{buildroot}%{_prefix}/lib/monodevelop/bin/
%endif

%post
%if 0%{?rhel}%{?fedora}%{?centos}
  /bin/touch --no-create %{_datadir}/icons/hicolor &>/dev/null || :
  %{_bindir}/update-desktop-database &> /dev/null || :
%else
  %if 0%{?suse_version}
    %desktop_database_post
    %icon_theme_cache_post
    %mime_database_post
  %endif
%endif

%postun
%if 0%{?rhel}%{?fedora}%{?centos}
  %{_bindir}/update-desktop-database &> /dev/null || :
  if [ $1 -eq 0 ] ; then
    /bin/touch --no-create %{_datadir}/icons/hicolor &>/dev/null
    %{_bindir}/gtk-update-icon-cache %{_datadir}/icons/hicolor &>/dev/null || :
  fi
%else
  %if 0%{?suse_version}
    %desktop_database_postun
    %icon_theme_cache_postun
    %mime_database_postun
  %endif
%endif

%files -f %{name}.lang
%defattr(-,root,root)
%{_bindir}/*
%defattr(0644,root,root,0755)
%{_datadir}/applications/monodevelop.desktop
%{_datadir}/icons/hicolor/*/apps/monodevelop.png
%{_datadir}/icons/hicolor/scalable/apps/monodevelop.svg
%{_prefix}/lib/monodevelop
%{_mandir}/man1/mdtool.1.gz
%{_mandir}/man1/monodevelop.1.gz
%{_datadir}/mime/packages/monodevelop.xml
%{_datadir}/appdata/monodevelop.appdata.xml

%files devel
%defattr(-,root,root)
%{_datadir}/pkgconfig/*.pc

%changelog

