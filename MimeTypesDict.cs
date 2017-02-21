using System.Collections.Generic;

namespace MimeMapping
{
    public static partial class MimeTypes
    {
        // Dupe for wmz: using application/x-ms-wmz vs application/x-msmetafile 
        // Dupe for sub: using image/vnd.dvb.subtitle vs text/vnd.dvb.subtitle 
        // Dupe for rdf: using application/rdf+xml vs application/xml 
        // Dupe for aac: using audio/x-aac vs audio/mp4 
        // Dupe for ra: using audio/x-pn-realaudio vs audio/x-realaudio 
        // Dupe for f4v: using video/x-f4v vs video/mp4 
        // Dupe for m4v: using video/x-m4v vs video/mp4 
        // Dupe for otf: using application/x-font-otf vs font/opentype 
        // Dupe for deb: using application/x-debian-package vs application/octet-stream 
        // Dupe for dll: using application/x-msdownload vs application/octet-stream 
        // Dupe for dmg: using application/x-apple-diskimage vs application/octet-stream 
        // Dupe for exe: using application/x-msdownload vs application/octet-stream 
        // Dupe for iso: using application/x-iso9660-image vs application/octet-stream 
        // Dupe for msi: using application/x-msdownload vs application/octet-stream 
        // Dupe for pdb: using application/vnd.palm vs application/x-pilot 
        // Dupe for prc: using application/x-mobipocket-ebook vs application/x-pilot 
        // Dupe for xsl: using application/xml vs application/xslt+xml 
        // Dupe for vcf: using text/x-vcard vs text/vcard 


        // Generated 1019 type definitions



        // List of all available extensions, used to build the dictionary
        static readonly string[] ALL_EXTS = {
            "ez",
            "aw",
            "atom",
            "atomcat",
            "atomsvc",
            "ccxml",
            "cdmia",
            "cdmic",
            "cdmid",
            "cdmio",
            "cdmiq",
            "cu",
            "davmount",
            "dbk",
            "dssc",
            "xdssc",
            "ecma",
            "emma",
            "epub",
            "exi",
            "pfr",
            "woff",
            "gml",
            "gpx",
            "gxf",
            "stk",
            "ink",
            "inkml",
            "ipfix",
            "jar",
            "ser",
            "class",
            "js",
            "json",
            "jsonml",
            "lostxml",
            "hqx",
            "cpt",
            "mads",
            "mrc",
            "mrcx",
            "ma",
            "nb",
            "mb",
            "mathml",
            "mbox",
            "mscml",
            "metalink",
            "meta4",
            "mets",
            "mods",
            "m21",
            "mp21",
            "mp4s",
            "doc",
            "dot",
            "mxf",
            "bin",
            "dms",
            "lrf",
            "mar",
            "so",
            "dist",
            "distz",
            "pkg",
            "bpk",
            "dump",
            "elc",
            "deploy",
            "oda",
            "opf",
            "ogx",
            "omdoc",
            "onetoc",
            "onetoc2",
            "onetmp",
            "onepkg",
            "oxps",
            "xer",
            "pdf",
            "pgp",
            "asc",
            "sig",
            "prf",
            "p10",
            "p7m",
            "p7c",
            "p7s",
            "p8",
            "ac",
            "cer",
            "crl",
            "pkipath",
            "pki",
            "pls",
            "ai",
            "eps",
            "ps",
            "cww",
            "pskcxml",
            "rdf",
            "rif",
            "rnc",
            "rl",
            "rld",
            "rs",
            "gbr",
            "mft",
            "roa",
            "rsd",
            "rss",
            "rtf",
            "sbml",
            "scq",
            "scs",
            "spq",
            "spp",
            "sdp",
            "setpay",
            "setreg",
            "shf",
            "smi",
            "smil",
            "rq",
            "srx",
            "gram",
            "grxml",
            "sru",
            "ssdl",
            "ssml",
            "tei",
            "teicorpus",
            "tfi",
            "tsd",
            "plb",
            "psb",
            "pvb",
            "tcap",
            "pwn",
            "aso",
            "imp",
            "acu",
            "atc",
            "acutc",
            "air",
            "fcdt",
            "fxp",
            "fxpl",
            "xdp",
            "xfdf",
            "ahead",
            "azf",
            "azs",
            "azw",
            "acc",
            "ami",
            "apk",
            "cii",
            "fti",
            "atx",
            "mpkg",
            "m3u8",
            "swi",
            "iota",
            "aep",
            "mpm",
            "bmi",
            "rep",
            "cdxml",
            "mmd",
            "cdy",
            "cla",
            "rp9",
            "c4g",
            "c4d",
            "c4f",
            "c4p",
            "c4u",
            "c11amc",
            "c11amz",
            "csp",
            "cdbcmsg",
            "cmc",
            "clkx",
            "clkk",
            "clkp",
            "clkt",
            "clkw",
            "wbs",
            "pml",
            "ppd",
            "car",
            "pcurl",
            "dart",
            "rdz",
            "uvf",
            "uvvf",
            "uvd",
            "uvvd",
            "uvt",
            "uvvt",
            "uvx",
            "uvvx",
            "uvz",
            "uvvz",
            "fe_launch",
            "dna",
            "mlp",
            "dpg",
            "dfac",
            "kpxx",
            "ait",
            "svc",
            "geo",
            "mag",
            "nml",
            "esf",
            "msf",
            "qam",
            "slt",
            "ssf",
            "es3",
            "et3",
            "ez2",
            "ez3",
            "fdf",
            "mseed",
            "seed",
            "dataless",
            "gph",
            "ftc",
            "fm",
            "frame",
            "maker",
            "book",
            "fnc",
            "ltf",
            "fsc",
            "oas",
            "oa2",
            "oa3",
            "fg5",
            "bh2",
            "ddd",
            "xdw",
            "xbd",
            "fzs",
            "txd",
            "ggb",
            "ggt",
            "gex",
            "gre",
            "gxt",
            "g2w",
            "g3w",
            "gmx",
            "kml",
            "kmz",
            "gqf",
            "gqs",
            "gac",
            "ghf",
            "gim",
            "grv",
            "gtm",
            "tpl",
            "vcg",
            "hal",
            "zmm",
            "hbci",
            "les",
            "hpgl",
            "hpid",
            "hps",
            "jlt",
            "pcl",
            "pclxl",
            "sfd-hdstx",
            "mpy",
            "afp",
            "listafp",
            "list3820",
            "irm",
            "sc",
            "icc",
            "icm",
            "igl",
            "ivp",
            "ivu",
            "igm",
            "xpw",
            "xpx",
            "i2g",
            "qbo",
            "qfx",
            "rcprofile",
            "irp",
            "xpr",
            "fcs",
            "jam",
            "rms",
            "jisp",
            "joda",
            "ktz",
            "ktr",
            "karbon",
            "chrt",
            "kfo",
            "flw",
            "kon",
            "kpr",
            "kpt",
            "ksp",
            "kwd",
            "kwt",
            "htke",
            "kia",
            "kne",
            "knp",
            "skp",
            "skd",
            "skt",
            "skm",
            "sse",
            "lasxml",
            "lbd",
            "lbe",
            "123",
            "apr",
            "pre",
            "nsf",
            "org",
            "scm",
            "lwp",
            "portpkg",
            "mcd",
            "mc1",
            "cdkey",
            "mwf",
            "mfm",
            "flo",
            "igx",
            "mif",
            "daf",
            "dis",
            "mbk",
            "mqy",
            "msl",
            "plc",
            "txf",
            "mpn",
            "mpc",
            "xul",
            "cil",
            "cab",
            "xls",
            "xlm",
            "xla",
            "xlc",
            "xlt",
            "xlw",
            "xlam",
            "xlsb",
            "xlsm",
            "xltm",
            "eot",
            "chm",
            "ims",
            "lrm",
            "thmx",
            "cat",
            "stl",
            "ppt",
            "pps",
            "pot",
            "ppam",
            "pptm",
            "sldm",
            "ppsm",
            "potm",
            "mpp",
            "mpt",
            "docm",
            "dotm",
            "wps",
            "wks",
            "wcm",
            "wdb",
            "wpl",
            "xps",
            "mseq",
            "mus",
            "msty",
            "taglet",
            "nlu",
            "ntf",
            "nitf",
            "nnd",
            "nns",
            "nnw",
            "ngdat",
            "n-gage",
            "rpst",
            "rpss",
            "edm",
            "edx",
            "ext",
            "odc",
            "otc",
            "odb",
            "odf",
            "odft",
            "odg",
            "otg",
            "odi",
            "oti",
            "odp",
            "otp",
            "ods",
            "ots",
            "odt",
            "odm",
            "ott",
            "oth",
            "xo",
            "dd2",
            "oxt",
            "pptx",
            "sldx",
            "ppsx",
            "potx",
            "xlsx",
            "xltx",
            "docx",
            "dotx",
            "mgp",
            "dp",
            "esa",
            "pdb",
            "pqa",
            "oprc",
            "paw",
            "str",
            "ei6",
            "efif",
            "wg",
            "plf",
            "pbd",
            "box",
            "mgz",
            "qps",
            "ptid",
            "qxd",
            "qxt",
            "qwd",
            "qwt",
            "qxl",
            "qxb",
            "bed",
            "mxl",
            "musicxml",
            "cryptonote",
            "cod",
            "rm",
            "rmvb",
            "link66",
            "st",
            "see",
            "sema",
            "semd",
            "semf",
            "ifm",
            "itp",
            "iif",
            "ipk",
            "twd",
            "twds",
            "mmf",
            "teacher",
            "sdkm",
            "sdkd",
            "dxp",
            "sfs",
            "sdc",
            "sda",
            "sdd",
            "smf",
            "sdw",
            "vor",
            "sgl",
            "smzip",
            "sm",
            "sxc",
            "stc",
            "sxd",
            "std",
            "sxi",
            "sti",
            "sxm",
            "sxw",
            "sxg",
            "stw",
            "sus",
            "susp",
            "svd",
            "sis",
            "sisx",
            "xsm",
            "bdm",
            "xdm",
            "tao",
            "pcap",
            "cap",
            "dmp",
            "tmo",
            "tpt",
            "mxs",
            "tra",
            "ufd",
            "ufdl",
            "utz",
            "umj",
            "unityweb",
            "uoml",
            "vcx",
            "vsd",
            "vst",
            "vss",
            "vsw",
            "vis",
            "vsf",
            "wbxml",
            "wmlc",
            "wmlsc",
            "wtb",
            "nbp",
            "wpd",
            "wqd",
            "stf",
            "xar",
            "xfdl",
            "hvd",
            "hvs",
            "hvp",
            "osf",
            "osfpvg",
            "saf",
            "spf",
            "cmp",
            "zir",
            "zirz",
            "zaz",
            "vxml",
            "wgt",
            "hlp",
            "wsdl",
            "wspolicy",
            "7z",
            "abw",
            "ace",
            "dmg",
            "aab",
            "x32",
            "u32",
            "vox",
            "aam",
            "aas",
            "bcpio",
            "torrent",
            "blb",
            "blorb",
            "bz",
            "bz2",
            "boz",
            "cbr",
            "cba",
            "cbt",
            "cbz",
            "cb7",
            "vcd",
            "cfs",
            "chat",
            "pgn",
            "nsc",
            "cpio",
            "csh",
            "deb",
            "udeb",
            "dgc",
            "dir",
            "dcr",
            "dxr",
            "cst",
            "cct",
            "cxt",
            "w3d",
            "fgd",
            "swa",
            "wad",
            "ncx",
            "dtb",
            "res",
            "dvi",
            "evy",
            "eva",
            "bdf",
            "gsf",
            "psf",
            "otf",
            "pcf",
            "snf",
            "ttf",
            "ttc",
            "pfa",
            "pfb",
            "pfm",
            "afm",
            "arc",
            "spl",
            "gca",
            "ulx",
            "gnumeric",
            "gramps",
            "gtar",
            "hdf",
            "install",
            "iso",
            "jnlp",
            "latex",
            "lzh",
            "lha",
            "mie",
            "prc",
            "mobi",
            "application",
            "lnk",
            "wmd",
            "wmz",
            "xbap",
            "mdb",
            "obd",
            "crd",
            "clp",
            "exe",
            "dll",
            "com",
            "bat",
            "msi",
            "mvb",
            "m13",
            "m14",
            "wmf",
            "emf",
            "emz",
            "mny",
            "pub",
            "scd",
            "trm",
            "wri",
            "nc",
            "cdf",
            "nzb",
            "p12",
            "pfx",
            "p7b",
            "spc",
            "p7r",
            "rar",
            "ris",
            "sh",
            "shar",
            "swf",
            "xap",
            "sql",
            "sit",
            "sitx",
            "srt",
            "sv4cpio",
            "sv4crc",
            "t3",
            "gam",
            "tar",
            "tcl",
            "tex",
            "tfm",
            "texinfo",
            "texi",
            "obj",
            "ustar",
            "src",
            "der",
            "crt",
            "fig",
            "xlf",
            "xpi",
            "xz",
            "z1",
            "z2",
            "z3",
            "z4",
            "z5",
            "z6",
            "z7",
            "z8",
            "xaml",
            "xdf",
            "xenc",
            "xhtml",
            "xht",
            "xml",
            "xsl",
            "dtd",
            "xop",
            "xpl",
            "xslt",
            "xspf",
            "mxml",
            "xhvml",
            "xvml",
            "xvm",
            "yang",
            "yin",
            "zip",
            "adp",
            "au",
            "snd",
            "mid",
            "midi",
            "kar",
            "rmi",
            "m4a",
            "mp4a",
            "mpga",
            "mp2",
            "mp2a",
            "mp3",
            "m2a",
            "m3a",
            "oga",
            "ogg",
            "spx",
            "s3m",
            "sil",
            "uva",
            "uvva",
            "eol",
            "dra",
            "dts",
            "dtshd",
            "lvp",
            "pya",
            "ecelp4800",
            "ecelp7470",
            "ecelp9600",
            "rip",
            "weba",
            "aac",
            "aif",
            "aiff",
            "aifc",
            "caf",
            "flac",
            "mka",
            "m3u",
            "wax",
            "wma",
            "ram",
            "ra",
            "rmp",
            "wav",
            "xm",
            "cdx",
            "cif",
            "cmdf",
            "cml",
            "csml",
            "xyz",
            "bmp",
            "cgm",
            "g3",
            "gif",
            "ief",
            "jpeg",
            "jpg",
            "jpe",
            "ktx",
            "png",
            "btif",
            "sgi",
            "svg",
            "svgz",
            "tiff",
            "tif",
            "psd",
            "uvi",
            "uvvi",
            "uvg",
            "uvvg",
            "djvu",
            "djv",
            "sub",
            "dwg",
            "dxf",
            "fbs",
            "fpx",
            "fst",
            "mmr",
            "rlc",
            "mdi",
            "wdp",
            "npx",
            "wbmp",
            "xif",
            "webp",
            "3ds",
            "ras",
            "cmx",
            "fh",
            "fhc",
            "fh4",
            "fh5",
            "fh7",
            "ico",
            "sid",
            "pcx",
            "pic",
            "pct",
            "pnm",
            "pbm",
            "pgm",
            "ppm",
            "rgb",
            "tga",
            "xbm",
            "xpm",
            "xwd",
            "eml",
            "mime",
            "igs",
            "iges",
            "msh",
            "mesh",
            "silo",
            "dae",
            "dwf",
            "gdl",
            "gtw",
            "mts",
            "vtu",
            "wrl",
            "vrml",
            "x3db",
            "x3dbz",
            "x3dv",
            "x3dvz",
            "x3d",
            "x3dz",
            "appcache",
            "ics",
            "ifb",
            "css",
            "csv",
            "html",
            "htm",
            "n3",
            "txt",
            "text",
            "conf",
            "def",
            "list",
            "log",
            "in",
            "dsc",
            "rtx",
            "sgml",
            "sgm",
            "tsv",
            "t",
            "tr",
            "roff",
            "man",
            "me",
            "ms",
            "ttl",
            "uri",
            "uris",
            "urls",
            "vcard",
            "curl",
            "dcurl",
            "mcurl",
            "scurl",
            "fly",
            "flx",
            "gv",
            "3dml",
            "spot",
            "jad",
            "wml",
            "wmls",
            "s",
            "asm",
            "c",
            "cc",
            "cxx",
            "cpp",
            "h",
            "hh",
            "dic",
            "f",
            "for",
            "f77",
            "f90",
            "java",
            "nfo",
            "opml",
            "p",
            "pas",
            "etx",
            "sfv",
            "uu",
            "vcs",
            "vcf",
            "3gp",
            "3g2",
            "h261",
            "h263",
            "h264",
            "jpgv",
            "jpm",
            "jpgm",
            "mj2",
            "mjp2",
            "mp4",
            "mp4v",
            "mpg4",
            "mpeg",
            "mpg",
            "mpe",
            "m1v",
            "m2v",
            "ogv",
            "qt",
            "mov",
            "uvh",
            "uvvh",
            "uvm",
            "uvvm",
            "uvp",
            "uvvp",
            "uvs",
            "uvvs",
            "uvv",
            "uvvv",
            "dvb",
            "fvt",
            "mxu",
            "m4u",
            "pyv",
            "uvu",
            "uvvu",
            "viv",
            "webm",
            "f4v",
            "fli",
            "flv",
            "m4v",
            "mkv",
            "mk3d",
            "mks",
            "mng",
            "asf",
            "asx",
            "vob",
            "wm",
            "wmv",
            "wmx",
            "wvx",
            "avi",
            "movie",
            "smv",
            "ice",
            "map",
            "topojson",
            "jsonld",
            "geojson",
            "webmanifest",
            "webapp",
            "f4a",
            "f4b",
            "opus",
            "jng",
            "3gpp",
            "f4p",
            "cur",
            "woff2",
            "ear",
            "war",
            "img",
            "msm",
            "msp",
            "safariextz",
            "bbaw",
            "crx",
            "cco",
            "jardiff",
            "run",
            "oex",
            "pl",
            "pm",
            "rpm",
            "sea",
            "tk",
            "pem",
            "shtml",
            "mml",
            "xloc",
            "vtt",
            "htc",
        };

        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        static string LookupType(string type)
        {
            switch (type)
            {
                case "ez": return "application/andrew-inset";
                case "aw": return "application/applixware";
                case "atom": return "application/atom+xml";
                case "atomcat": return "application/atomcat+xml";
                case "atomsvc": return "application/atomsvc+xml";
                case "ccxml": return "application/ccxml+xml";
                case "cdmia": return "application/cdmi-capability";
                case "cdmic": return "application/cdmi-container";
                case "cdmid": return "application/cdmi-domain";
                case "cdmio": return "application/cdmi-object";
                case "cdmiq": return "application/cdmi-queue";
                case "cu": return "application/cu-seeme";
                case "davmount": return "application/davmount+xml";
                case "dbk": return "application/docbook+xml";
                case "dssc": return "application/dssc+der";
                case "xdssc": return "application/dssc+xml";
                case "ecma": return "application/ecmascript";
                case "emma": return "application/emma+xml";
                case "epub": return "application/epub+zip";
                case "exi": return "application/exi";
                case "pfr": return "application/font-tdpfr";
                case "woff": return "application/font-woff";
                case "gml": return "application/gml+xml";
                case "gpx": return "application/gpx+xml";
                case "gxf": return "application/gxf";
                case "stk": return "application/hyperstudio";
                case "ink": return "application/inkml+xml";
                case "inkml": return "application/inkml+xml";
                case "ipfix": return "application/ipfix";
                case "jar": return "application/java-archive";
                case "ser": return "application/java-serialized-object";
                case "class": return "application/java-vm";
                case "js": return "application/javascript";
                case "json": return "application/json";
                case "jsonml": return "application/jsonml+json";
                case "lostxml": return "application/lost+xml";
                case "hqx": return "application/mac-binhex40";
                case "cpt": return "application/mac-compactpro";
                case "mads": return "application/mads+xml";
                case "mrc": return "application/marc";
                case "mrcx": return "application/marcxml+xml";
                case "ma": return "application/mathematica";
                case "nb": return "application/mathematica";
                case "mb": return "application/mathematica";
                case "mathml": return "application/mathml+xml";
                case "mbox": return "application/mbox";
                case "mscml": return "application/mediaservercontrol+xml";
                case "metalink": return "application/metalink+xml";
                case "meta4": return "application/metalink4+xml";
                case "mets": return "application/mets+xml";
                case "mods": return "application/mods+xml";
                case "m21": return "application/mp21";
                case "mp21": return "application/mp21";
                case "mp4s": return "application/mp4";
                case "doc": return "application/msword";
                case "dot": return "application/msword";
                case "mxf": return "application/mxf";
                case "bin": return "application/octet-stream";
                case "dms": return "application/octet-stream";
                case "lrf": return "application/octet-stream";
                case "mar": return "application/octet-stream";
                case "so": return "application/octet-stream";
                case "dist": return "application/octet-stream";
                case "distz": return "application/octet-stream";
                case "pkg": return "application/octet-stream";
                case "bpk": return "application/octet-stream";
                case "dump": return "application/octet-stream";
                case "elc": return "application/octet-stream";
                case "deploy": return "application/octet-stream";
                case "oda": return "application/oda";
                case "opf": return "application/oebps-package+xml";
                case "ogx": return "application/ogg";
                case "omdoc": return "application/omdoc+xml";
                case "onetoc": return "application/onenote";
                case "onetoc2": return "application/onenote";
                case "onetmp": return "application/onenote";
                case "onepkg": return "application/onenote";
                case "oxps": return "application/oxps";
                case "xer": return "application/patch-ops-error+xml";
                case "pdf": return "application/pdf";
                case "pgp": return "application/pgp-encrypted";
                case "asc": return "application/pgp-signature";
                case "sig": return "application/pgp-signature";
                case "prf": return "application/pics-rules";
                case "p10": return "application/pkcs10";
                case "p7m": return "application/pkcs7-mime";
                case "p7c": return "application/pkcs7-mime";
                case "p7s": return "application/pkcs7-signature";
                case "p8": return "application/pkcs8";
                case "ac": return "application/pkix-attr-cert";
                case "cer": return "application/pkix-cert";
                case "crl": return "application/pkix-crl";
                case "pkipath": return "application/pkix-pkipath";
                case "pki": return "application/pkixcmp";
                case "pls": return "application/pls+xml";
                case "ai": return "application/postscript";
                case "eps": return "application/postscript";
                case "ps": return "application/postscript";
                case "cww": return "application/prs.cww";
                case "pskcxml": return "application/pskc+xml";
                case "rdf": return "application/rdf+xml";
                case "rif": return "application/reginfo+xml";
                case "rnc": return "application/relax-ng-compact-syntax";
                case "rl": return "application/resource-lists+xml";
                case "rld": return "application/resource-lists-diff+xml";
                case "rs": return "application/rls-services+xml";
                case "gbr": return "application/rpki-ghostbusters";
                case "mft": return "application/rpki-manifest";
                case "roa": return "application/rpki-roa";
                case "rsd": return "application/rsd+xml";
                case "rss": return "application/rss+xml";
                case "rtf": return "application/rtf";
                case "sbml": return "application/sbml+xml";
                case "scq": return "application/scvp-cv-request";
                case "scs": return "application/scvp-cv-response";
                case "spq": return "application/scvp-vp-request";
                case "spp": return "application/scvp-vp-response";
                case "sdp": return "application/sdp";
                case "setpay": return "application/set-payment-initiation";
                case "setreg": return "application/set-registration-initiation";
                case "shf": return "application/shf+xml";
                case "smi": return "application/smil+xml";
                case "smil": return "application/smil+xml";
                case "rq": return "application/sparql-query";
                case "srx": return "application/sparql-results+xml";
                case "gram": return "application/srgs";
                case "grxml": return "application/srgs+xml";
                case "sru": return "application/sru+xml";
                case "ssdl": return "application/ssdl+xml";
                case "ssml": return "application/ssml+xml";
                case "tei": return "application/tei+xml";
                case "teicorpus": return "application/tei+xml";
                case "tfi": return "application/thraud+xml";
                case "tsd": return "application/timestamped-data";
                case "plb": return "application/vnd.3gpp.pic-bw-large";
                case "psb": return "application/vnd.3gpp.pic-bw-small";
                case "pvb": return "application/vnd.3gpp.pic-bw-var";
                case "tcap": return "application/vnd.3gpp2.tcap";
                case "pwn": return "application/vnd.3m.post-it-notes";
                case "aso": return "application/vnd.accpac.simply.aso";
                case "imp": return "application/vnd.accpac.simply.imp";
                case "acu": return "application/vnd.acucobol";
                case "atc": return "application/vnd.acucorp";
                case "acutc": return "application/vnd.acucorp";
                case "air": return "application/vnd.adobe.air-application-installer-package+zip";
                case "fcdt": return "application/vnd.adobe.formscentral.fcdt";
                case "fxp": return "application/vnd.adobe.fxp";
                case "fxpl": return "application/vnd.adobe.fxp";
                case "xdp": return "application/vnd.adobe.xdp+xml";
                case "xfdf": return "application/vnd.adobe.xfdf";
                case "ahead": return "application/vnd.ahead.space";
                case "azf": return "application/vnd.airzip.filesecure.azf";
                case "azs": return "application/vnd.airzip.filesecure.azs";
                case "azw": return "application/vnd.amazon.ebook";
                case "acc": return "application/vnd.americandynamics.acc";
                case "ami": return "application/vnd.amiga.ami";
                case "apk": return "application/vnd.android.package-archive";
                case "cii": return "application/vnd.anser-web-certificate-issue-initiation";
                case "fti": return "application/vnd.anser-web-funds-transfer-initiation";
                case "atx": return "application/vnd.antix.game-component";
                case "mpkg": return "application/vnd.apple.installer+xml";
                case "m3u8": return "application/vnd.apple.mpegurl";
                case "swi": return "application/vnd.aristanetworks.swi";
                case "iota": return "application/vnd.astraea-software.iota";
                case "aep": return "application/vnd.audiograph";
                case "mpm": return "application/vnd.blueice.multipass";
                case "bmi": return "application/vnd.bmi";
                case "rep": return "application/vnd.businessobjects";
                case "cdxml": return "application/vnd.chemdraw+xml";
                case "mmd": return "application/vnd.chipnuts.karaoke-mmd";
                case "cdy": return "application/vnd.cinderella";
                case "cla": return "application/vnd.claymore";
                case "rp9": return "application/vnd.cloanto.rp9";
                case "c4g": return "application/vnd.clonk.c4group";
                case "c4d": return "application/vnd.clonk.c4group";
                case "c4f": return "application/vnd.clonk.c4group";
                case "c4p": return "application/vnd.clonk.c4group";
                case "c4u": return "application/vnd.clonk.c4group";
                case "c11amc": return "application/vnd.cluetrust.cartomobile-config";
                case "c11amz": return "application/vnd.cluetrust.cartomobile-config-pkg";
                case "csp": return "application/vnd.commonspace";
                case "cdbcmsg": return "application/vnd.contact.cmsg";
                case "cmc": return "application/vnd.cosmocaller";
                case "clkx": return "application/vnd.crick.clicker";
                case "clkk": return "application/vnd.crick.clicker.keyboard";
                case "clkp": return "application/vnd.crick.clicker.palette";
                case "clkt": return "application/vnd.crick.clicker.template";
                case "clkw": return "application/vnd.crick.clicker.wordbank";
                case "wbs": return "application/vnd.criticaltools.wbs+xml";
                case "pml": return "application/vnd.ctc-posml";
                case "ppd": return "application/vnd.cups-ppd";
                case "car": return "application/vnd.curl.car";
                case "pcurl": return "application/vnd.curl.pcurl";
                case "dart": return "application/vnd.dart";
                case "rdz": return "application/vnd.data-vision.rdz";
                case "uvf": return "application/vnd.dece.data";
                case "uvvf": return "application/vnd.dece.data";
                case "uvd": return "application/vnd.dece.data";
                case "uvvd": return "application/vnd.dece.data";
                case "uvt": return "application/vnd.dece.ttml+xml";
                case "uvvt": return "application/vnd.dece.ttml+xml";
                case "uvx": return "application/vnd.dece.unspecified";
                case "uvvx": return "application/vnd.dece.unspecified";
                case "uvz": return "application/vnd.dece.zip";
                case "uvvz": return "application/vnd.dece.zip";
                case "fe_launch": return "application/vnd.denovo.fcselayout-link";
                case "dna": return "application/vnd.dna";
                case "mlp": return "application/vnd.dolby.mlp";
                case "dpg": return "application/vnd.dpgraph";
                case "dfac": return "application/vnd.dreamfactory";
                case "kpxx": return "application/vnd.ds-keypoint";
                case "ait": return "application/vnd.dvb.ait";
                case "svc": return "application/vnd.dvb.service";
                case "geo": return "application/vnd.dynageo";
                case "mag": return "application/vnd.ecowin.chart";
                case "nml": return "application/vnd.enliven";
                case "esf": return "application/vnd.epson.esf";
                case "msf": return "application/vnd.epson.msf";
                case "qam": return "application/vnd.epson.quickanime";
                case "slt": return "application/vnd.epson.salt";
                case "ssf": return "application/vnd.epson.ssf";
                case "es3": return "application/vnd.eszigno3+xml";
                case "et3": return "application/vnd.eszigno3+xml";
                case "ez2": return "application/vnd.ezpix-album";
                case "ez3": return "application/vnd.ezpix-package";
                case "fdf": return "application/vnd.fdf";
                case "mseed": return "application/vnd.fdsn.mseed";
                case "seed": return "application/vnd.fdsn.seed";
                case "dataless": return "application/vnd.fdsn.seed";
                case "gph": return "application/vnd.flographit";
                case "ftc": return "application/vnd.fluxtime.clip";
                case "fm": return "application/vnd.framemaker";
                case "frame": return "application/vnd.framemaker";
                case "maker": return "application/vnd.framemaker";
                case "book": return "application/vnd.framemaker";
                case "fnc": return "application/vnd.frogans.fnc";
                case "ltf": return "application/vnd.frogans.ltf";
                case "fsc": return "application/vnd.fsc.weblaunch";
                case "oas": return "application/vnd.fujitsu.oasys";
                case "oa2": return "application/vnd.fujitsu.oasys2";
                case "oa3": return "application/vnd.fujitsu.oasys3";
                case "fg5": return "application/vnd.fujitsu.oasysgp";
                case "bh2": return "application/vnd.fujitsu.oasysprs";
                case "ddd": return "application/vnd.fujixerox.ddd";
                case "xdw": return "application/vnd.fujixerox.docuworks";
                case "xbd": return "application/vnd.fujixerox.docuworks.binder";
                case "fzs": return "application/vnd.fuzzysheet";
                case "txd": return "application/vnd.genomatix.tuxedo";
                case "ggb": return "application/vnd.geogebra.file";
                case "ggt": return "application/vnd.geogebra.tool";
                case "gex": return "application/vnd.geometry-explorer";
                case "gre": return "application/vnd.geometry-explorer";
                case "gxt": return "application/vnd.geonext";
                case "g2w": return "application/vnd.geoplan";
                case "g3w": return "application/vnd.geospace";
                case "gmx": return "application/vnd.gmx";
                case "kml": return "application/vnd.google-earth.kml+xml";
                case "kmz": return "application/vnd.google-earth.kmz";
                case "gqf": return "application/vnd.grafeq";
                case "gqs": return "application/vnd.grafeq";
                case "gac": return "application/vnd.groove-account";
                case "ghf": return "application/vnd.groove-help";
                case "gim": return "application/vnd.groove-identity-message";
                case "grv": return "application/vnd.groove-injector";
                case "gtm": return "application/vnd.groove-tool-message";
                case "tpl": return "application/vnd.groove-tool-template";
                case "vcg": return "application/vnd.groove-vcard";
                case "hal": return "application/vnd.hal+xml";
                case "zmm": return "application/vnd.handheld-entertainment+xml";
                case "hbci": return "application/vnd.hbci";
                case "les": return "application/vnd.hhe.lesson-player";
                case "hpgl": return "application/vnd.hp-hpgl";
                case "hpid": return "application/vnd.hp-hpid";
                case "hps": return "application/vnd.hp-hps";
                case "jlt": return "application/vnd.hp-jlyt";
                case "pcl": return "application/vnd.hp-pcl";
                case "pclxl": return "application/vnd.hp-pclxl";
                case "sfd-hdstx": return "application/vnd.hydrostatix.sof-data";
                case "mpy": return "application/vnd.ibm.minipay";
                case "afp": return "application/vnd.ibm.modcap";
                case "listafp": return "application/vnd.ibm.modcap";
                case "list3820": return "application/vnd.ibm.modcap";
                case "irm": return "application/vnd.ibm.rights-management";
                case "sc": return "application/vnd.ibm.secure-container";
                case "icc": return "application/vnd.iccprofile";
                case "icm": return "application/vnd.iccprofile";
                case "igl": return "application/vnd.igloader";
                case "ivp": return "application/vnd.immervision-ivp";
                case "ivu": return "application/vnd.immervision-ivu";
                case "igm": return "application/vnd.insors.igm";
                case "xpw": return "application/vnd.intercon.formnet";
                case "xpx": return "application/vnd.intercon.formnet";
                case "i2g": return "application/vnd.intergeo";
                case "qbo": return "application/vnd.intu.qbo";
                case "qfx": return "application/vnd.intu.qfx";
                case "rcprofile": return "application/vnd.ipunplugged.rcprofile";
                case "irp": return "application/vnd.irepository.package+xml";
                case "xpr": return "application/vnd.is-xpr";
                case "fcs": return "application/vnd.isac.fcs";
                case "jam": return "application/vnd.jam";
                case "rms": return "application/vnd.jcp.javame.midlet-rms";
                case "jisp": return "application/vnd.jisp";
                case "joda": return "application/vnd.joost.joda-archive";
                case "ktz": return "application/vnd.kahootz";
                case "ktr": return "application/vnd.kahootz";
                case "karbon": return "application/vnd.kde.karbon";
                case "chrt": return "application/vnd.kde.kchart";
                case "kfo": return "application/vnd.kde.kformula";
                case "flw": return "application/vnd.kde.kivio";
                case "kon": return "application/vnd.kde.kontour";
                case "kpr": return "application/vnd.kde.kpresenter";
                case "kpt": return "application/vnd.kde.kpresenter";
                case "ksp": return "application/vnd.kde.kspread";
                case "kwd": return "application/vnd.kde.kword";
                case "kwt": return "application/vnd.kde.kword";
                case "htke": return "application/vnd.kenameaapp";
                case "kia": return "application/vnd.kidspiration";
                case "kne": return "application/vnd.kinar";
                case "knp": return "application/vnd.kinar";
                case "skp": return "application/vnd.koan";
                case "skd": return "application/vnd.koan";
                case "skt": return "application/vnd.koan";
                case "skm": return "application/vnd.koan";
                case "sse": return "application/vnd.kodak-descriptor";
                case "lasxml": return "application/vnd.las.las+xml";
                case "lbd": return "application/vnd.llamagraphics.life-balance.desktop";
                case "lbe": return "application/vnd.llamagraphics.life-balance.exchange+xml";
                case "123": return "application/vnd.lotus-1-2-3";
                case "apr": return "application/vnd.lotus-approach";
                case "pre": return "application/vnd.lotus-freelance";
                case "nsf": return "application/vnd.lotus-notes";
                case "org": return "application/vnd.lotus-organizer";
                case "scm": return "application/vnd.lotus-screencam";
                case "lwp": return "application/vnd.lotus-wordpro";
                case "portpkg": return "application/vnd.macports.portpkg";
                case "mcd": return "application/vnd.mcd";
                case "mc1": return "application/vnd.medcalcdata";
                case "cdkey": return "application/vnd.mediastation.cdkey";
                case "mwf": return "application/vnd.mfer";
                case "mfm": return "application/vnd.mfmp";
                case "flo": return "application/vnd.micrografx.flo";
                case "igx": return "application/vnd.micrografx.igx";
                case "mif": return "application/vnd.mif";
                case "daf": return "application/vnd.mobius.daf";
                case "dis": return "application/vnd.mobius.dis";
                case "mbk": return "application/vnd.mobius.mbk";
                case "mqy": return "application/vnd.mobius.mqy";
                case "msl": return "application/vnd.mobius.msl";
                case "plc": return "application/vnd.mobius.plc";
                case "txf": return "application/vnd.mobius.txf";
                case "mpn": return "application/vnd.mophun.application";
                case "mpc": return "application/vnd.mophun.certificate";
                case "xul": return "application/vnd.mozilla.xul+xml";
                case "cil": return "application/vnd.ms-artgalry";
                case "cab": return "application/vnd.ms-cab-compressed";
                case "xls": return "application/vnd.ms-excel";
                case "xlm": return "application/vnd.ms-excel";
                case "xla": return "application/vnd.ms-excel";
                case "xlc": return "application/vnd.ms-excel";
                case "xlt": return "application/vnd.ms-excel";
                case "xlw": return "application/vnd.ms-excel";
                case "xlam": return "application/vnd.ms-excel.addin.macroenabled.12";
                case "xlsb": return "application/vnd.ms-excel.sheet.binary.macroenabled.12";
                case "xlsm": return "application/vnd.ms-excel.sheet.macroenabled.12";
                case "xltm": return "application/vnd.ms-excel.template.macroenabled.12";
                case "eot": return "application/vnd.ms-fontobject";
                case "chm": return "application/vnd.ms-htmlhelp";
                case "ims": return "application/vnd.ms-ims";
                case "lrm": return "application/vnd.ms-lrm";
                case "thmx": return "application/vnd.ms-officetheme";
                case "cat": return "application/vnd.ms-pki.seccat";
                case "stl": return "application/vnd.ms-pki.stl";
                case "ppt": return "application/vnd.ms-powerpoint";
                case "pps": return "application/vnd.ms-powerpoint";
                case "pot": return "application/vnd.ms-powerpoint";
                case "ppam": return "application/vnd.ms-powerpoint.addin.macroenabled.12";
                case "pptm": return "application/vnd.ms-powerpoint.presentation.macroenabled.12";
                case "sldm": return "application/vnd.ms-powerpoint.slide.macroenabled.12";
                case "ppsm": return "application/vnd.ms-powerpoint.slideshow.macroenabled.12";
                case "potm": return "application/vnd.ms-powerpoint.template.macroenabled.12";
                case "mpp": return "application/vnd.ms-project";
                case "mpt": return "application/vnd.ms-project";
                case "docm": return "application/vnd.ms-word.document.macroenabled.12";
                case "dotm": return "application/vnd.ms-word.template.macroenabled.12";
                case "wps": return "application/vnd.ms-works";
                case "wks": return "application/vnd.ms-works";
                case "wcm": return "application/vnd.ms-works";
                case "wdb": return "application/vnd.ms-works";
                case "wpl": return "application/vnd.ms-wpl";
                case "xps": return "application/vnd.ms-xpsdocument";
                case "mseq": return "application/vnd.mseq";
                case "mus": return "application/vnd.musician";
                case "msty": return "application/vnd.muvee.style";
                case "taglet": return "application/vnd.mynfc";
                case "nlu": return "application/vnd.neurolanguage.nlu";
                case "ntf": return "application/vnd.nitf";
                case "nitf": return "application/vnd.nitf";
                case "nnd": return "application/vnd.noblenet-directory";
                case "nns": return "application/vnd.noblenet-sealer";
                case "nnw": return "application/vnd.noblenet-web";
                case "ngdat": return "application/vnd.nokia.n-gage.data";
                case "n-gage": return "application/vnd.nokia.n-gage.symbian.install";
                case "rpst": return "application/vnd.nokia.radio-preset";
                case "rpss": return "application/vnd.nokia.radio-presets";
                case "edm": return "application/vnd.novadigm.edm";
                case "edx": return "application/vnd.novadigm.edx";
                case "ext": return "application/vnd.novadigm.ext";
                case "odc": return "application/vnd.oasis.opendocument.chart";
                case "otc": return "application/vnd.oasis.opendocument.chart-template";
                case "odb": return "application/vnd.oasis.opendocument.database";
                case "odf": return "application/vnd.oasis.opendocument.formula";
                case "odft": return "application/vnd.oasis.opendocument.formula-template";
                case "odg": return "application/vnd.oasis.opendocument.graphics";
                case "otg": return "application/vnd.oasis.opendocument.graphics-template";
                case "odi": return "application/vnd.oasis.opendocument.image";
                case "oti": return "application/vnd.oasis.opendocument.image-template";
                case "odp": return "application/vnd.oasis.opendocument.presentation";
                case "otp": return "application/vnd.oasis.opendocument.presentation-template";
                case "ods": return "application/vnd.oasis.opendocument.spreadsheet";
                case "ots": return "application/vnd.oasis.opendocument.spreadsheet-template";
                case "odt": return "application/vnd.oasis.opendocument.text";
                case "odm": return "application/vnd.oasis.opendocument.text-master";
                case "ott": return "application/vnd.oasis.opendocument.text-template";
                case "oth": return "application/vnd.oasis.opendocument.text-web";
                case "xo": return "application/vnd.olpc-sugar";
                case "dd2": return "application/vnd.oma.dd2+xml";
                case "oxt": return "application/vnd.openofficeorg.extension";
                case "pptx": return "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                case "sldx": return "application/vnd.openxmlformats-officedocument.presentationml.slide";
                case "ppsx": return "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
                case "potx": return "application/vnd.openxmlformats-officedocument.presentationml.template";
                case "xlsx": return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                case "xltx": return "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
                case "docx": return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case "dotx": return "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
                case "mgp": return "application/vnd.osgeo.mapguide.package";
                case "dp": return "application/vnd.osgi.dp";
                case "esa": return "application/vnd.osgi.subsystem";
                case "pdb": return "application/vnd.palm";
                case "pqa": return "application/vnd.palm";
                case "oprc": return "application/vnd.palm";
                case "paw": return "application/vnd.pawaafile";
                case "str": return "application/vnd.pg.format";
                case "ei6": return "application/vnd.pg.osasli";
                case "efif": return "application/vnd.picsel";
                case "wg": return "application/vnd.pmi.widget";
                case "plf": return "application/vnd.pocketlearn";
                case "pbd": return "application/vnd.powerbuilder6";
                case "box": return "application/vnd.previewsystems.box";
                case "mgz": return "application/vnd.proteus.magazine";
                case "qps": return "application/vnd.publishare-delta-tree";
                case "ptid": return "application/vnd.pvi.ptid1";
                case "qxd": return "application/vnd.quark.quarkxpress";
                case "qxt": return "application/vnd.quark.quarkxpress";
                case "qwd": return "application/vnd.quark.quarkxpress";
                case "qwt": return "application/vnd.quark.quarkxpress";
                case "qxl": return "application/vnd.quark.quarkxpress";
                case "qxb": return "application/vnd.quark.quarkxpress";
                case "bed": return "application/vnd.realvnc.bed";
                case "mxl": return "application/vnd.recordare.musicxml";
                case "musicxml": return "application/vnd.recordare.musicxml+xml";
                case "cryptonote": return "application/vnd.rig.cryptonote";
                case "cod": return "application/vnd.rim.cod";
                case "rm": return "application/vnd.rn-realmedia";
                case "rmvb": return "application/vnd.rn-realmedia-vbr";
                case "link66": return "application/vnd.route66.link66+xml";
                case "st": return "application/vnd.sailingtracker.track";
                case "see": return "application/vnd.seemail";
                case "sema": return "application/vnd.sema";
                case "semd": return "application/vnd.semd";
                case "semf": return "application/vnd.semf";
                case "ifm": return "application/vnd.shana.informed.formdata";
                case "itp": return "application/vnd.shana.informed.formtemplate";
                case "iif": return "application/vnd.shana.informed.interchange";
                case "ipk": return "application/vnd.shana.informed.package";
                case "twd": return "application/vnd.simtech-mindmapper";
                case "twds": return "application/vnd.simtech-mindmapper";
                case "mmf": return "application/vnd.smaf";
                case "teacher": return "application/vnd.smart.teacher";
                case "sdkm": return "application/vnd.solent.sdkm+xml";
                case "sdkd": return "application/vnd.solent.sdkm+xml";
                case "dxp": return "application/vnd.spotfire.dxp";
                case "sfs": return "application/vnd.spotfire.sfs";
                case "sdc": return "application/vnd.stardivision.calc";
                case "sda": return "application/vnd.stardivision.draw";
                case "sdd": return "application/vnd.stardivision.impress";
                case "smf": return "application/vnd.stardivision.math";
                case "sdw": return "application/vnd.stardivision.writer";
                case "vor": return "application/vnd.stardivision.writer";
                case "sgl": return "application/vnd.stardivision.writer-global";
                case "smzip": return "application/vnd.stepmania.package";
                case "sm": return "application/vnd.stepmania.stepchart";
                case "sxc": return "application/vnd.sun.xml.calc";
                case "stc": return "application/vnd.sun.xml.calc.template";
                case "sxd": return "application/vnd.sun.xml.draw";
                case "std": return "application/vnd.sun.xml.draw.template";
                case "sxi": return "application/vnd.sun.xml.impress";
                case "sti": return "application/vnd.sun.xml.impress.template";
                case "sxm": return "application/vnd.sun.xml.math";
                case "sxw": return "application/vnd.sun.xml.writer";
                case "sxg": return "application/vnd.sun.xml.writer.global";
                case "stw": return "application/vnd.sun.xml.writer.template";
                case "sus": return "application/vnd.sus-calendar";
                case "susp": return "application/vnd.sus-calendar";
                case "svd": return "application/vnd.svd";
                case "sis": return "application/vnd.symbian.install";
                case "sisx": return "application/vnd.symbian.install";
                case "xsm": return "application/vnd.syncml+xml";
                case "bdm": return "application/vnd.syncml.dm+wbxml";
                case "xdm": return "application/vnd.syncml.dm+xml";
                case "tao": return "application/vnd.tao.intent-module-archive";
                case "pcap": return "application/vnd.tcpdump.pcap";
                case "cap": return "application/vnd.tcpdump.pcap";
                case "dmp": return "application/vnd.tcpdump.pcap";
                case "tmo": return "application/vnd.tmobile-livetv";
                case "tpt": return "application/vnd.trid.tpt";
                case "mxs": return "application/vnd.triscape.mxs";
                case "tra": return "application/vnd.trueapp";
                case "ufd": return "application/vnd.ufdl";
                case "ufdl": return "application/vnd.ufdl";
                case "utz": return "application/vnd.uiq.theme";
                case "umj": return "application/vnd.umajin";
                case "unityweb": return "application/vnd.unity";
                case "uoml": return "application/vnd.uoml+xml";
                case "vcx": return "application/vnd.vcx";
                case "vsd": return "application/vnd.visio";
                case "vst": return "application/vnd.visio";
                case "vss": return "application/vnd.visio";
                case "vsw": return "application/vnd.visio";
                case "vis": return "application/vnd.visionary";
                case "vsf": return "application/vnd.vsf";
                case "wbxml": return "application/vnd.wap.wbxml";
                case "wmlc": return "application/vnd.wap.wmlc";
                case "wmlsc": return "application/vnd.wap.wmlscriptc";
                case "wtb": return "application/vnd.webturbo";
                case "nbp": return "application/vnd.wolfram.player";
                case "wpd": return "application/vnd.wordperfect";
                case "wqd": return "application/vnd.wqd";
                case "stf": return "application/vnd.wt.stf";
                case "xar": return "application/vnd.xara";
                case "xfdl": return "application/vnd.xfdl";
                case "hvd": return "application/vnd.yamaha.hv-dic";
                case "hvs": return "application/vnd.yamaha.hv-script";
                case "hvp": return "application/vnd.yamaha.hv-voice";
                case "osf": return "application/vnd.yamaha.openscoreformat";
                case "osfpvg": return "application/vnd.yamaha.openscoreformat.osfpvg+xml";
                case "saf": return "application/vnd.yamaha.smaf-audio";
                case "spf": return "application/vnd.yamaha.smaf-phrase";
                case "cmp": return "application/vnd.yellowriver-custom-menu";
                case "zir": return "application/vnd.zul";
                case "zirz": return "application/vnd.zul";
                case "zaz": return "application/vnd.zzazz.deck+xml";
                case "vxml": return "application/voicexml+xml";
                case "wgt": return "application/widget";
                case "hlp": return "application/winhlp";
                case "wsdl": return "application/wsdl+xml";
                case "wspolicy": return "application/wspolicy+xml";
                case "7z": return "application/x-7z-compressed";
                case "abw": return "application/x-abiword";
                case "ace": return "application/x-ace-compressed";
                case "dmg": return "application/x-apple-diskimage";
                case "aab": return "application/x-authorware-bin";
                case "x32": return "application/x-authorware-bin";
                case "u32": return "application/x-authorware-bin";
                case "vox": return "application/x-authorware-bin";
                case "aam": return "application/x-authorware-map";
                case "aas": return "application/x-authorware-seg";
                case "bcpio": return "application/x-bcpio";
                case "torrent": return "application/x-bittorrent";
                case "blb": return "application/x-blorb";
                case "blorb": return "application/x-blorb";
                case "bz": return "application/x-bzip";
                case "bz2": return "application/x-bzip2";
                case "boz": return "application/x-bzip2";
                case "cbr": return "application/x-cbr";
                case "cba": return "application/x-cbr";
                case "cbt": return "application/x-cbr";
                case "cbz": return "application/x-cbr";
                case "cb7": return "application/x-cbr";
                case "vcd": return "application/x-cdlink";
                case "cfs": return "application/x-cfs-compressed";
                case "chat": return "application/x-chat";
                case "pgn": return "application/x-chess-pgn";
                case "nsc": return "application/x-conference";
                case "cpio": return "application/x-cpio";
                case "csh": return "application/x-csh";
                case "deb": return "application/x-debian-package";
                case "udeb": return "application/x-debian-package";
                case "dgc": return "application/x-dgc-compressed";
                case "dir": return "application/x-director";
                case "dcr": return "application/x-director";
                case "dxr": return "application/x-director";
                case "cst": return "application/x-director";
                case "cct": return "application/x-director";
                case "cxt": return "application/x-director";
                case "w3d": return "application/x-director";
                case "fgd": return "application/x-director";
                case "swa": return "application/x-director";
                case "wad": return "application/x-doom";
                case "ncx": return "application/x-dtbncx+xml";
                case "dtb": return "application/x-dtbook+xml";
                case "res": return "application/x-dtbresource+xml";
                case "dvi": return "application/x-dvi";
                case "evy": return "application/x-envoy";
                case "eva": return "application/x-eva";
                case "bdf": return "application/x-font-bdf";
                case "gsf": return "application/x-font-ghostscript";
                case "psf": return "application/x-font-linux-psf";
                case "otf": return "application/x-font-otf";
                case "pcf": return "application/x-font-pcf";
                case "snf": return "application/x-font-snf";
                case "ttf": return "application/x-font-ttf";
                case "ttc": return "application/x-font-ttf";
                case "pfa": return "application/x-font-type1";
                case "pfb": return "application/x-font-type1";
                case "pfm": return "application/x-font-type1";
                case "afm": return "application/x-font-type1";
                case "arc": return "application/x-freearc";
                case "spl": return "application/x-futuresplash";
                case "gca": return "application/x-gca-compressed";
                case "ulx": return "application/x-glulx";
                case "gnumeric": return "application/x-gnumeric";
                case "gramps": return "application/x-gramps-xml";
                case "gtar": return "application/x-gtar";
                case "hdf": return "application/x-hdf";
                case "install": return "application/x-install-instructions";
                case "iso": return "application/x-iso9660-image";
                case "jnlp": return "application/x-java-jnlp-file";
                case "latex": return "application/x-latex";
                case "lzh": return "application/x-lzh-compressed";
                case "lha": return "application/x-lzh-compressed";
                case "mie": return "application/x-mie";
                case "prc": return "application/x-mobipocket-ebook";
                case "mobi": return "application/x-mobipocket-ebook";
                case "application": return "application/x-ms-application";
                case "lnk": return "application/x-ms-shortcut";
                case "wmd": return "application/x-ms-wmd";
                case "wmz": return "application/x-ms-wmz";
                case "xbap": return "application/x-ms-xbap";
                case "mdb": return "application/x-msaccess";
                case "obd": return "application/x-msbinder";
                case "crd": return "application/x-mscardfile";
                case "clp": return "application/x-msclip";
                case "exe": return "application/x-msdownload";
                case "dll": return "application/x-msdownload";
                case "com": return "application/x-msdownload";
                case "bat": return "application/x-msdownload";
                case "msi": return "application/x-msdownload";
                case "mvb": return "application/x-msmediaview";
                case "m13": return "application/x-msmediaview";
                case "m14": return "application/x-msmediaview";
                case "wmf": return "application/x-msmetafile";
                case "emf": return "application/x-msmetafile";
                case "emz": return "application/x-msmetafile";
                case "mny": return "application/x-msmoney";
                case "pub": return "application/x-mspublisher";
                case "scd": return "application/x-msschedule";
                case "trm": return "application/x-msterminal";
                case "wri": return "application/x-mswrite";
                case "nc": return "application/x-netcdf";
                case "cdf": return "application/x-netcdf";
                case "nzb": return "application/x-nzb";
                case "p12": return "application/x-pkcs12";
                case "pfx": return "application/x-pkcs12";
                case "p7b": return "application/x-pkcs7-certificates";
                case "spc": return "application/x-pkcs7-certificates";
                case "p7r": return "application/x-pkcs7-certreqresp";
                case "rar": return "application/x-rar-compressed";
                case "ris": return "application/x-research-info-systems";
                case "sh": return "application/x-sh";
                case "shar": return "application/x-shar";
                case "swf": return "application/x-shockwave-flash";
                case "xap": return "application/x-silverlight-app";
                case "sql": return "application/x-sql";
                case "sit": return "application/x-stuffit";
                case "sitx": return "application/x-stuffitx";
                case "srt": return "application/x-subrip";
                case "sv4cpio": return "application/x-sv4cpio";
                case "sv4crc": return "application/x-sv4crc";
                case "t3": return "application/x-t3vm-image";
                case "gam": return "application/x-tads";
                case "tar": return "application/x-tar";
                case "tcl": return "application/x-tcl";
                case "tex": return "application/x-tex";
                case "tfm": return "application/x-tex-tfm";
                case "texinfo": return "application/x-texinfo";
                case "texi": return "application/x-texinfo";
                case "obj": return "application/x-tgif";
                case "ustar": return "application/x-ustar";
                case "src": return "application/x-wais-source";
                case "der": return "application/x-x509-ca-cert";
                case "crt": return "application/x-x509-ca-cert";
                case "fig": return "application/x-xfig";
                case "xlf": return "application/x-xliff+xml";
                case "xpi": return "application/x-xpinstall";
                case "xz": return "application/x-xz";
                case "z1": return "application/x-zmachine";
                case "z2": return "application/x-zmachine";
                case "z3": return "application/x-zmachine";
                case "z4": return "application/x-zmachine";
                case "z5": return "application/x-zmachine";
                case "z6": return "application/x-zmachine";
                case "z7": return "application/x-zmachine";
                case "z8": return "application/x-zmachine";
                case "xaml": return "application/xaml+xml";
                case "xdf": return "application/xcap-diff+xml";
                case "xenc": return "application/xenc+xml";
                case "xhtml": return "application/xhtml+xml";
                case "xht": return "application/xhtml+xml";
                case "xml": return "application/xml";
                case "xsl": return "application/xml";
                case "dtd": return "application/xml-dtd";
                case "xop": return "application/xop+xml";
                case "xpl": return "application/xproc+xml";
                case "xslt": return "application/xslt+xml";
                case "xspf": return "application/xspf+xml";
                case "mxml": return "application/xv+xml";
                case "xhvml": return "application/xv+xml";
                case "xvml": return "application/xv+xml";
                case "xvm": return "application/xv+xml";
                case "yang": return "application/yang";
                case "yin": return "application/yin+xml";
                case "zip": return "application/zip";
                case "adp": return "audio/adpcm";
                case "au": return "audio/basic";
                case "snd": return "audio/basic";
                case "mid": return "audio/midi";
                case "midi": return "audio/midi";
                case "kar": return "audio/midi";
                case "rmi": return "audio/midi";
                case "m4a": return "audio/mp4";
                case "mp4a": return "audio/mp4";
                case "mpga": return "audio/mpeg";
                case "mp2": return "audio/mpeg";
                case "mp2a": return "audio/mpeg";
                case "mp3": return "audio/mpeg";
                case "m2a": return "audio/mpeg";
                case "m3a": return "audio/mpeg";
                case "oga": return "audio/ogg";
                case "ogg": return "audio/ogg";
                case "spx": return "audio/ogg";
                case "s3m": return "audio/s3m";
                case "sil": return "audio/silk";
                case "uva": return "audio/vnd.dece.audio";
                case "uvva": return "audio/vnd.dece.audio";
                case "eol": return "audio/vnd.digital-winds";
                case "dra": return "audio/vnd.dra";
                case "dts": return "audio/vnd.dts";
                case "dtshd": return "audio/vnd.dts.hd";
                case "lvp": return "audio/vnd.lucent.voice";
                case "pya": return "audio/vnd.ms-playready.media.pya";
                case "ecelp4800": return "audio/vnd.nuera.ecelp4800";
                case "ecelp7470": return "audio/vnd.nuera.ecelp7470";
                case "ecelp9600": return "audio/vnd.nuera.ecelp9600";
                case "rip": return "audio/vnd.rip";
                case "weba": return "audio/webm";
                case "aac": return "audio/x-aac";
                case "aif": return "audio/x-aiff";
                case "aiff": return "audio/x-aiff";
                case "aifc": return "audio/x-aiff";
                case "caf": return "audio/x-caf";
                case "flac": return "audio/x-flac";
                case "mka": return "audio/x-matroska";
                case "m3u": return "audio/x-mpegurl";
                case "wax": return "audio/x-ms-wax";
                case "wma": return "audio/x-ms-wma";
                case "ram": return "audio/x-pn-realaudio";
                case "ra": return "audio/x-pn-realaudio";
                case "rmp": return "audio/x-pn-realaudio-plugin";
                case "wav": return "audio/x-wav";
                case "xm": return "audio/xm";
                case "cdx": return "chemical/x-cdx";
                case "cif": return "chemical/x-cif";
                case "cmdf": return "chemical/x-cmdf";
                case "cml": return "chemical/x-cml";
                case "csml": return "chemical/x-csml";
                case "xyz": return "chemical/x-xyz";
                case "bmp": return "image/bmp";
                case "cgm": return "image/cgm";
                case "g3": return "image/g3fax";
                case "gif": return "image/gif";
                case "ief": return "image/ief";
                case "jpeg": return "image/jpeg";
                case "jpg": return "image/jpeg";
                case "jpe": return "image/jpeg";
                case "ktx": return "image/ktx";
                case "png": return "image/png";
                case "btif": return "image/prs.btif";
                case "sgi": return "image/sgi";
                case "svg": return "image/svg+xml";
                case "svgz": return "image/svg+xml";
                case "tiff": return "image/tiff";
                case "tif": return "image/tiff";
                case "psd": return "image/vnd.adobe.photoshop";
                case "uvi": return "image/vnd.dece.graphic";
                case "uvvi": return "image/vnd.dece.graphic";
                case "uvg": return "image/vnd.dece.graphic";
                case "uvvg": return "image/vnd.dece.graphic";
                case "djvu": return "image/vnd.djvu";
                case "djv": return "image/vnd.djvu";
                case "sub": return "image/vnd.dvb.subtitle";
                case "dwg": return "image/vnd.dwg";
                case "dxf": return "image/vnd.dxf";
                case "fbs": return "image/vnd.fastbidsheet";
                case "fpx": return "image/vnd.fpx";
                case "fst": return "image/vnd.fst";
                case "mmr": return "image/vnd.fujixerox.edmics-mmr";
                case "rlc": return "image/vnd.fujixerox.edmics-rlc";
                case "mdi": return "image/vnd.ms-modi";
                case "wdp": return "image/vnd.ms-photo";
                case "npx": return "image/vnd.net-fpx";
                case "wbmp": return "image/vnd.wap.wbmp";
                case "xif": return "image/vnd.xiff";
                case "webp": return "image/webp";
                case "3ds": return "image/x-3ds";
                case "ras": return "image/x-cmu-raster";
                case "cmx": return "image/x-cmx";
                case "fh": return "image/x-freehand";
                case "fhc": return "image/x-freehand";
                case "fh4": return "image/x-freehand";
                case "fh5": return "image/x-freehand";
                case "fh7": return "image/x-freehand";
                case "ico": return "image/x-icon";
                case "sid": return "image/x-mrsid-image";
                case "pcx": return "image/x-pcx";
                case "pic": return "image/x-pict";
                case "pct": return "image/x-pict";
                case "pnm": return "image/x-portable-anymap";
                case "pbm": return "image/x-portable-bitmap";
                case "pgm": return "image/x-portable-graymap";
                case "ppm": return "image/x-portable-pixmap";
                case "rgb": return "image/x-rgb";
                case "tga": return "image/x-tga";
                case "xbm": return "image/x-xbitmap";
                case "xpm": return "image/x-xpixmap";
                case "xwd": return "image/x-xwindowdump";
                case "eml": return "message/rfc822";
                case "mime": return "message/rfc822";
                case "igs": return "model/iges";
                case "iges": return "model/iges";
                case "msh": return "model/mesh";
                case "mesh": return "model/mesh";
                case "silo": return "model/mesh";
                case "dae": return "model/vnd.collada+xml";
                case "dwf": return "model/vnd.dwf";
                case "gdl": return "model/vnd.gdl";
                case "gtw": return "model/vnd.gtw";
                case "mts": return "model/vnd.mts";
                case "vtu": return "model/vnd.vtu";
                case "wrl": return "model/vrml";
                case "vrml": return "model/vrml";
                case "x3db": return "model/x3d+binary";
                case "x3dbz": return "model/x3d+binary";
                case "x3dv": return "model/x3d+vrml";
                case "x3dvz": return "model/x3d+vrml";
                case "x3d": return "model/x3d+xml";
                case "x3dz": return "model/x3d+xml";
                case "appcache": return "text/cache-manifest";
                case "ics": return "text/calendar";
                case "ifb": return "text/calendar";
                case "css": return "text/css";
                case "csv": return "text/csv";
                case "html": return "text/html";
                case "htm": return "text/html";
                case "n3": return "text/n3";
                case "txt": return "text/plain";
                case "text": return "text/plain";
                case "conf": return "text/plain";
                case "def": return "text/plain";
                case "list": return "text/plain";
                case "log": return "text/plain";
                case "in": return "text/plain";
                case "dsc": return "text/prs.lines.tag";
                case "rtx": return "text/richtext";
                case "sgml": return "text/sgml";
                case "sgm": return "text/sgml";
                case "tsv": return "text/tab-separated-values";
                case "t": return "text/troff";
                case "tr": return "text/troff";
                case "roff": return "text/troff";
                case "man": return "text/troff";
                case "me": return "text/troff";
                case "ms": return "text/troff";
                case "ttl": return "text/turtle";
                case "uri": return "text/uri-list";
                case "uris": return "text/uri-list";
                case "urls": return "text/uri-list";
                case "vcard": return "text/vcard";
                case "curl": return "text/vnd.curl";
                case "dcurl": return "text/vnd.curl.dcurl";
                case "mcurl": return "text/vnd.curl.mcurl";
                case "scurl": return "text/vnd.curl.scurl";
                case "fly": return "text/vnd.fly";
                case "flx": return "text/vnd.fmi.flexstor";
                case "gv": return "text/vnd.graphviz";
                case "3dml": return "text/vnd.in3d.3dml";
                case "spot": return "text/vnd.in3d.spot";
                case "jad": return "text/vnd.sun.j2me.app-descriptor";
                case "wml": return "text/vnd.wap.wml";
                case "wmls": return "text/vnd.wap.wmlscript";
                case "s": return "text/x-asm";
                case "asm": return "text/x-asm";
                case "c": return "text/x-c";
                case "cc": return "text/x-c";
                case "cxx": return "text/x-c";
                case "cpp": return "text/x-c";
                case "h": return "text/x-c";
                case "hh": return "text/x-c";
                case "dic": return "text/x-c";
                case "f": return "text/x-fortran";
                case "for": return "text/x-fortran";
                case "f77": return "text/x-fortran";
                case "f90": return "text/x-fortran";
                case "java": return "text/x-java-source";
                case "nfo": return "text/x-nfo";
                case "opml": return "text/x-opml";
                case "p": return "text/x-pascal";
                case "pas": return "text/x-pascal";
                case "etx": return "text/x-setext";
                case "sfv": return "text/x-sfv";
                case "uu": return "text/x-uuencode";
                case "vcs": return "text/x-vcalendar";
                case "vcf": return "text/x-vcard";
                case "3gp": return "video/3gpp";
                case "3g2": return "video/3gpp2";
                case "h261": return "video/h261";
                case "h263": return "video/h263";
                case "h264": return "video/h264";
                case "jpgv": return "video/jpeg";
                case "jpm": return "video/jpm";
                case "jpgm": return "video/jpm";
                case "mj2": return "video/mj2";
                case "mjp2": return "video/mj2";
                case "mp4": return "video/mp4";
                case "mp4v": return "video/mp4";
                case "mpg4": return "video/mp4";
                case "mpeg": return "video/mpeg";
                case "mpg": return "video/mpeg";
                case "mpe": return "video/mpeg";
                case "m1v": return "video/mpeg";
                case "m2v": return "video/mpeg";
                case "ogv": return "video/ogg";
                case "qt": return "video/quicktime";
                case "mov": return "video/quicktime";
                case "uvh": return "video/vnd.dece.hd";
                case "uvvh": return "video/vnd.dece.hd";
                case "uvm": return "video/vnd.dece.mobile";
                case "uvvm": return "video/vnd.dece.mobile";
                case "uvp": return "video/vnd.dece.pd";
                case "uvvp": return "video/vnd.dece.pd";
                case "uvs": return "video/vnd.dece.sd";
                case "uvvs": return "video/vnd.dece.sd";
                case "uvv": return "video/vnd.dece.video";
                case "uvvv": return "video/vnd.dece.video";
                case "dvb": return "video/vnd.dvb.file";
                case "fvt": return "video/vnd.fvt";
                case "mxu": return "video/vnd.mpegurl";
                case "m4u": return "video/vnd.mpegurl";
                case "pyv": return "video/vnd.ms-playready.media.pyv";
                case "uvu": return "video/vnd.uvvu.mp4";
                case "uvvu": return "video/vnd.uvvu.mp4";
                case "viv": return "video/vnd.vivo";
                case "webm": return "video/webm";
                case "f4v": return "video/x-f4v";
                case "fli": return "video/x-fli";
                case "flv": return "video/x-flv";
                case "m4v": return "video/x-m4v";
                case "mkv": return "video/x-matroska";
                case "mk3d": return "video/x-matroska";
                case "mks": return "video/x-matroska";
                case "mng": return "video/x-mng";
                case "asf": return "video/x-ms-asf";
                case "asx": return "video/x-ms-asf";
                case "vob": return "video/x-ms-vob";
                case "wm": return "video/x-ms-wm";
                case "wmv": return "video/x-ms-wmv";
                case "wmx": return "video/x-ms-wmx";
                case "wvx": return "video/x-ms-wvx";
                case "avi": return "video/x-msvideo";
                case "movie": return "video/x-sgi-movie";
                case "smv": return "video/x-smv";
                case "ice": return "x-conference/x-cooltalk";
                case "map": return "application/json";
                case "topojson": return "application/json";
                case "jsonld": return "application/ld+json";
                case "geojson": return "application/vnd.geo+json";
                case "webmanifest": return "application/manifest+json";
                case "webapp": return "application/x-web-app-manifest+json";
                case "f4a": return "audio/mp4";
                case "f4b": return "audio/mp4";
                case "opus": return "audio/ogg";
                case "jng": return "image/x-jng";
                case "3gpp": return "video/3gpp";
                case "f4p": return "video/mp4";
                case "cur": return "image/x-icon";
                case "woff2": return "application/font-woff2";
                case "ear": return "application/java-archive";
                case "war": return "application/java-archive";
                case "img": return "application/octet-stream";
                case "msm": return "application/octet-stream";
                case "msp": return "application/octet-stream";
                case "safariextz": return "application/octet-stream";
                case "bbaw": return "application/x-bb-appworld";
                case "crx": return "application/x-chrome-extension";
                case "cco": return "application/x-cocoa";
                case "jardiff": return "application/x-java-archive-diff";
                case "run": return "application/x-makeself";
                case "oex": return "application/x-opera-extension";
                case "pl": return "application/x-perl";
                case "pm": return "application/x-perl";
                case "rpm": return "application/x-redhat-package-manager";
                case "sea": return "application/x-sea";
                case "tk": return "application/x-tcl";
                case "pem": return "application/x-x509-ca-cert";
                case "shtml": return "text/html";
                case "mml": return "text/mathml";
                case "xloc": return "text/vnd.rim.location.xloc";
                case "vtt": return "text/vtt";
                case "htc": return "text/x-component";
                default: return null;
            }
        }
    }
}