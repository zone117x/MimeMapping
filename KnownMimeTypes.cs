using System;

namespace MimeMapping
{
	///<summary>
	/// MIME type constants. Last updated on 2020-12-31T11:02:33Z. 
	/// Generated from the <a href="http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types">apache</a> and <a href="https://raw.githubusercontent.com/h5bp/server-configs-nginx/master/mime.types">nginx</a> sources
	///</summary>
    public static class KnownMimeTypes
    {

        // Dupe for wmz: using application/x-ms-wmz vs application/x-msmetafile 
        // Dupe for sub: using image/vnd.dvb.subtitle vs text/vnd.dvb.subtitle 
        // Dupe for js: using application/javascript vs text/javascript 
        // Dupe for aac: using audio/x-aac vs audio/mp4 
        // Dupe for ra: using audio/x-pn-realaudio vs audio/x-realaudio 
        // Dupe for wdp: using image/vnd.ms-photo vs image/jxr 
        // Dupe for f4v: using video/x-f4v vs video/mp4 
        // Dupe for m4v: using video/x-m4v vs video/mp4 
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
        // Dupe for mjs: using text/javascript vs application/javascript 
        // Dupe for bdoc: using application/bdoc vs application/x-bdoc 
        // Dupe for exe: using application/x-msdownload vs application/x-msdos-program 
        // Dupe for 3gpp: using video/3gpp vs audio/3gpp 
        // Dupe for mp3: using audio/mpeg vs audio/mp3 
        // Dupe for wav: using audio/x-wav vs audio/wav 
        // Dupe for wav: using audio/x-wav vs audio/wave 
        // Dupe for jpm: using video/jpm vs image/jpm 
        // Dupe for rtf: using application/rtf vs text/rtf 
        // Dupe for org: using application/vnd.lotus-organizer vs text/x-org 

		// Generated 839 unique mime type values
        // Generated 1091 type key pairs

		///<summary>ez</summary>
        public const string Ez = "application/andrew-inset";
		///<summary>aw</summary>
        public const string Aw = "application/applixware";
		///<summary>atom</summary>
        public const string Atom = "application/atom+xml";
		///<summary>atomcat</summary>
        public const string Atomcat = "application/atomcat+xml";
		///<summary>atomsvc</summary>
        public const string Atomsvc = "application/atomsvc+xml";
		///<summary>ccxml</summary>
        public const string Ccxml = "application/ccxml+xml";
		///<summary>cdmia</summary>
        public const string Cdmia = "application/cdmi-capability";
		///<summary>cdmic</summary>
        public const string Cdmic = "application/cdmi-container";
		///<summary>cdmid</summary>
        public const string Cdmid = "application/cdmi-domain";
		///<summary>cdmio</summary>
        public const string Cdmio = "application/cdmi-object";
		///<summary>cdmiq</summary>
        public const string Cdmiq = "application/cdmi-queue";
		///<summary>cu</summary>
        public const string Cu = "application/cu-seeme";
		///<summary>davmount</summary>
        public const string Davmount = "application/davmount+xml";
		///<summary>dbk</summary>
        public const string Dbk = "application/docbook+xml";
		///<summary>dssc</summary>
        public const string Dssc = "application/dssc+der";
		///<summary>xdssc</summary>
        public const string Xdssc = "application/dssc+xml";
		///<summary>ecma</summary>
        public const string Ecma = "application/ecmascript";
		///<summary>emma</summary>
        public const string Emma = "application/emma+xml";
		///<summary>epub</summary>
        public const string Epub = "application/epub+zip";
		///<summary>exi</summary>
        public const string Exi = "application/exi";
		///<summary>pfr</summary>
        public const string Pfr = "application/font-tdpfr";
		///<summary>gml</summary>
        public const string Gml = "application/gml+xml";
		///<summary>gpx</summary>
        public const string Gpx = "application/gpx+xml";
		///<summary>gxf</summary>
        public const string Gxf = "application/gxf";
		///<summary>stk</summary>
        public const string Stk = "application/hyperstudio";
		///<summary>ink</summary>
        public const string Ink = "application/inkml+xml";
		///<summary>inkml</summary>
        public const string Inkml = "application/inkml+xml";
		///<summary>ipfix</summary>
        public const string Ipfix = "application/ipfix";
		///<summary>jar</summary>
        public const string Jar = "application/java-archive";
		///<summary>ser</summary>
        public const string Ser = "application/java-serialized-object";
		///<summary>class</summary>
        public const string Class = "application/java-vm";
		///<summary>js</summary>
        public const string Js = "application/javascript";
		///<summary>json</summary>
        public const string Json = "application/json";
		///<summary>jsonml</summary>
        public const string Jsonml = "application/jsonml+json";
		///<summary>lostxml</summary>
        public const string Lostxml = "application/lost+xml";
		///<summary>hqx</summary>
        public const string Hqx = "application/mac-binhex40";
		///<summary>cpt</summary>
        public const string Cpt = "application/mac-compactpro";
		///<summary>mads</summary>
        public const string Mads = "application/mads+xml";
		///<summary>mrc</summary>
        public const string Mrc = "application/marc";
		///<summary>mrcx</summary>
        public const string Mrcx = "application/marcxml+xml";
		///<summary>ma</summary>
        public const string Ma = "application/mathematica";
		///<summary>nb</summary>
        public const string Nb = "application/mathematica";
		///<summary>mb</summary>
        public const string Mb = "application/mathematica";
		///<summary>mathml</summary>
        public const string Mathml = "application/mathml+xml";
		///<summary>mbox</summary>
        public const string Mbox = "application/mbox";
		///<summary>mscml</summary>
        public const string Mscml = "application/mediaservercontrol+xml";
		///<summary>metalink</summary>
        public const string Metalink = "application/metalink+xml";
		///<summary>meta4</summary>
        public const string Meta4 = "application/metalink4+xml";
		///<summary>mets</summary>
        public const string Mets = "application/mets+xml";
		///<summary>mods</summary>
        public const string Mods = "application/mods+xml";
		///<summary>m21</summary>
        public const string M21 = "application/mp21";
		///<summary>mp21</summary>
        public const string Mp21 = "application/mp21";
		///<summary>mp4s</summary>
        public const string Mp4s = "application/mp4";
		///<summary>doc</summary>
        public const string Doc = "application/msword";
		///<summary>dot</summary>
        public const string Dot = "application/msword";
		///<summary>mxf</summary>
        public const string Mxf = "application/mxf";
		///<summary>bin</summary>
        public const string Bin = "application/octet-stream";
		///<summary>dms</summary>
        public const string Dms = "application/octet-stream";
		///<summary>lrf</summary>
        public const string Lrf = "application/octet-stream";
		///<summary>mar</summary>
        public const string Mar = "application/octet-stream";
		///<summary>so</summary>
        public const string So = "application/octet-stream";
		///<summary>dist</summary>
        public const string Dist = "application/octet-stream";
		///<summary>distz</summary>
        public const string Distz = "application/octet-stream";
		///<summary>pkg</summary>
        public const string Pkg = "application/octet-stream";
		///<summary>bpk</summary>
        public const string Bpk = "application/octet-stream";
		///<summary>dump</summary>
        public const string Dump = "application/octet-stream";
		///<summary>elc</summary>
        public const string Elc = "application/octet-stream";
		///<summary>deploy</summary>
        public const string Deploy = "application/octet-stream";
		///<summary>oda</summary>
        public const string Oda = "application/oda";
		///<summary>opf</summary>
        public const string Opf = "application/oebps-package+xml";
		///<summary>ogx</summary>
        public const string Ogx = "application/ogg";
		///<summary>omdoc</summary>
        public const string Omdoc = "application/omdoc+xml";
		///<summary>onetoc</summary>
        public const string Onetoc = "application/onenote";
		///<summary>onetoc2</summary>
        public const string Onetoc2 = "application/onenote";
		///<summary>onetmp</summary>
        public const string Onetmp = "application/onenote";
		///<summary>onepkg</summary>
        public const string Onepkg = "application/onenote";
		///<summary>oxps</summary>
        public const string Oxps = "application/oxps";
		///<summary>xer</summary>
        public const string Xer = "application/patch-ops-error+xml";
		///<summary>pdf</summary>
        public const string Pdf = "application/pdf";
		///<summary>pgp</summary>
        public const string Pgp = "application/pgp-encrypted";
		///<summary>asc</summary>
        public const string Asc = "application/pgp-signature";
		///<summary>sig</summary>
        public const string Sig = "application/pgp-signature";
		///<summary>prf</summary>
        public const string Prf = "application/pics-rules";
		///<summary>p10</summary>
        public const string P10 = "application/pkcs10";
		///<summary>p7m</summary>
        public const string P7m = "application/pkcs7-mime";
		///<summary>p7c</summary>
        public const string P7c = "application/pkcs7-mime";
		///<summary>p7s</summary>
        public const string P7s = "application/pkcs7-signature";
		///<summary>p8</summary>
        public const string P8 = "application/pkcs8";
		///<summary>ac</summary>
        public const string Ac = "application/pkix-attr-cert";
		///<summary>cer</summary>
        public const string Cer = "application/pkix-cert";
		///<summary>crl</summary>
        public const string Crl = "application/pkix-crl";
		///<summary>pkipath</summary>
        public const string Pkipath = "application/pkix-pkipath";
		///<summary>pki</summary>
        public const string Pki = "application/pkixcmp";
		///<summary>pls</summary>
        public const string Pls = "application/pls+xml";
		///<summary>ai</summary>
        public const string Ai = "application/postscript";
		///<summary>eps</summary>
        public const string Eps = "application/postscript";
		///<summary>ps</summary>
        public const string Ps = "application/postscript";
		///<summary>cww</summary>
        public const string Cww = "application/prs.cww";
		///<summary>pskcxml</summary>
        public const string Pskcxml = "application/pskc+xml";
		///<summary>rdf</summary>
        public const string Rdf = "application/rdf+xml";
		///<summary>rif</summary>
        public const string Rif = "application/reginfo+xml";
		///<summary>rnc</summary>
        public const string Rnc = "application/relax-ng-compact-syntax";
		///<summary>rl</summary>
        public const string Rl = "application/resource-lists+xml";
		///<summary>rld</summary>
        public const string Rld = "application/resource-lists-diff+xml";
		///<summary>rs</summary>
        public const string Rs = "application/rls-services+xml";
		///<summary>gbr</summary>
        public const string Gbr = "application/rpki-ghostbusters";
		///<summary>mft</summary>
        public const string Mft = "application/rpki-manifest";
		///<summary>roa</summary>
        public const string Roa = "application/rpki-roa";
		///<summary>rsd</summary>
        public const string Rsd = "application/rsd+xml";
		///<summary>rss</summary>
        public const string Rss = "application/rss+xml";
		///<summary>rtf</summary>
        public const string Rtf = "application/rtf";
		///<summary>sbml</summary>
        public const string Sbml = "application/sbml+xml";
		///<summary>scq</summary>
        public const string Scq = "application/scvp-cv-request";
		///<summary>scs</summary>
        public const string Scs = "application/scvp-cv-response";
		///<summary>spq</summary>
        public const string Spq = "application/scvp-vp-request";
		///<summary>spp</summary>
        public const string Spp = "application/scvp-vp-response";
		///<summary>sdp</summary>
        public const string Sdp = "application/sdp";
		///<summary>setpay</summary>
        public const string Setpay = "application/set-payment-initiation";
		///<summary>setreg</summary>
        public const string Setreg = "application/set-registration-initiation";
		///<summary>shf</summary>
        public const string Shf = "application/shf+xml";
		///<summary>smi</summary>
        public const string Smi = "application/smil+xml";
		///<summary>smil</summary>
        public const string Smil = "application/smil+xml";
		///<summary>rq</summary>
        public const string Rq = "application/sparql-query";
		///<summary>srx</summary>
        public const string Srx = "application/sparql-results+xml";
		///<summary>gram</summary>
        public const string Gram = "application/srgs";
		///<summary>grxml</summary>
        public const string Grxml = "application/srgs+xml";
		///<summary>sru</summary>
        public const string Sru = "application/sru+xml";
		///<summary>ssdl</summary>
        public const string Ssdl = "application/ssdl+xml";
		///<summary>ssml</summary>
        public const string Ssml = "application/ssml+xml";
		///<summary>tei</summary>
        public const string Tei = "application/tei+xml";
		///<summary>teicorpus</summary>
        public const string Teicorpus = "application/tei+xml";
		///<summary>tfi</summary>
        public const string Tfi = "application/thraud+xml";
		///<summary>tsd</summary>
        public const string Tsd = "application/timestamped-data";
		///<summary>plb</summary>
        public const string Plb = "application/vnd.3gpp.pic-bw-large";
		///<summary>psb</summary>
        public const string Psb = "application/vnd.3gpp.pic-bw-small";
		///<summary>pvb</summary>
        public const string Pvb = "application/vnd.3gpp.pic-bw-var";
		///<summary>tcap</summary>
        public const string Tcap = "application/vnd.3gpp2.tcap";
		///<summary>pwn</summary>
        public const string Pwn = "application/vnd.3m.post-it-notes";
		///<summary>aso</summary>
        public const string Aso = "application/vnd.accpac.simply.aso";
		///<summary>imp</summary>
        public const string Imp = "application/vnd.accpac.simply.imp";
		///<summary>acu</summary>
        public const string Acu = "application/vnd.acucobol";
		///<summary>atc</summary>
        public const string Atc = "application/vnd.acucorp";
		///<summary>acutc</summary>
        public const string Acutc = "application/vnd.acucorp";
		///<summary>air</summary>
        public const string Air = "application/vnd.adobe.air-application-installer-package+zip";
		///<summary>fcdt</summary>
        public const string Fcdt = "application/vnd.adobe.formscentral.fcdt";
		///<summary>fxp</summary>
        public const string Fxp = "application/vnd.adobe.fxp";
		///<summary>fxpl</summary>
        public const string Fxpl = "application/vnd.adobe.fxp";
		///<summary>xdp</summary>
        public const string Xdp = "application/vnd.adobe.xdp+xml";
		///<summary>xfdf</summary>
        public const string Xfdf = "application/vnd.adobe.xfdf";
		///<summary>ahead</summary>
        public const string Ahead = "application/vnd.ahead.space";
		///<summary>azf</summary>
        public const string Azf = "application/vnd.airzip.filesecure.azf";
		///<summary>azs</summary>
        public const string Azs = "application/vnd.airzip.filesecure.azs";
		///<summary>azw</summary>
        public const string Azw = "application/vnd.amazon.ebook";
		///<summary>acc</summary>
        public const string Acc = "application/vnd.americandynamics.acc";
		///<summary>ami</summary>
        public const string Ami = "application/vnd.amiga.ami";
		///<summary>apk</summary>
        public const string Apk = "application/vnd.android.package-archive";
		///<summary>cii</summary>
        public const string Cii = "application/vnd.anser-web-certificate-issue-initiation";
		///<summary>fti</summary>
        public const string Fti = "application/vnd.anser-web-funds-transfer-initiation";
		///<summary>atx</summary>
        public const string Atx = "application/vnd.antix.game-component";
		///<summary>mpkg</summary>
        public const string Mpkg = "application/vnd.apple.installer+xml";
		///<summary>m3u8</summary>
        public const string M3u8 = "application/vnd.apple.mpegurl";
		///<summary>swi</summary>
        public const string Swi = "application/vnd.aristanetworks.swi";
		///<summary>iota</summary>
        public const string Iota = "application/vnd.astraea-software.iota";
		///<summary>aep</summary>
        public const string Aep = "application/vnd.audiograph";
		///<summary>mpm</summary>
        public const string Mpm = "application/vnd.blueice.multipass";
		///<summary>bmi</summary>
        public const string Bmi = "application/vnd.bmi";
		///<summary>rep</summary>
        public const string Rep = "application/vnd.businessobjects";
		///<summary>cdxml</summary>
        public const string Cdxml = "application/vnd.chemdraw+xml";
		///<summary>mmd</summary>
        public const string Mmd = "application/vnd.chipnuts.karaoke-mmd";
		///<summary>cdy</summary>
        public const string Cdy = "application/vnd.cinderella";
		///<summary>cla</summary>
        public const string Cla = "application/vnd.claymore";
		///<summary>rp9</summary>
        public const string Rp9 = "application/vnd.cloanto.rp9";
		///<summary>c4g</summary>
        public const string C4g = "application/vnd.clonk.c4group";
		///<summary>c4d</summary>
        public const string C4d = "application/vnd.clonk.c4group";
		///<summary>c4f</summary>
        public const string C4f = "application/vnd.clonk.c4group";
		///<summary>c4p</summary>
        public const string C4p = "application/vnd.clonk.c4group";
		///<summary>c4u</summary>
        public const string C4u = "application/vnd.clonk.c4group";
		///<summary>c11amc</summary>
        public const string C11amc = "application/vnd.cluetrust.cartomobile-config";
		///<summary>c11amz</summary>
        public const string C11amz = "application/vnd.cluetrust.cartomobile-config-pkg";
		///<summary>csp</summary>
        public const string Csp = "application/vnd.commonspace";
		///<summary>cdbcmsg</summary>
        public const string Cdbcmsg = "application/vnd.contact.cmsg";
		///<summary>cmc</summary>
        public const string Cmc = "application/vnd.cosmocaller";
		///<summary>clkx</summary>
        public const string Clkx = "application/vnd.crick.clicker";
		///<summary>clkk</summary>
        public const string Clkk = "application/vnd.crick.clicker.keyboard";
		///<summary>clkp</summary>
        public const string Clkp = "application/vnd.crick.clicker.palette";
		///<summary>clkt</summary>
        public const string Clkt = "application/vnd.crick.clicker.template";
		///<summary>clkw</summary>
        public const string Clkw = "application/vnd.crick.clicker.wordbank";
		///<summary>wbs</summary>
        public const string Wbs = "application/vnd.criticaltools.wbs+xml";
		///<summary>pml</summary>
        public const string Pml = "application/vnd.ctc-posml";
		///<summary>ppd</summary>
        public const string Ppd = "application/vnd.cups-ppd";
		///<summary>car</summary>
        public const string Car = "application/vnd.curl.car";
		///<summary>pcurl</summary>
        public const string Pcurl = "application/vnd.curl.pcurl";
		///<summary>dart</summary>
        public const string Dart = "application/vnd.dart";
		///<summary>rdz</summary>
        public const string Rdz = "application/vnd.data-vision.rdz";
		///<summary>uvf</summary>
        public const string Uvf = "application/vnd.dece.data";
		///<summary>uvvf</summary>
        public const string Uvvf = "application/vnd.dece.data";
		///<summary>uvd</summary>
        public const string Uvd = "application/vnd.dece.data";
		///<summary>uvvd</summary>
        public const string Uvvd = "application/vnd.dece.data";
		///<summary>uvt</summary>
        public const string Uvt = "application/vnd.dece.ttml+xml";
		///<summary>uvvt</summary>
        public const string Uvvt = "application/vnd.dece.ttml+xml";
		///<summary>uvx</summary>
        public const string Uvx = "application/vnd.dece.unspecified";
		///<summary>uvvx</summary>
        public const string Uvvx = "application/vnd.dece.unspecified";
		///<summary>uvz</summary>
        public const string Uvz = "application/vnd.dece.zip";
		///<summary>uvvz</summary>
        public const string Uvvz = "application/vnd.dece.zip";
		///<summary>fe_launch</summary>
        public const string Felaunch = "application/vnd.denovo.fcselayout-link";
		///<summary>dna</summary>
        public const string Dna = "application/vnd.dna";
		///<summary>mlp</summary>
        public const string Mlp = "application/vnd.dolby.mlp";
		///<summary>dpg</summary>
        public const string Dpg = "application/vnd.dpgraph";
		///<summary>dfac</summary>
        public const string Dfac = "application/vnd.dreamfactory";
		///<summary>kpxx</summary>
        public const string Kpxx = "application/vnd.ds-keypoint";
		///<summary>ait</summary>
        public const string Ait = "application/vnd.dvb.ait";
		///<summary>svc</summary>
        public const string Svc = "application/vnd.dvb.service";
		///<summary>geo</summary>
        public const string Geo = "application/vnd.dynageo";
		///<summary>mag</summary>
        public const string Mag = "application/vnd.ecowin.chart";
		///<summary>nml</summary>
        public const string Nml = "application/vnd.enliven";
		///<summary>esf</summary>
        public const string Esf = "application/vnd.epson.esf";
		///<summary>msf</summary>
        public const string Msf = "application/vnd.epson.msf";
		///<summary>qam</summary>
        public const string Qam = "application/vnd.epson.quickanime";
		///<summary>slt</summary>
        public const string Slt = "application/vnd.epson.salt";
		///<summary>ssf</summary>
        public const string Ssf = "application/vnd.epson.ssf";
		///<summary>es3</summary>
        public const string Es3 = "application/vnd.eszigno3+xml";
		///<summary>et3</summary>
        public const string Et3 = "application/vnd.eszigno3+xml";
		///<summary>ez2</summary>
        public const string Ez2 = "application/vnd.ezpix-album";
		///<summary>ez3</summary>
        public const string Ez3 = "application/vnd.ezpix-package";
		///<summary>fdf</summary>
        public const string Fdf = "application/vnd.fdf";
		///<summary>mseed</summary>
        public const string Mseed = "application/vnd.fdsn.mseed";
		///<summary>seed</summary>
        public const string Seed = "application/vnd.fdsn.seed";
		///<summary>dataless</summary>
        public const string Dataless = "application/vnd.fdsn.seed";
		///<summary>gph</summary>
        public const string Gph = "application/vnd.flographit";
		///<summary>ftc</summary>
        public const string Ftc = "application/vnd.fluxtime.clip";
		///<summary>fm</summary>
        public const string Fm = "application/vnd.framemaker";
		///<summary>frame</summary>
        public const string Frame = "application/vnd.framemaker";
		///<summary>maker</summary>
        public const string Maker = "application/vnd.framemaker";
		///<summary>book</summary>
        public const string Book = "application/vnd.framemaker";
		///<summary>fnc</summary>
        public const string Fnc = "application/vnd.frogans.fnc";
		///<summary>ltf</summary>
        public const string Ltf = "application/vnd.frogans.ltf";
		///<summary>fsc</summary>
        public const string Fsc = "application/vnd.fsc.weblaunch";
		///<summary>oas</summary>
        public const string Oas = "application/vnd.fujitsu.oasys";
		///<summary>oa2</summary>
        public const string Oa2 = "application/vnd.fujitsu.oasys2";
		///<summary>oa3</summary>
        public const string Oa3 = "application/vnd.fujitsu.oasys3";
		///<summary>fg5</summary>
        public const string Fg5 = "application/vnd.fujitsu.oasysgp";
		///<summary>bh2</summary>
        public const string Bh2 = "application/vnd.fujitsu.oasysprs";
		///<summary>ddd</summary>
        public const string Ddd = "application/vnd.fujixerox.ddd";
		///<summary>xdw</summary>
        public const string Xdw = "application/vnd.fujixerox.docuworks";
		///<summary>xbd</summary>
        public const string Xbd = "application/vnd.fujixerox.docuworks.binder";
		///<summary>fzs</summary>
        public const string Fzs = "application/vnd.fuzzysheet";
		///<summary>txd</summary>
        public const string Txd = "application/vnd.genomatix.tuxedo";
		///<summary>ggb</summary>
        public const string Ggb = "application/vnd.geogebra.file";
		///<summary>ggt</summary>
        public const string Ggt = "application/vnd.geogebra.tool";
		///<summary>gex</summary>
        public const string Gex = "application/vnd.geometry-explorer";
		///<summary>gre</summary>
        public const string Gre = "application/vnd.geometry-explorer";
		///<summary>gxt</summary>
        public const string Gxt = "application/vnd.geonext";
		///<summary>g2w</summary>
        public const string G2w = "application/vnd.geoplan";
		///<summary>g3w</summary>
        public const string G3w = "application/vnd.geospace";
		///<summary>gmx</summary>
        public const string Gmx = "application/vnd.gmx";
		///<summary>kml</summary>
        public const string Kml = "application/vnd.google-earth.kml+xml";
		///<summary>kmz</summary>
        public const string Kmz = "application/vnd.google-earth.kmz";
		///<summary>gqf</summary>
        public const string Gqf = "application/vnd.grafeq";
		///<summary>gqs</summary>
        public const string Gqs = "application/vnd.grafeq";
		///<summary>gac</summary>
        public const string Gac = "application/vnd.groove-account";
		///<summary>ghf</summary>
        public const string Ghf = "application/vnd.groove-help";
		///<summary>gim</summary>
        public const string Gim = "application/vnd.groove-identity-message";
		///<summary>grv</summary>
        public const string Grv = "application/vnd.groove-injector";
		///<summary>gtm</summary>
        public const string Gtm = "application/vnd.groove-tool-message";
		///<summary>tpl</summary>
        public const string Tpl = "application/vnd.groove-tool-template";
		///<summary>vcg</summary>
        public const string Vcg = "application/vnd.groove-vcard";
		///<summary>hal</summary>
        public const string Hal = "application/vnd.hal+xml";
		///<summary>zmm</summary>
        public const string Zmm = "application/vnd.handheld-entertainment+xml";
		///<summary>hbci</summary>
        public const string Hbci = "application/vnd.hbci";
		///<summary>les</summary>
        public const string Les = "application/vnd.hhe.lesson-player";
		///<summary>hpgl</summary>
        public const string Hpgl = "application/vnd.hp-hpgl";
		///<summary>hpid</summary>
        public const string Hpid = "application/vnd.hp-hpid";
		///<summary>hps</summary>
        public const string Hps = "application/vnd.hp-hps";
		///<summary>jlt</summary>
        public const string Jlt = "application/vnd.hp-jlyt";
		///<summary>pcl</summary>
        public const string Pcl = "application/vnd.hp-pcl";
		///<summary>pclxl</summary>
        public const string Pclxl = "application/vnd.hp-pclxl";
		///<summary>sfd-hdstx</summary>
        public const string Sfdhdstx = "application/vnd.hydrostatix.sof-data";
		///<summary>mpy</summary>
        public const string Mpy = "application/vnd.ibm.minipay";
		///<summary>afp</summary>
        public const string Afp = "application/vnd.ibm.modcap";
		///<summary>listafp</summary>
        public const string Listafp = "application/vnd.ibm.modcap";
		///<summary>list3820</summary>
        public const string List3820 = "application/vnd.ibm.modcap";
		///<summary>irm</summary>
        public const string Irm = "application/vnd.ibm.rights-management";
		///<summary>sc</summary>
        public const string Sc = "application/vnd.ibm.secure-container";
		///<summary>icc</summary>
        public const string Icc = "application/vnd.iccprofile";
		///<summary>icm</summary>
        public const string Icm = "application/vnd.iccprofile";
		///<summary>igl</summary>
        public const string Igl = "application/vnd.igloader";
		///<summary>ivp</summary>
        public const string Ivp = "application/vnd.immervision-ivp";
		///<summary>ivu</summary>
        public const string Ivu = "application/vnd.immervision-ivu";
		///<summary>igm</summary>
        public const string Igm = "application/vnd.insors.igm";
		///<summary>xpw</summary>
        public const string Xpw = "application/vnd.intercon.formnet";
		///<summary>xpx</summary>
        public const string Xpx = "application/vnd.intercon.formnet";
		///<summary>i2g</summary>
        public const string I2g = "application/vnd.intergeo";
		///<summary>qbo</summary>
        public const string Qbo = "application/vnd.intu.qbo";
		///<summary>qfx</summary>
        public const string Qfx = "application/vnd.intu.qfx";
		///<summary>rcprofile</summary>
        public const string Rcprofile = "application/vnd.ipunplugged.rcprofile";
		///<summary>irp</summary>
        public const string Irp = "application/vnd.irepository.package+xml";
		///<summary>xpr</summary>
        public const string Xpr = "application/vnd.is-xpr";
		///<summary>fcs</summary>
        public const string Fcs = "application/vnd.isac.fcs";
		///<summary>jam</summary>
        public const string Jam = "application/vnd.jam";
		///<summary>rms</summary>
        public const string Rms = "application/vnd.jcp.javame.midlet-rms";
		///<summary>jisp</summary>
        public const string Jisp = "application/vnd.jisp";
		///<summary>joda</summary>
        public const string Joda = "application/vnd.joost.joda-archive";
		///<summary>ktz</summary>
        public const string Ktz = "application/vnd.kahootz";
		///<summary>ktr</summary>
        public const string Ktr = "application/vnd.kahootz";
		///<summary>karbon</summary>
        public const string Karbon = "application/vnd.kde.karbon";
		///<summary>chrt</summary>
        public const string Chrt = "application/vnd.kde.kchart";
		///<summary>kfo</summary>
        public const string Kfo = "application/vnd.kde.kformula";
		///<summary>flw</summary>
        public const string Flw = "application/vnd.kde.kivio";
		///<summary>kon</summary>
        public const string Kon = "application/vnd.kde.kontour";
		///<summary>kpr</summary>
        public const string Kpr = "application/vnd.kde.kpresenter";
		///<summary>kpt</summary>
        public const string Kpt = "application/vnd.kde.kpresenter";
		///<summary>ksp</summary>
        public const string Ksp = "application/vnd.kde.kspread";
		///<summary>kwd</summary>
        public const string Kwd = "application/vnd.kde.kword";
		///<summary>kwt</summary>
        public const string Kwt = "application/vnd.kde.kword";
		///<summary>htke</summary>
        public const string Htke = "application/vnd.kenameaapp";
		///<summary>kia</summary>
        public const string Kia = "application/vnd.kidspiration";
		///<summary>kne</summary>
        public const string Kne = "application/vnd.kinar";
		///<summary>knp</summary>
        public const string Knp = "application/vnd.kinar";
		///<summary>skp</summary>
        public const string Skp = "application/vnd.koan";
		///<summary>skd</summary>
        public const string Skd = "application/vnd.koan";
		///<summary>skt</summary>
        public const string Skt = "application/vnd.koan";
		///<summary>skm</summary>
        public const string Skm = "application/vnd.koan";
		///<summary>sse</summary>
        public const string Sse = "application/vnd.kodak-descriptor";
		///<summary>lasxml</summary>
        public const string Lasxml = "application/vnd.las.las+xml";
		///<summary>lbd</summary>
        public const string Lbd = "application/vnd.llamagraphics.life-balance.desktop";
		///<summary>lbe</summary>
        public const string Lbe = "application/vnd.llamagraphics.life-balance.exchange+xml";
		///<summary>123</summary>
        public const string _123 = "application/vnd.lotus-1-2-3";
		///<summary>apr</summary>
        public const string Apr = "application/vnd.lotus-approach";
		///<summary>pre</summary>
        public const string Pre = "application/vnd.lotus-freelance";
		///<summary>nsf</summary>
        public const string Nsf = "application/vnd.lotus-notes";
		///<summary>org</summary>
        public const string Org = "application/vnd.lotus-organizer";
		///<summary>scm</summary>
        public const string Scm = "application/vnd.lotus-screencam";
		///<summary>lwp</summary>
        public const string Lwp = "application/vnd.lotus-wordpro";
		///<summary>portpkg</summary>
        public const string Portpkg = "application/vnd.macports.portpkg";
		///<summary>mcd</summary>
        public const string Mcd = "application/vnd.mcd";
		///<summary>mc1</summary>
        public const string Mc1 = "application/vnd.medcalcdata";
		///<summary>cdkey</summary>
        public const string Cdkey = "application/vnd.mediastation.cdkey";
		///<summary>mwf</summary>
        public const string Mwf = "application/vnd.mfer";
		///<summary>mfm</summary>
        public const string Mfm = "application/vnd.mfmp";
		///<summary>flo</summary>
        public const string Flo = "application/vnd.micrografx.flo";
		///<summary>igx</summary>
        public const string Igx = "application/vnd.micrografx.igx";
		///<summary>mif</summary>
        public const string Mif = "application/vnd.mif";
		///<summary>daf</summary>
        public const string Daf = "application/vnd.mobius.daf";
		///<summary>dis</summary>
        public const string Dis = "application/vnd.mobius.dis";
		///<summary>mbk</summary>
        public const string Mbk = "application/vnd.mobius.mbk";
		///<summary>mqy</summary>
        public const string Mqy = "application/vnd.mobius.mqy";
		///<summary>msl</summary>
        public const string Msl = "application/vnd.mobius.msl";
		///<summary>plc</summary>
        public const string Plc = "application/vnd.mobius.plc";
		///<summary>txf</summary>
        public const string Txf = "application/vnd.mobius.txf";
		///<summary>mpn</summary>
        public const string Mpn = "application/vnd.mophun.application";
		///<summary>mpc</summary>
        public const string Mpc = "application/vnd.mophun.certificate";
		///<summary>xul</summary>
        public const string Xul = "application/vnd.mozilla.xul+xml";
		///<summary>cil</summary>
        public const string Cil = "application/vnd.ms-artgalry";
		///<summary>cab</summary>
        public const string Cab = "application/vnd.ms-cab-compressed";
		///<summary>xls</summary>
        public const string Xls = "application/vnd.ms-excel";
		///<summary>xlm</summary>
        public const string Xlm = "application/vnd.ms-excel";
		///<summary>xla</summary>
        public const string Xla = "application/vnd.ms-excel";
		///<summary>xlc</summary>
        public const string Xlc = "application/vnd.ms-excel";
		///<summary>xlt</summary>
        public const string Xlt = "application/vnd.ms-excel";
		///<summary>xlw</summary>
        public const string Xlw = "application/vnd.ms-excel";
		///<summary>xlam</summary>
        public const string Xlam = "application/vnd.ms-excel.addin.macroenabled.12";
		///<summary>xlsb</summary>
        public const string Xlsb = "application/vnd.ms-excel.sheet.binary.macroenabled.12";
		///<summary>xlsm</summary>
        public const string Xlsm = "application/vnd.ms-excel.sheet.macroenabled.12";
		///<summary>xltm</summary>
        public const string Xltm = "application/vnd.ms-excel.template.macroenabled.12";
		///<summary>eot</summary>
        public const string Eot = "application/vnd.ms-fontobject";
		///<summary>chm</summary>
        public const string Chm = "application/vnd.ms-htmlhelp";
		///<summary>ims</summary>
        public const string Ims = "application/vnd.ms-ims";
		///<summary>lrm</summary>
        public const string Lrm = "application/vnd.ms-lrm";
		///<summary>thmx</summary>
        public const string Thmx = "application/vnd.ms-officetheme";
		///<summary>cat</summary>
        public const string Cat = "application/vnd.ms-pki.seccat";
		///<summary>stl</summary>
        public const string Stl = "application/vnd.ms-pki.stl";
		///<summary>ppt</summary>
        public const string Ppt = "application/vnd.ms-powerpoint";
		///<summary>pps</summary>
        public const string Pps = "application/vnd.ms-powerpoint";
		///<summary>pot</summary>
        public const string Pot = "application/vnd.ms-powerpoint";
		///<summary>ppam</summary>
        public const string Ppam = "application/vnd.ms-powerpoint.addin.macroenabled.12";
		///<summary>pptm</summary>
        public const string Pptm = "application/vnd.ms-powerpoint.presentation.macroenabled.12";
		///<summary>sldm</summary>
        public const string Sldm = "application/vnd.ms-powerpoint.slide.macroenabled.12";
		///<summary>ppsm</summary>
        public const string Ppsm = "application/vnd.ms-powerpoint.slideshow.macroenabled.12";
		///<summary>potm</summary>
        public const string Potm = "application/vnd.ms-powerpoint.template.macroenabled.12";
		///<summary>mpp</summary>
        public const string Mpp = "application/vnd.ms-project";
		///<summary>mpt</summary>
        public const string Mpt = "application/vnd.ms-project";
		///<summary>docm</summary>
        public const string Docm = "application/vnd.ms-word.document.macroenabled.12";
		///<summary>dotm</summary>
        public const string Dotm = "application/vnd.ms-word.template.macroenabled.12";
		///<summary>wps</summary>
        public const string Wps = "application/vnd.ms-works";
		///<summary>wks</summary>
        public const string Wks = "application/vnd.ms-works";
		///<summary>wcm</summary>
        public const string Wcm = "application/vnd.ms-works";
		///<summary>wdb</summary>
        public const string Wdb = "application/vnd.ms-works";
		///<summary>wpl</summary>
        public const string Wpl = "application/vnd.ms-wpl";
		///<summary>xps</summary>
        public const string Xps = "application/vnd.ms-xpsdocument";
		///<summary>mseq</summary>
        public const string Mseq = "application/vnd.mseq";
		///<summary>mus</summary>
        public const string Mus = "application/vnd.musician";
		///<summary>msty</summary>
        public const string Msty = "application/vnd.muvee.style";
		///<summary>taglet</summary>
        public const string Taglet = "application/vnd.mynfc";
		///<summary>nlu</summary>
        public const string Nlu = "application/vnd.neurolanguage.nlu";
		///<summary>ntf</summary>
        public const string Ntf = "application/vnd.nitf";
		///<summary>nitf</summary>
        public const string Nitf = "application/vnd.nitf";
		///<summary>nnd</summary>
        public const string Nnd = "application/vnd.noblenet-directory";
		///<summary>nns</summary>
        public const string Nns = "application/vnd.noblenet-sealer";
		///<summary>nnw</summary>
        public const string Nnw = "application/vnd.noblenet-web";
		///<summary>ngdat</summary>
        public const string Ngdat = "application/vnd.nokia.n-gage.data";
		///<summary>n-gage</summary>
        public const string Ngage = "application/vnd.nokia.n-gage.symbian.install";
		///<summary>rpst</summary>
        public const string Rpst = "application/vnd.nokia.radio-preset";
		///<summary>rpss</summary>
        public const string Rpss = "application/vnd.nokia.radio-presets";
		///<summary>edm</summary>
        public const string Edm = "application/vnd.novadigm.edm";
		///<summary>edx</summary>
        public const string Edx = "application/vnd.novadigm.edx";
		///<summary>ext</summary>
        public const string Ext = "application/vnd.novadigm.ext";
		///<summary>odc</summary>
        public const string Odc = "application/vnd.oasis.opendocument.chart";
		///<summary>otc</summary>
        public const string Otc = "application/vnd.oasis.opendocument.chart-template";
		///<summary>odb</summary>
        public const string Odb = "application/vnd.oasis.opendocument.database";
		///<summary>odf</summary>
        public const string Odf = "application/vnd.oasis.opendocument.formula";
		///<summary>odft</summary>
        public const string Odft = "application/vnd.oasis.opendocument.formula-template";
		///<summary>odg</summary>
        public const string Odg = "application/vnd.oasis.opendocument.graphics";
		///<summary>otg</summary>
        public const string Otg = "application/vnd.oasis.opendocument.graphics-template";
		///<summary>odi</summary>
        public const string Odi = "application/vnd.oasis.opendocument.image";
		///<summary>oti</summary>
        public const string Oti = "application/vnd.oasis.opendocument.image-template";
		///<summary>odp</summary>
        public const string Odp = "application/vnd.oasis.opendocument.presentation";
		///<summary>otp</summary>
        public const string Otp = "application/vnd.oasis.opendocument.presentation-template";
		///<summary>ods</summary>
        public const string Ods = "application/vnd.oasis.opendocument.spreadsheet";
		///<summary>ots</summary>
        public const string Ots = "application/vnd.oasis.opendocument.spreadsheet-template";
		///<summary>odt</summary>
        public const string Odt = "application/vnd.oasis.opendocument.text";
		///<summary>odm</summary>
        public const string Odm = "application/vnd.oasis.opendocument.text-master";
		///<summary>ott</summary>
        public const string Ott = "application/vnd.oasis.opendocument.text-template";
		///<summary>oth</summary>
        public const string Oth = "application/vnd.oasis.opendocument.text-web";
		///<summary>xo</summary>
        public const string Xo = "application/vnd.olpc-sugar";
		///<summary>dd2</summary>
        public const string Dd2 = "application/vnd.oma.dd2+xml";
		///<summary>oxt</summary>
        public const string Oxt = "application/vnd.openofficeorg.extension";
		///<summary>pptx</summary>
        public const string Pptx = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
		///<summary>sldx</summary>
        public const string Sldx = "application/vnd.openxmlformats-officedocument.presentationml.slide";
		///<summary>ppsx</summary>
        public const string Ppsx = "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
		///<summary>potx</summary>
        public const string Potx = "application/vnd.openxmlformats-officedocument.presentationml.template";
		///<summary>xlsx</summary>
        public const string Xlsx = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
		///<summary>xltx</summary>
        public const string Xltx = "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
		///<summary>docx</summary>
        public const string Docx = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
		///<summary>dotx</summary>
        public const string Dotx = "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
		///<summary>mgp</summary>
        public const string Mgp = "application/vnd.osgeo.mapguide.package";
		///<summary>dp</summary>
        public const string Dp = "application/vnd.osgi.dp";
		///<summary>esa</summary>
        public const string Esa = "application/vnd.osgi.subsystem";
		///<summary>pdb</summary>
        public const string Pdb = "application/vnd.palm";
		///<summary>pqa</summary>
        public const string Pqa = "application/vnd.palm";
		///<summary>oprc</summary>
        public const string Oprc = "application/vnd.palm";
		///<summary>paw</summary>
        public const string Paw = "application/vnd.pawaafile";
		///<summary>str</summary>
        public const string Str = "application/vnd.pg.format";
		///<summary>ei6</summary>
        public const string Ei6 = "application/vnd.pg.osasli";
		///<summary>efif</summary>
        public const string Efif = "application/vnd.picsel";
		///<summary>wg</summary>
        public const string Wg = "application/vnd.pmi.widget";
		///<summary>plf</summary>
        public const string Plf = "application/vnd.pocketlearn";
		///<summary>pbd</summary>
        public const string Pbd = "application/vnd.powerbuilder6";
		///<summary>box</summary>
        public const string Box = "application/vnd.previewsystems.box";
		///<summary>mgz</summary>
        public const string Mgz = "application/vnd.proteus.magazine";
		///<summary>qps</summary>
        public const string Qps = "application/vnd.publishare-delta-tree";
		///<summary>ptid</summary>
        public const string Ptid = "application/vnd.pvi.ptid1";
		///<summary>qxd</summary>
        public const string Qxd = "application/vnd.quark.quarkxpress";
		///<summary>qxt</summary>
        public const string Qxt = "application/vnd.quark.quarkxpress";
		///<summary>qwd</summary>
        public const string Qwd = "application/vnd.quark.quarkxpress";
		///<summary>qwt</summary>
        public const string Qwt = "application/vnd.quark.quarkxpress";
		///<summary>qxl</summary>
        public const string Qxl = "application/vnd.quark.quarkxpress";
		///<summary>qxb</summary>
        public const string Qxb = "application/vnd.quark.quarkxpress";
		///<summary>bed</summary>
        public const string Bed = "application/vnd.realvnc.bed";
		///<summary>mxl</summary>
        public const string Mxl = "application/vnd.recordare.musicxml";
		///<summary>musicxml</summary>
        public const string Musicxml = "application/vnd.recordare.musicxml+xml";
		///<summary>cryptonote</summary>
        public const string Cryptonote = "application/vnd.rig.cryptonote";
		///<summary>cod</summary>
        public const string Cod = "application/vnd.rim.cod";
		///<summary>rm</summary>
        public const string Rm = "application/vnd.rn-realmedia";
		///<summary>rmvb</summary>
        public const string Rmvb = "application/vnd.rn-realmedia-vbr";
		///<summary>link66</summary>
        public const string Link66 = "application/vnd.route66.link66+xml";
		///<summary>st</summary>
        public const string St = "application/vnd.sailingtracker.track";
		///<summary>see</summary>
        public const string See = "application/vnd.seemail";
		///<summary>sema</summary>
        public const string Sema = "application/vnd.sema";
		///<summary>semd</summary>
        public const string Semd = "application/vnd.semd";
		///<summary>semf</summary>
        public const string Semf = "application/vnd.semf";
		///<summary>ifm</summary>
        public const string Ifm = "application/vnd.shana.informed.formdata";
		///<summary>itp</summary>
        public const string Itp = "application/vnd.shana.informed.formtemplate";
		///<summary>iif</summary>
        public const string Iif = "application/vnd.shana.informed.interchange";
		///<summary>ipk</summary>
        public const string Ipk = "application/vnd.shana.informed.package";
		///<summary>twd</summary>
        public const string Twd = "application/vnd.simtech-mindmapper";
		///<summary>twds</summary>
        public const string Twds = "application/vnd.simtech-mindmapper";
		///<summary>mmf</summary>
        public const string Mmf = "application/vnd.smaf";
		///<summary>teacher</summary>
        public const string Teacher = "application/vnd.smart.teacher";
		///<summary>sdkm</summary>
        public const string Sdkm = "application/vnd.solent.sdkm+xml";
		///<summary>sdkd</summary>
        public const string Sdkd = "application/vnd.solent.sdkm+xml";
		///<summary>dxp</summary>
        public const string Dxp = "application/vnd.spotfire.dxp";
		///<summary>sfs</summary>
        public const string Sfs = "application/vnd.spotfire.sfs";
		///<summary>sdc</summary>
        public const string Sdc = "application/vnd.stardivision.calc";
		///<summary>sda</summary>
        public const string Sda = "application/vnd.stardivision.draw";
		///<summary>sdd</summary>
        public const string Sdd = "application/vnd.stardivision.impress";
		///<summary>smf</summary>
        public const string Smf = "application/vnd.stardivision.math";
		///<summary>sdw</summary>
        public const string Sdw = "application/vnd.stardivision.writer";
		///<summary>vor</summary>
        public const string Vor = "application/vnd.stardivision.writer";
		///<summary>sgl</summary>
        public const string Sgl = "application/vnd.stardivision.writer-global";
		///<summary>smzip</summary>
        public const string Smzip = "application/vnd.stepmania.package";
		///<summary>sm</summary>
        public const string Sm = "application/vnd.stepmania.stepchart";
		///<summary>sxc</summary>
        public const string Sxc = "application/vnd.sun.xml.calc";
		///<summary>stc</summary>
        public const string Stc = "application/vnd.sun.xml.calc.template";
		///<summary>sxd</summary>
        public const string Sxd = "application/vnd.sun.xml.draw";
		///<summary>std</summary>
        public const string Std = "application/vnd.sun.xml.draw.template";
		///<summary>sxi</summary>
        public const string Sxi = "application/vnd.sun.xml.impress";
		///<summary>sti</summary>
        public const string Sti = "application/vnd.sun.xml.impress.template";
		///<summary>sxm</summary>
        public const string Sxm = "application/vnd.sun.xml.math";
		///<summary>sxw</summary>
        public const string Sxw = "application/vnd.sun.xml.writer";
		///<summary>sxg</summary>
        public const string Sxg = "application/vnd.sun.xml.writer.global";
		///<summary>stw</summary>
        public const string Stw = "application/vnd.sun.xml.writer.template";
		///<summary>sus</summary>
        public const string Sus = "application/vnd.sus-calendar";
		///<summary>susp</summary>
        public const string Susp = "application/vnd.sus-calendar";
		///<summary>svd</summary>
        public const string Svd = "application/vnd.svd";
		///<summary>sis</summary>
        public const string Sis = "application/vnd.symbian.install";
		///<summary>sisx</summary>
        public const string Sisx = "application/vnd.symbian.install";
		///<summary>xsm</summary>
        public const string Xsm = "application/vnd.syncml+xml";
		///<summary>bdm</summary>
        public const string Bdm = "application/vnd.syncml.dm+wbxml";
		///<summary>xdm</summary>
        public const string Xdm = "application/vnd.syncml.dm+xml";
		///<summary>tao</summary>
        public const string Tao = "application/vnd.tao.intent-module-archive";
		///<summary>pcap</summary>
        public const string Pcap = "application/vnd.tcpdump.pcap";
		///<summary>cap</summary>
        public const string Cap = "application/vnd.tcpdump.pcap";
		///<summary>dmp</summary>
        public const string Dmp = "application/vnd.tcpdump.pcap";
		///<summary>tmo</summary>
        public const string Tmo = "application/vnd.tmobile-livetv";
		///<summary>tpt</summary>
        public const string Tpt = "application/vnd.trid.tpt";
		///<summary>mxs</summary>
        public const string Mxs = "application/vnd.triscape.mxs";
		///<summary>tra</summary>
        public const string Tra = "application/vnd.trueapp";
		///<summary>ufd</summary>
        public const string Ufd = "application/vnd.ufdl";
		///<summary>ufdl</summary>
        public const string Ufdl = "application/vnd.ufdl";
		///<summary>utz</summary>
        public const string Utz = "application/vnd.uiq.theme";
		///<summary>umj</summary>
        public const string Umj = "application/vnd.umajin";
		///<summary>unityweb</summary>
        public const string Unityweb = "application/vnd.unity";
		///<summary>uoml</summary>
        public const string Uoml = "application/vnd.uoml+xml";
		///<summary>vcx</summary>
        public const string Vcx = "application/vnd.vcx";
		///<summary>vsd</summary>
        public const string Vsd = "application/vnd.visio";
		///<summary>vst</summary>
        public const string Vst = "application/vnd.visio";
		///<summary>vss</summary>
        public const string Vss = "application/vnd.visio";
		///<summary>vsw</summary>
        public const string Vsw = "application/vnd.visio";
		///<summary>vis</summary>
        public const string Vis = "application/vnd.visionary";
		///<summary>vsf</summary>
        public const string Vsf = "application/vnd.vsf";
		///<summary>wbxml</summary>
        public const string Wbxml = "application/vnd.wap.wbxml";
		///<summary>wmlc</summary>
        public const string Wmlc = "application/vnd.wap.wmlc";
		///<summary>wmlsc</summary>
        public const string Wmlsc = "application/vnd.wap.wmlscriptc";
		///<summary>wtb</summary>
        public const string Wtb = "application/vnd.webturbo";
		///<summary>nbp</summary>
        public const string Nbp = "application/vnd.wolfram.player";
		///<summary>wpd</summary>
        public const string Wpd = "application/vnd.wordperfect";
		///<summary>wqd</summary>
        public const string Wqd = "application/vnd.wqd";
		///<summary>stf</summary>
        public const string Stf = "application/vnd.wt.stf";
		///<summary>xar</summary>
        public const string Xar = "application/vnd.xara";
		///<summary>xfdl</summary>
        public const string Xfdl = "application/vnd.xfdl";
		///<summary>hvd</summary>
        public const string Hvd = "application/vnd.yamaha.hv-dic";
		///<summary>hvs</summary>
        public const string Hvs = "application/vnd.yamaha.hv-script";
		///<summary>hvp</summary>
        public const string Hvp = "application/vnd.yamaha.hv-voice";
		///<summary>osf</summary>
        public const string Osf = "application/vnd.yamaha.openscoreformat";
		///<summary>osfpvg</summary>
        public const string Osfpvg = "application/vnd.yamaha.openscoreformat.osfpvg+xml";
		///<summary>saf</summary>
        public const string Saf = "application/vnd.yamaha.smaf-audio";
		///<summary>spf</summary>
        public const string Spf = "application/vnd.yamaha.smaf-phrase";
		///<summary>cmp</summary>
        public const string Cmp = "application/vnd.yellowriver-custom-menu";
		///<summary>zir</summary>
        public const string Zir = "application/vnd.zul";
		///<summary>zirz</summary>
        public const string Zirz = "application/vnd.zul";
		///<summary>zaz</summary>
        public const string Zaz = "application/vnd.zzazz.deck+xml";
		///<summary>vxml</summary>
        public const string Vxml = "application/voicexml+xml";
		///<summary>wgt</summary>
        public const string Wgt = "application/widget";
		///<summary>hlp</summary>
        public const string Hlp = "application/winhlp";
		///<summary>wsdl</summary>
        public const string Wsdl = "application/wsdl+xml";
		///<summary>wspolicy</summary>
        public const string Wspolicy = "application/wspolicy+xml";
		///<summary>7z</summary>
        public const string _7z = "application/x-7z-compressed";
		///<summary>abw</summary>
        public const string Abw = "application/x-abiword";
		///<summary>ace</summary>
        public const string Ace = "application/x-ace-compressed";
		///<summary>dmg</summary>
        public const string Dmg = "application/x-apple-diskimage";
		///<summary>aab</summary>
        public const string Aab = "application/x-authorware-bin";
		///<summary>x32</summary>
        public const string X32 = "application/x-authorware-bin";
		///<summary>u32</summary>
        public const string U32 = "application/x-authorware-bin";
		///<summary>vox</summary>
        public const string Vox = "application/x-authorware-bin";
		///<summary>aam</summary>
        public const string Aam = "application/x-authorware-map";
		///<summary>aas</summary>
        public const string Aas = "application/x-authorware-seg";
		///<summary>bcpio</summary>
        public const string Bcpio = "application/x-bcpio";
		///<summary>torrent</summary>
        public const string Torrent = "application/x-bittorrent";
		///<summary>blb</summary>
        public const string Blb = "application/x-blorb";
		///<summary>blorb</summary>
        public const string Blorb = "application/x-blorb";
		///<summary>bz</summary>
        public const string Bz = "application/x-bzip";
		///<summary>bz2</summary>
        public const string Bz2 = "application/x-bzip2";
		///<summary>boz</summary>
        public const string Boz = "application/x-bzip2";
		///<summary>cbr</summary>
        public const string Cbr = "application/x-cbr";
		///<summary>cba</summary>
        public const string Cba = "application/x-cbr";
		///<summary>cbt</summary>
        public const string Cbt = "application/x-cbr";
		///<summary>cbz</summary>
        public const string Cbz = "application/x-cbr";
		///<summary>cb7</summary>
        public const string Cb7 = "application/x-cbr";
		///<summary>vcd</summary>
        public const string Vcd = "application/x-cdlink";
		///<summary>cfs</summary>
        public const string Cfs = "application/x-cfs-compressed";
		///<summary>chat</summary>
        public const string Chat = "application/x-chat";
		///<summary>pgn</summary>
        public const string Pgn = "application/x-chess-pgn";
		///<summary>nsc</summary>
        public const string Nsc = "application/x-conference";
		///<summary>cpio</summary>
        public const string Cpio = "application/x-cpio";
		///<summary>csh</summary>
        public const string Csh = "application/x-csh";
		///<summary>deb</summary>
        public const string Deb = "application/x-debian-package";
		///<summary>udeb</summary>
        public const string Udeb = "application/x-debian-package";
		///<summary>dgc</summary>
        public const string Dgc = "application/x-dgc-compressed";
		///<summary>dir</summary>
        public const string Dir = "application/x-director";
		///<summary>dcr</summary>
        public const string Dcr = "application/x-director";
		///<summary>dxr</summary>
        public const string Dxr = "application/x-director";
		///<summary>cst</summary>
        public const string Cst = "application/x-director";
		///<summary>cct</summary>
        public const string Cct = "application/x-director";
		///<summary>cxt</summary>
        public const string Cxt = "application/x-director";
		///<summary>w3d</summary>
        public const string W3d = "application/x-director";
		///<summary>fgd</summary>
        public const string Fgd = "application/x-director";
		///<summary>swa</summary>
        public const string Swa = "application/x-director";
		///<summary>wad</summary>
        public const string Wad = "application/x-doom";
		///<summary>ncx</summary>
        public const string Ncx = "application/x-dtbncx+xml";
		///<summary>dtb</summary>
        public const string Dtb = "application/x-dtbook+xml";
		///<summary>res</summary>
        public const string Res = "application/x-dtbresource+xml";
		///<summary>dvi</summary>
        public const string Dvi = "application/x-dvi";
		///<summary>evy</summary>
        public const string Evy = "application/x-envoy";
		///<summary>eva</summary>
        public const string Eva = "application/x-eva";
		///<summary>bdf</summary>
        public const string Bdf = "application/x-font-bdf";
		///<summary>gsf</summary>
        public const string Gsf = "application/x-font-ghostscript";
		///<summary>psf</summary>
        public const string Psf = "application/x-font-linux-psf";
		///<summary>pcf</summary>
        public const string Pcf = "application/x-font-pcf";
		///<summary>snf</summary>
        public const string Snf = "application/x-font-snf";
		///<summary>pfa</summary>
        public const string Pfa = "application/x-font-type1";
		///<summary>pfb</summary>
        public const string Pfb = "application/x-font-type1";
		///<summary>pfm</summary>
        public const string Pfm = "application/x-font-type1";
		///<summary>afm</summary>
        public const string Afm = "application/x-font-type1";
		///<summary>arc</summary>
        public const string Arc = "application/x-freearc";
		///<summary>spl</summary>
        public const string Spl = "application/x-futuresplash";
		///<summary>gca</summary>
        public const string Gca = "application/x-gca-compressed";
		///<summary>ulx</summary>
        public const string Ulx = "application/x-glulx";
		///<summary>gnumeric</summary>
        public const string Gnumeric = "application/x-gnumeric";
		///<summary>gramps</summary>
        public const string Gramps = "application/x-gramps-xml";
		///<summary>gtar</summary>
        public const string Gtar = "application/x-gtar";
		///<summary>hdf</summary>
        public const string Hdf = "application/x-hdf";
		///<summary>install</summary>
        public const string Install = "application/x-install-instructions";
		///<summary>iso</summary>
        public const string Iso = "application/x-iso9660-image";
		///<summary>jnlp</summary>
        public const string Jnlp = "application/x-java-jnlp-file";
		///<summary>latex</summary>
        public const string Latex = "application/x-latex";
		///<summary>lzh</summary>
        public const string Lzh = "application/x-lzh-compressed";
		///<summary>lha</summary>
        public const string Lha = "application/x-lzh-compressed";
		///<summary>mie</summary>
        public const string Mie = "application/x-mie";
		///<summary>prc</summary>
        public const string Prc = "application/x-mobipocket-ebook";
		///<summary>mobi</summary>
        public const string Mobi = "application/x-mobipocket-ebook";
		///<summary>application</summary>
        public const string Application = "application/x-ms-application";
		///<summary>lnk</summary>
        public const string Lnk = "application/x-ms-shortcut";
		///<summary>wmd</summary>
        public const string Wmd = "application/x-ms-wmd";
		///<summary>wmz</summary>
        public const string Wmz = "application/x-ms-wmz";
		///<summary>xbap</summary>
        public const string Xbap = "application/x-ms-xbap";
		///<summary>mdb</summary>
        public const string Mdb = "application/x-msaccess";
		///<summary>obd</summary>
        public const string Obd = "application/x-msbinder";
		///<summary>crd</summary>
        public const string Crd = "application/x-mscardfile";
		///<summary>clp</summary>
        public const string Clp = "application/x-msclip";
		///<summary>exe</summary>
        public const string Exe = "application/x-msdownload";
		///<summary>dll</summary>
        public const string Dll = "application/x-msdownload";
		///<summary>com</summary>
        public const string Com = "application/x-msdownload";
		///<summary>bat</summary>
        public const string Bat = "application/x-msdownload";
		///<summary>msi</summary>
        public const string Msi = "application/x-msdownload";
		///<summary>mvb</summary>
        public const string Mvb = "application/x-msmediaview";
		///<summary>m13</summary>
        public const string M13 = "application/x-msmediaview";
		///<summary>m14</summary>
        public const string M14 = "application/x-msmediaview";
		///<summary>wmf</summary>
        public const string Wmf = "application/x-msmetafile";
		///<summary>emf</summary>
        public const string Emf = "application/x-msmetafile";
		///<summary>emz</summary>
        public const string Emz = "application/x-msmetafile";
		///<summary>mny</summary>
        public const string Mny = "application/x-msmoney";
		///<summary>pub</summary>
        public const string Pub = "application/x-mspublisher";
		///<summary>scd</summary>
        public const string Scd = "application/x-msschedule";
		///<summary>trm</summary>
        public const string Trm = "application/x-msterminal";
		///<summary>wri</summary>
        public const string Wri = "application/x-mswrite";
		///<summary>nc</summary>
        public const string Nc = "application/x-netcdf";
		///<summary>cdf</summary>
        public const string Cdf = "application/x-netcdf";
		///<summary>nzb</summary>
        public const string Nzb = "application/x-nzb";
		///<summary>p12</summary>
        public const string P12 = "application/x-pkcs12";
		///<summary>pfx</summary>
        public const string Pfx = "application/x-pkcs12";
		///<summary>p7b</summary>
        public const string P7b = "application/x-pkcs7-certificates";
		///<summary>spc</summary>
        public const string Spc = "application/x-pkcs7-certificates";
		///<summary>p7r</summary>
        public const string P7r = "application/x-pkcs7-certreqresp";
		///<summary>rar</summary>
        public const string Rar = "application/x-rar-compressed";
		///<summary>ris</summary>
        public const string Ris = "application/x-research-info-systems";
		///<summary>sh</summary>
        public const string Sh = "application/x-sh";
		///<summary>shar</summary>
        public const string Shar = "application/x-shar";
		///<summary>swf</summary>
        public const string Swf = "application/x-shockwave-flash";
		///<summary>xap</summary>
        public const string Xap = "application/x-silverlight-app";
		///<summary>sql</summary>
        public const string Sql = "application/x-sql";
		///<summary>sit</summary>
        public const string Sit = "application/x-stuffit";
		///<summary>sitx</summary>
        public const string Sitx = "application/x-stuffitx";
		///<summary>srt</summary>
        public const string Srt = "application/x-subrip";
		///<summary>sv4cpio</summary>
        public const string Sv4cpio = "application/x-sv4cpio";
		///<summary>sv4crc</summary>
        public const string Sv4crc = "application/x-sv4crc";
		///<summary>t3</summary>
        public const string T3 = "application/x-t3vm-image";
		///<summary>gam</summary>
        public const string Gam = "application/x-tads";
		///<summary>tar</summary>
        public const string Tar = "application/x-tar";
		///<summary>tcl</summary>
        public const string Tcl = "application/x-tcl";
		///<summary>tex</summary>
        public const string Tex = "application/x-tex";
		///<summary>tfm</summary>
        public const string Tfm = "application/x-tex-tfm";
		///<summary>texinfo</summary>
        public const string Texinfo = "application/x-texinfo";
		///<summary>texi</summary>
        public const string Texi = "application/x-texinfo";
		///<summary>obj</summary>
        public const string Obj = "application/x-tgif";
		///<summary>ustar</summary>
        public const string Ustar = "application/x-ustar";
		///<summary>src</summary>
        public const string Src = "application/x-wais-source";
		///<summary>der</summary>
        public const string Der = "application/x-x509-ca-cert";
		///<summary>crt</summary>
        public const string Crt = "application/x-x509-ca-cert";
		///<summary>fig</summary>
        public const string Fig = "application/x-xfig";
		///<summary>xlf</summary>
        public const string Xlf = "application/x-xliff+xml";
		///<summary>xpi</summary>
        public const string Xpi = "application/x-xpinstall";
		///<summary>xz</summary>
        public const string Xz = "application/x-xz";
		///<summary>z1</summary>
        public const string Z1 = "application/x-zmachine";
		///<summary>z2</summary>
        public const string Z2 = "application/x-zmachine";
		///<summary>z3</summary>
        public const string Z3 = "application/x-zmachine";
		///<summary>z4</summary>
        public const string Z4 = "application/x-zmachine";
		///<summary>z5</summary>
        public const string Z5 = "application/x-zmachine";
		///<summary>z6</summary>
        public const string Z6 = "application/x-zmachine";
		///<summary>z7</summary>
        public const string Z7 = "application/x-zmachine";
		///<summary>z8</summary>
        public const string Z8 = "application/x-zmachine";
		///<summary>xaml</summary>
        public const string Xaml = "application/xaml+xml";
		///<summary>xdf</summary>
        public const string Xdf = "application/xcap-diff+xml";
		///<summary>xenc</summary>
        public const string Xenc = "application/xenc+xml";
		///<summary>xhtml</summary>
        public const string Xhtml = "application/xhtml+xml";
		///<summary>xht</summary>
        public const string Xht = "application/xhtml+xml";
		///<summary>xml</summary>
        public const string Xml = "application/xml";
		///<summary>xsl</summary>
        public const string Xsl = "application/xml";
		///<summary>dtd</summary>
        public const string Dtd = "application/xml-dtd";
		///<summary>xop</summary>
        public const string Xop = "application/xop+xml";
		///<summary>xpl</summary>
        public const string Xpl = "application/xproc+xml";
		///<summary>xslt</summary>
        public const string Xslt = "application/xslt+xml";
		///<summary>xspf</summary>
        public const string Xspf = "application/xspf+xml";
		///<summary>mxml</summary>
        public const string Mxml = "application/xv+xml";
		///<summary>xhvml</summary>
        public const string Xhvml = "application/xv+xml";
		///<summary>xvml</summary>
        public const string Xvml = "application/xv+xml";
		///<summary>xvm</summary>
        public const string Xvm = "application/xv+xml";
		///<summary>yang</summary>
        public const string Yang = "application/yang";
		///<summary>yin</summary>
        public const string Yin = "application/yin+xml";
		///<summary>zip</summary>
        public const string Zip = "application/zip";
		///<summary>adp</summary>
        public const string Adp = "audio/adpcm";
		///<summary>au</summary>
        public const string Au = "audio/basic";
		///<summary>snd</summary>
        public const string Snd = "audio/basic";
		///<summary>mid</summary>
        public const string Mid = "audio/midi";
		///<summary>midi</summary>
        public const string Midi = "audio/midi";
		///<summary>kar</summary>
        public const string Kar = "audio/midi";
		///<summary>rmi</summary>
        public const string Rmi = "audio/midi";
		///<summary>m4a</summary>
        public const string M4a = "audio/mp4";
		///<summary>mp4a</summary>
        public const string Mp4a = "audio/mp4";
		///<summary>mpga</summary>
        public const string Mpga = "audio/mpeg";
		///<summary>mp2</summary>
        public const string Mp2 = "audio/mpeg";
		///<summary>mp2a</summary>
        public const string Mp2a = "audio/mpeg";
		///<summary>mp3</summary>
        public const string Mp3 = "audio/mpeg";
		///<summary>m2a</summary>
        public const string M2a = "audio/mpeg";
		///<summary>m3a</summary>
        public const string M3a = "audio/mpeg";
		///<summary>oga</summary>
        public const string Oga = "audio/ogg";
		///<summary>ogg</summary>
        public const string Ogg = "audio/ogg";
		///<summary>spx</summary>
        public const string Spx = "audio/ogg";
		///<summary>opus</summary>
        public const string Opus = "audio/ogg";
		///<summary>s3m</summary>
        public const string S3m = "audio/s3m";
		///<summary>sil</summary>
        public const string Sil = "audio/silk";
		///<summary>uva</summary>
        public const string Uva = "audio/vnd.dece.audio";
		///<summary>uvva</summary>
        public const string Uvva = "audio/vnd.dece.audio";
		///<summary>eol</summary>
        public const string Eol = "audio/vnd.digital-winds";
		///<summary>dra</summary>
        public const string Dra = "audio/vnd.dra";
		///<summary>dts</summary>
        public const string Dts = "audio/vnd.dts";
		///<summary>dtshd</summary>
        public const string Dtshd = "audio/vnd.dts.hd";
		///<summary>lvp</summary>
        public const string Lvp = "audio/vnd.lucent.voice";
		///<summary>pya</summary>
        public const string Pya = "audio/vnd.ms-playready.media.pya";
		///<summary>ecelp4800</summary>
        public const string Ecelp4800 = "audio/vnd.nuera.ecelp4800";
		///<summary>ecelp7470</summary>
        public const string Ecelp7470 = "audio/vnd.nuera.ecelp7470";
		///<summary>ecelp9600</summary>
        public const string Ecelp9600 = "audio/vnd.nuera.ecelp9600";
		///<summary>rip</summary>
        public const string Rip = "audio/vnd.rip";
		///<summary>weba</summary>
        public const string Weba = "audio/webm";
		///<summary>aac</summary>
        public const string Aac = "audio/x-aac";
		///<summary>aif</summary>
        public const string Aif = "audio/x-aiff";
		///<summary>aiff</summary>
        public const string Aiff = "audio/x-aiff";
		///<summary>aifc</summary>
        public const string Aifc = "audio/x-aiff";
		///<summary>caf</summary>
        public const string Caf = "audio/x-caf";
		///<summary>flac</summary>
        public const string Flac = "audio/x-flac";
		///<summary>mka</summary>
        public const string Mka = "audio/x-matroska";
		///<summary>m3u</summary>
        public const string M3u = "audio/x-mpegurl";
		///<summary>wax</summary>
        public const string Wax = "audio/x-ms-wax";
		///<summary>wma</summary>
        public const string Wma = "audio/x-ms-wma";
		///<summary>ram</summary>
        public const string Ram = "audio/x-pn-realaudio";
		///<summary>ra</summary>
        public const string Ra = "audio/x-pn-realaudio";
		///<summary>rmp</summary>
        public const string Rmp = "audio/x-pn-realaudio-plugin";
		///<summary>wav</summary>
        public const string Wav = "audio/x-wav";
		///<summary>xm</summary>
        public const string Xm = "audio/xm";
		///<summary>cdx</summary>
        public const string Cdx = "chemical/x-cdx";
		///<summary>cif</summary>
        public const string Cif = "chemical/x-cif";
		///<summary>cmdf</summary>
        public const string Cmdf = "chemical/x-cmdf";
		///<summary>cml</summary>
        public const string Cml = "chemical/x-cml";
		///<summary>csml</summary>
        public const string Csml = "chemical/x-csml";
		///<summary>xyz</summary>
        public const string Xyz = "chemical/x-xyz";
		///<summary>ttc</summary>
        public const string Ttc = "font/collection";
		///<summary>otf</summary>
        public const string Otf = "font/otf";
		///<summary>ttf</summary>
        public const string Ttf = "font/ttf";
		///<summary>woff</summary>
        public const string Woff = "font/woff";
		///<summary>woff2</summary>
        public const string Woff2 = "font/woff2";
		///<summary>bmp</summary>
        public const string Bmp = "image/bmp";
		///<summary>cgm</summary>
        public const string Cgm = "image/cgm";
		///<summary>g3</summary>
        public const string G3 = "image/g3fax";
		///<summary>gif</summary>
        public const string Gif = "image/gif";
		///<summary>ief</summary>
        public const string Ief = "image/ief";
		///<summary>jpeg</summary>
        public const string Jpeg = "image/jpeg";
		///<summary>jpg</summary>
        public const string Jpg = "image/jpeg";
		///<summary>jpe</summary>
        public const string Jpe = "image/jpeg";
		///<summary>ktx</summary>
        public const string Ktx = "image/ktx";
		///<summary>png</summary>
        public const string Png = "image/png";
		///<summary>btif</summary>
        public const string Btif = "image/prs.btif";
		///<summary>sgi</summary>
        public const string Sgi = "image/sgi";
		///<summary>svg</summary>
        public const string Svg = "image/svg+xml";
		///<summary>svgz</summary>
        public const string Svgz = "image/svg+xml";
		///<summary>tiff</summary>
        public const string Tiff = "image/tiff";
		///<summary>tif</summary>
        public const string Tif = "image/tiff";
		///<summary>psd</summary>
        public const string Psd = "image/vnd.adobe.photoshop";
		///<summary>uvi</summary>
        public const string Uvi = "image/vnd.dece.graphic";
		///<summary>uvvi</summary>
        public const string Uvvi = "image/vnd.dece.graphic";
		///<summary>uvg</summary>
        public const string Uvg = "image/vnd.dece.graphic";
		///<summary>uvvg</summary>
        public const string Uvvg = "image/vnd.dece.graphic";
		///<summary>djvu</summary>
        public const string Djvu = "image/vnd.djvu";
		///<summary>djv</summary>
        public const string Djv = "image/vnd.djvu";
		///<summary>sub</summary>
        public const string Sub = "image/vnd.dvb.subtitle";
		///<summary>dwg</summary>
        public const string Dwg = "image/vnd.dwg";
		///<summary>dxf</summary>
        public const string Dxf = "image/vnd.dxf";
		///<summary>fbs</summary>
        public const string Fbs = "image/vnd.fastbidsheet";
		///<summary>fpx</summary>
        public const string Fpx = "image/vnd.fpx";
		///<summary>fst</summary>
        public const string Fst = "image/vnd.fst";
		///<summary>mmr</summary>
        public const string Mmr = "image/vnd.fujixerox.edmics-mmr";
		///<summary>rlc</summary>
        public const string Rlc = "image/vnd.fujixerox.edmics-rlc";
		///<summary>mdi</summary>
        public const string Mdi = "image/vnd.ms-modi";
		///<summary>wdp</summary>
        public const string Wdp = "image/vnd.ms-photo";
		///<summary>npx</summary>
        public const string Npx = "image/vnd.net-fpx";
		///<summary>wbmp</summary>
        public const string Wbmp = "image/vnd.wap.wbmp";
		///<summary>xif</summary>
        public const string Xif = "image/vnd.xiff";
		///<summary>webp</summary>
        public const string Webp = "image/webp";
		///<summary>3ds</summary>
        public const string _3ds = "image/x-3ds";
		///<summary>ras</summary>
        public const string Ras = "image/x-cmu-raster";
		///<summary>cmx</summary>
        public const string Cmx = "image/x-cmx";
		///<summary>fh</summary>
        public const string Fh = "image/x-freehand";
		///<summary>fhc</summary>
        public const string Fhc = "image/x-freehand";
		///<summary>fh4</summary>
        public const string Fh4 = "image/x-freehand";
		///<summary>fh5</summary>
        public const string Fh5 = "image/x-freehand";
		///<summary>fh7</summary>
        public const string Fh7 = "image/x-freehand";
		///<summary>ico</summary>
        public const string Ico = "image/x-icon";
		///<summary>sid</summary>
        public const string Sid = "image/x-mrsid-image";
		///<summary>pcx</summary>
        public const string Pcx = "image/x-pcx";
		///<summary>pic</summary>
        public const string Pic = "image/x-pict";
		///<summary>pct</summary>
        public const string Pct = "image/x-pict";
		///<summary>pnm</summary>
        public const string Pnm = "image/x-portable-anymap";
		///<summary>pbm</summary>
        public const string Pbm = "image/x-portable-bitmap";
		///<summary>pgm</summary>
        public const string Pgm = "image/x-portable-graymap";
		///<summary>ppm</summary>
        public const string Ppm = "image/x-portable-pixmap";
		///<summary>rgb</summary>
        public const string Rgb = "image/x-rgb";
		///<summary>tga</summary>
        public const string Tga = "image/x-tga";
		///<summary>xbm</summary>
        public const string Xbm = "image/x-xbitmap";
		///<summary>xpm</summary>
        public const string Xpm = "image/x-xpixmap";
		///<summary>xwd</summary>
        public const string Xwd = "image/x-xwindowdump";
		///<summary>eml</summary>
        public const string Eml = "message/rfc822";
		///<summary>mime</summary>
        public const string Mime = "message/rfc822";
		///<summary>igs</summary>
        public const string Igs = "model/iges";
		///<summary>iges</summary>
        public const string Iges = "model/iges";
		///<summary>msh</summary>
        public const string Msh = "model/mesh";
		///<summary>mesh</summary>
        public const string Mesh = "model/mesh";
		///<summary>silo</summary>
        public const string Silo = "model/mesh";
		///<summary>dae</summary>
        public const string Dae = "model/vnd.collada+xml";
		///<summary>dwf</summary>
        public const string Dwf = "model/vnd.dwf";
		///<summary>gdl</summary>
        public const string Gdl = "model/vnd.gdl";
		///<summary>gtw</summary>
        public const string Gtw = "model/vnd.gtw";
		///<summary>mts</summary>
        public const string Mts = "model/vnd.mts";
		///<summary>vtu</summary>
        public const string Vtu = "model/vnd.vtu";
		///<summary>wrl</summary>
        public const string Wrl = "model/vrml";
		///<summary>vrml</summary>
        public const string Vrml = "model/vrml";
		///<summary>x3db</summary>
        public const string X3db = "model/x3d+binary";
		///<summary>x3dbz</summary>
        public const string X3dbz = "model/x3d+binary";
		///<summary>x3dv</summary>
        public const string X3dv = "model/x3d+vrml";
		///<summary>x3dvz</summary>
        public const string X3dvz = "model/x3d+vrml";
		///<summary>x3d</summary>
        public const string X3d = "model/x3d+xml";
		///<summary>x3dz</summary>
        public const string X3dz = "model/x3d+xml";
		///<summary>appcache</summary>
        public const string Appcache = "text/cache-manifest";
		///<summary>ics</summary>
        public const string Ics = "text/calendar";
		///<summary>ifb</summary>
        public const string Ifb = "text/calendar";
		///<summary>css</summary>
        public const string Css = "text/css";
		///<summary>csv</summary>
        public const string Csv = "text/csv";
		///<summary>html</summary>
        public const string Html = "text/html";
		///<summary>htm</summary>
        public const string Htm = "text/html";
		///<summary>n3</summary>
        public const string N3 = "text/n3";
		///<summary>txt</summary>
        public const string Txt = "text/plain";
		///<summary>text</summary>
        public const string Text = "text/plain";
		///<summary>conf</summary>
        public const string Conf = "text/plain";
		///<summary>def</summary>
        public const string Def = "text/plain";
		///<summary>list</summary>
        public const string List = "text/plain";
		///<summary>log</summary>
        public const string Log = "text/plain";
		///<summary>in</summary>
        public const string In = "text/plain";
		///<summary>dsc</summary>
        public const string Dsc = "text/prs.lines.tag";
		///<summary>rtx</summary>
        public const string Rtx = "text/richtext";
		///<summary>sgml</summary>
        public const string Sgml = "text/sgml";
		///<summary>sgm</summary>
        public const string Sgm = "text/sgml";
		///<summary>tsv</summary>
        public const string Tsv = "text/tab-separated-values";
		///<summary>t</summary>
        public const string T = "text/troff";
		///<summary>tr</summary>
        public const string Tr = "text/troff";
		///<summary>roff</summary>
        public const string Roff = "text/troff";
		///<summary>man</summary>
        public const string Man = "text/troff";
		///<summary>me</summary>
        public const string Me = "text/troff";
		///<summary>ms</summary>
        public const string Ms = "text/troff";
		///<summary>ttl</summary>
        public const string Ttl = "text/turtle";
		///<summary>uri</summary>
        public const string Uri = "text/uri-list";
		///<summary>uris</summary>
        public const string Uris = "text/uri-list";
		///<summary>urls</summary>
        public const string Urls = "text/uri-list";
		///<summary>vcard</summary>
        public const string Vcard = "text/vcard";
		///<summary>curl</summary>
        public const string Curl = "text/vnd.curl";
		///<summary>dcurl</summary>
        public const string Dcurl = "text/vnd.curl.dcurl";
		///<summary>mcurl</summary>
        public const string Mcurl = "text/vnd.curl.mcurl";
		///<summary>scurl</summary>
        public const string Scurl = "text/vnd.curl.scurl";
		///<summary>fly</summary>
        public const string Fly = "text/vnd.fly";
		///<summary>flx</summary>
        public const string Flx = "text/vnd.fmi.flexstor";
		///<summary>gv</summary>
        public const string Gv = "text/vnd.graphviz";
		///<summary>3dml</summary>
        public const string _3dml = "text/vnd.in3d.3dml";
		///<summary>spot</summary>
        public const string Spot = "text/vnd.in3d.spot";
		///<summary>jad</summary>
        public const string Jad = "text/vnd.sun.j2me.app-descriptor";
		///<summary>wml</summary>
        public const string Wml = "text/vnd.wap.wml";
		///<summary>wmls</summary>
        public const string Wmls = "text/vnd.wap.wmlscript";
		///<summary>s</summary>
        public const string S = "text/x-asm";
		///<summary>asm</summary>
        public const string Asm = "text/x-asm";
		///<summary>c</summary>
        public const string C = "text/x-c";
		///<summary>cc</summary>
        public const string Cc = "text/x-c";
		///<summary>cxx</summary>
        public const string Cxx = "text/x-c";
		///<summary>cpp</summary>
        public const string Cpp = "text/x-c";
		///<summary>h</summary>
        public const string H = "text/x-c";
		///<summary>hh</summary>
        public const string Hh = "text/x-c";
		///<summary>dic</summary>
        public const string Dic = "text/x-c";
		///<summary>f</summary>
        public const string F = "text/x-fortran";
		///<summary>for</summary>
        public const string For = "text/x-fortran";
		///<summary>f77</summary>
        public const string F77 = "text/x-fortran";
		///<summary>f90</summary>
        public const string F90 = "text/x-fortran";
		///<summary>java</summary>
        public const string Java = "text/x-java-source";
		///<summary>nfo</summary>
        public const string Nfo = "text/x-nfo";
		///<summary>opml</summary>
        public const string Opml = "text/x-opml";
		///<summary>p</summary>
        public const string P = "text/x-pascal";
		///<summary>pas</summary>
        public const string Pas = "text/x-pascal";
		///<summary>etx</summary>
        public const string Etx = "text/x-setext";
		///<summary>sfv</summary>
        public const string Sfv = "text/x-sfv";
		///<summary>uu</summary>
        public const string Uu = "text/x-uuencode";
		///<summary>vcs</summary>
        public const string Vcs = "text/x-vcalendar";
		///<summary>vcf</summary>
        public const string Vcf = "text/x-vcard";
		///<summary>3gp</summary>
        public const string _3gp = "video/3gpp";
		///<summary>3g2</summary>
        public const string _3g2 = "video/3gpp2";
		///<summary>h261</summary>
        public const string H261 = "video/h261";
		///<summary>h263</summary>
        public const string H263 = "video/h263";
		///<summary>h264</summary>
        public const string H264 = "video/h264";
		///<summary>jpgv</summary>
        public const string Jpgv = "video/jpeg";
		///<summary>jpm</summary>
        public const string Jpm = "video/jpm";
		///<summary>jpgm</summary>
        public const string Jpgm = "video/jpm";
		///<summary>mj2</summary>
        public const string Mj2 = "video/mj2";
		///<summary>mjp2</summary>
        public const string Mjp2 = "video/mj2";
		///<summary>mp4</summary>
        public const string Mp4 = "video/mp4";
		///<summary>mp4v</summary>
        public const string Mp4v = "video/mp4";
		///<summary>mpg4</summary>
        public const string Mpg4 = "video/mp4";
		///<summary>mpeg</summary>
        public const string Mpeg = "video/mpeg";
		///<summary>mpg</summary>
        public const string Mpg = "video/mpeg";
		///<summary>mpe</summary>
        public const string Mpe = "video/mpeg";
		///<summary>m1v</summary>
        public const string M1v = "video/mpeg";
		///<summary>m2v</summary>
        public const string M2v = "video/mpeg";
		///<summary>ogv</summary>
        public const string Ogv = "video/ogg";
		///<summary>qt</summary>
        public const string Qt = "video/quicktime";
		///<summary>mov</summary>
        public const string Mov = "video/quicktime";
		///<summary>uvh</summary>
        public const string Uvh = "video/vnd.dece.hd";
		///<summary>uvvh</summary>
        public const string Uvvh = "video/vnd.dece.hd";
		///<summary>uvm</summary>
        public const string Uvm = "video/vnd.dece.mobile";
		///<summary>uvvm</summary>
        public const string Uvvm = "video/vnd.dece.mobile";
		///<summary>uvp</summary>
        public const string Uvp = "video/vnd.dece.pd";
		///<summary>uvvp</summary>
        public const string Uvvp = "video/vnd.dece.pd";
		///<summary>uvs</summary>
        public const string Uvs = "video/vnd.dece.sd";
		///<summary>uvvs</summary>
        public const string Uvvs = "video/vnd.dece.sd";
		///<summary>uvv</summary>
        public const string Uvv = "video/vnd.dece.video";
		///<summary>uvvv</summary>
        public const string Uvvv = "video/vnd.dece.video";
		///<summary>dvb</summary>
        public const string Dvb = "video/vnd.dvb.file";
		///<summary>fvt</summary>
        public const string Fvt = "video/vnd.fvt";
		///<summary>mxu</summary>
        public const string Mxu = "video/vnd.mpegurl";
		///<summary>m4u</summary>
        public const string M4u = "video/vnd.mpegurl";
		///<summary>pyv</summary>
        public const string Pyv = "video/vnd.ms-playready.media.pyv";
		///<summary>uvu</summary>
        public const string Uvu = "video/vnd.uvvu.mp4";
		///<summary>uvvu</summary>
        public const string Uvvu = "video/vnd.uvvu.mp4";
		///<summary>viv</summary>
        public const string Viv = "video/vnd.vivo";
		///<summary>webm</summary>
        public const string Webm = "video/webm";
		///<summary>f4v</summary>
        public const string F4v = "video/x-f4v";
		///<summary>fli</summary>
        public const string Fli = "video/x-fli";
		///<summary>flv</summary>
        public const string Flv = "video/x-flv";
		///<summary>m4v</summary>
        public const string M4v = "video/x-m4v";
		///<summary>mkv</summary>
        public const string Mkv = "video/x-matroska";
		///<summary>mk3d</summary>
        public const string Mk3d = "video/x-matroska";
		///<summary>mks</summary>
        public const string Mks = "video/x-matroska";
		///<summary>mng</summary>
        public const string Mng = "video/x-mng";
		///<summary>asf</summary>
        public const string Asf = "video/x-ms-asf";
		///<summary>asx</summary>
        public const string Asx = "video/x-ms-asf";
		///<summary>vob</summary>
        public const string Vob = "video/x-ms-vob";
		///<summary>wm</summary>
        public const string Wm = "video/x-ms-wm";
		///<summary>wmv</summary>
        public const string Wmv = "video/x-ms-wmv";
		///<summary>wmx</summary>
        public const string Wmx = "video/x-ms-wmx";
		///<summary>wvx</summary>
        public const string Wvx = "video/x-ms-wvx";
		///<summary>avi</summary>
        public const string Avi = "video/x-msvideo";
		///<summary>movie</summary>
        public const string Movie = "video/x-sgi-movie";
		///<summary>smv</summary>
        public const string Smv = "video/x-smv";
		///<summary>ice</summary>
        public const string Ice = "x-conference/x-cooltalk";
		///<summary>map</summary>
        public const string Map = "application/json";
		///<summary>topojson</summary>
        public const string Topojson = "application/json";
		///<summary>jsonld</summary>
        public const string Jsonld = "application/ld+json";
		///<summary>geojson</summary>
        public const string Geojson = "application/geo+json";
		///<summary>mjs</summary>
        public const string Mjs = "text/javascript";
		///<summary>wasm</summary>
        public const string Wasm = "application/wasm";
		///<summary>webmanifest</summary>
        public const string Webmanifest = "application/manifest+json";
		///<summary>webapp</summary>
        public const string Webapp = "application/x-web-app-manifest+json";
		///<summary>f4a</summary>
        public const string F4a = "audio/mp4";
		///<summary>f4b</summary>
        public const string F4b = "audio/mp4";
		///<summary>jxr</summary>
        public const string Jxr = "image/jxr";
		///<summary>hdp</summary>
        public const string Hdp = "image/jxr";
		///<summary>jng</summary>
        public const string Jng = "image/x-jng";
		///<summary>3gpp</summary>
        public const string _3gpp = "video/3gpp";
		///<summary>f4p</summary>
        public const string F4p = "video/mp4";
		///<summary>cur</summary>
        public const string Cur = "image/x-icon";
		///<summary>ear</summary>
        public const string Ear = "application/java-archive";
		///<summary>war</summary>
        public const string War = "application/java-archive";
		///<summary>img</summary>
        public const string Img = "application/octet-stream";
		///<summary>msm</summary>
        public const string Msm = "application/octet-stream";
		///<summary>msp</summary>
        public const string Msp = "application/octet-stream";
		///<summary>safariextz</summary>
        public const string Safariextz = "application/octet-stream";
		///<summary>bbaw</summary>
        public const string Bbaw = "application/x-bb-appworld";
		///<summary>crx</summary>
        public const string Crx = "application/x-chrome-extension";
		///<summary>cco</summary>
        public const string Cco = "application/x-cocoa";
		///<summary>jardiff</summary>
        public const string Jardiff = "application/x-java-archive-diff";
		///<summary>run</summary>
        public const string Run = "application/x-makeself";
		///<summary>oex</summary>
        public const string Oex = "application/x-opera-extension";
		///<summary>pl</summary>
        public const string Pl = "application/x-perl";
		///<summary>pm</summary>
        public const string Pm = "application/x-perl";
		///<summary>rpm</summary>
        public const string Rpm = "application/x-redhat-package-manager";
		///<summary>sea</summary>
        public const string Sea = "application/x-sea";
		///<summary>tk</summary>
        public const string Tk = "application/x-tcl";
		///<summary>pem</summary>
        public const string Pem = "application/x-x509-ca-cert";
		///<summary>shtml</summary>
        public const string Shtml = "text/html";
		///<summary>md</summary>
        public const string Md = "text/markdown";
		///<summary>markdown</summary>
        public const string Markdown = "text/markdown";
		///<summary>mml</summary>
        public const string Mml = "text/mathml";
		///<summary>xloc</summary>
        public const string Xloc = "text/vnd.rim.location.xloc";
		///<summary>vtt</summary>
        public const string Vtt = "text/vtt";
		///<summary>htc</summary>
        public const string Htc = "text/x-component";
		///<summary>bdoc</summary>
        public const string Bdoc = "application/bdoc";
		///<summary>es</summary>
        public const string Es = "application/ecmascript";
		///<summary>hjson</summary>
        public const string Hjson = "application/hjson";
		///<summary>json5</summary>
        public const string Json5 = "application/json5";
		///<summary>m4p</summary>
        public const string M4p = "application/mp4";
		///<summary>cjs</summary>
        public const string Cjs = "application/node";
		///<summary>buffer</summary>
        public const string Buffer = "application/octet-stream";
		///<summary>raml</summary>
        public const string Raml = "application/raml+yaml";
		///<summary>owl</summary>
        public const string Owl = "application/rdf+xml";
		///<summary>siv</summary>
        public const string Siv = "application/sieve";
		///<summary>sieve</summary>
        public const string Sieve = "application/sieve";
		///<summary>toml</summary>
        public const string Toml = "application/toml";
		///<summary>ubj</summary>
        public const string Ubj = "application/ubjson";
		///<summary>pkpass</summary>
        public const string Pkpass = "application/vnd.apple.pkpass";
		///<summary>gdoc</summary>
        public const string Gdoc = "application/vnd.google-apps.document";
		///<summary>gslides</summary>
        public const string Gslides = "application/vnd.google-apps.presentation";
		///<summary>gsheet</summary>
        public const string Gsheet = "application/vnd.google-apps.spreadsheet";
		///<summary>msg</summary>
        public const string Msg = "application/vnd.ms-outlook";
		///<summary>arj</summary>
        public const string Arj = "application/x-arj";
		///<summary>php</summary>
        public const string Php = "application/x-httpd-php";
		///<summary>kdbx</summary>
        public const string Kdbx = "application/x-keepass2";
		///<summary>luac</summary>
        public const string Luac = "application/x-lua-bytecode";
		///<summary>pac</summary>
        public const string Pac = "application/x-ns-proxy-autoconfig";
		///<summary>hdd</summary>
        public const string Hdd = "application/x-virtualbox-hdd";
		///<summary>ova</summary>
        public const string Ova = "application/x-virtualbox-ova";
		///<summary>ovf</summary>
        public const string Ovf = "application/x-virtualbox-ovf";
		///<summary>vbox</summary>
        public const string Vbox = "application/x-virtualbox-vbox";
		///<summary>vbox-extpack</summary>
        public const string Vboxextpack = "application/x-virtualbox-vbox-extpack";
		///<summary>vdi</summary>
        public const string Vdi = "application/x-virtualbox-vdi";
		///<summary>vhd</summary>
        public const string Vhd = "application/x-virtualbox-vhd";
		///<summary>vmdk</summary>
        public const string Vmdk = "application/x-virtualbox-vmdk";
		///<summary>xsd</summary>
        public const string Xsd = "application/xml";
		///<summary>rng</summary>
        public const string Rng = "application/xml";
		///<summary>apng</summary>
        public const string Apng = "image/apng";
		///<summary>avif</summary>
        public const string Avif = "image/avif";
		///<summary>heic</summary>
        public const string Heic = "image/heic";
		///<summary>heics</summary>
        public const string Heics = "image/heic-sequence";
		///<summary>heif</summary>
        public const string Heif = "image/heif";
		///<summary>heifs</summary>
        public const string Heifs = "image/heif-sequence";
		///<summary>jp2</summary>
        public const string Jp2 = "image/jp2";
		///<summary>jpg2</summary>
        public const string Jpg2 = "image/jp2";
		///<summary>jpx</summary>
        public const string Jpx = "image/jpx";
		///<summary>jpf</summary>
        public const string Jpf = "image/jpx";
		///<summary>dds</summary>
        public const string Dds = "image/vnd.ms-dds";
		///<summary>manifest</summary>
        public const string Manifest = "text/cache-manifest";
		///<summary>coffee</summary>
        public const string Coffee = "text/coffeescript";
		///<summary>litcoffee</summary>
        public const string Litcoffee = "text/coffeescript";
		///<summary>jade</summary>
        public const string Jade = "text/jade";
		///<summary>jsx</summary>
        public const string Jsx = "text/jsx";
		///<summary>less</summary>
        public const string Less = "text/less";
		///<summary>mdx</summary>
        public const string Mdx = "text/mdx";
		///<summary>ini</summary>
        public const string Ini = "text/plain";
		///<summary>shex</summary>
        public const string Shex = "text/shex";
		///<summary>slim</summary>
        public const string Slim = "text/slim";
		///<summary>slm</summary>
        public const string Slm = "text/slim";
		///<summary>stylus</summary>
        public const string Stylus = "text/stylus";
		///<summary>styl</summary>
        public const string Styl = "text/stylus";
		///<summary>hbs</summary>
        public const string Hbs = "text/x-handlebars-template";
		///<summary>lua</summary>
        public const string Lua = "text/x-lua";
		///<summary>mkd</summary>
        public const string Mkd = "text/x-markdown";
		///<summary>pde</summary>
        public const string Pde = "text/x-processing";
		///<summary>sass</summary>
        public const string Sass = "text/x-sass";
		///<summary>scss</summary>
        public const string Scss = "text/x-scss";
		///<summary>ymp</summary>
        public const string Ymp = "text/x-suse-ymp";
		///<summary>yaml</summary>
        public const string Yaml = "text/yaml";
		///<summary>yml</summary>
        public const string Yml = "text/yaml";

		public static class Extensions
		{
			public const string _ez = "ez";
			public const string _aw = "aw";
			public const string _atom = "atom";
			public const string _atomcat = "atomcat";
			public const string _atomsvc = "atomsvc";
			public const string _ccxml = "ccxml";
			public const string _cdmia = "cdmia";
			public const string _cdmic = "cdmic";
			public const string _cdmid = "cdmid";
			public const string _cdmio = "cdmio";
			public const string _cdmiq = "cdmiq";
			public const string _cu = "cu";
			public const string _davmount = "davmount";
			public const string _dbk = "dbk";
			public const string _dssc = "dssc";
			public const string _xdssc = "xdssc";
			public const string _ecma = "ecma";
			public const string _emma = "emma";
			public const string _epub = "epub";
			public const string _exi = "exi";
			public const string _pfr = "pfr";
			public const string _gml = "gml";
			public const string _gpx = "gpx";
			public const string _gxf = "gxf";
			public const string _stk = "stk";
			public const string _ink = "ink";
			public const string _inkml = "inkml";
			public const string _ipfix = "ipfix";
			public const string _jar = "jar";
			public const string _ser = "ser";
			public const string _class = "class";
			public const string _js = "js";
			public const string _json = "json";
			public const string _jsonml = "jsonml";
			public const string _lostxml = "lostxml";
			public const string _hqx = "hqx";
			public const string _cpt = "cpt";
			public const string _mads = "mads";
			public const string _mrc = "mrc";
			public const string _mrcx = "mrcx";
			public const string _ma = "ma";
			public const string _nb = "nb";
			public const string _mb = "mb";
			public const string _mathml = "mathml";
			public const string _mbox = "mbox";
			public const string _mscml = "mscml";
			public const string _metalink = "metalink";
			public const string _meta4 = "meta4";
			public const string _mets = "mets";
			public const string _mods = "mods";
			public const string _m21 = "m21";
			public const string _mp21 = "mp21";
			public const string _mp4s = "mp4s";
			public const string _doc = "doc";
			public const string _dot = "dot";
			public const string _mxf = "mxf";
			public const string _bin = "bin";
			public const string _dms = "dms";
			public const string _lrf = "lrf";
			public const string _mar = "mar";
			public const string _so = "so";
			public const string _dist = "dist";
			public const string _distz = "distz";
			public const string _pkg = "pkg";
			public const string _bpk = "bpk";
			public const string _dump = "dump";
			public const string _elc = "elc";
			public const string _deploy = "deploy";
			public const string _oda = "oda";
			public const string _opf = "opf";
			public const string _ogx = "ogx";
			public const string _omdoc = "omdoc";
			public const string _onetoc = "onetoc";
			public const string _onetoc2 = "onetoc2";
			public const string _onetmp = "onetmp";
			public const string _onepkg = "onepkg";
			public const string _oxps = "oxps";
			public const string _xer = "xer";
			public const string _pdf = "pdf";
			public const string _pgp = "pgp";
			public const string _asc = "asc";
			public const string _sig = "sig";
			public const string _prf = "prf";
			public const string _p10 = "p10";
			public const string _p7m = "p7m";
			public const string _p7c = "p7c";
			public const string _p7s = "p7s";
			public const string _p8 = "p8";
			public const string _ac = "ac";
			public const string _cer = "cer";
			public const string _crl = "crl";
			public const string _pkipath = "pkipath";
			public const string _pki = "pki";
			public const string _pls = "pls";
			public const string _ai = "ai";
			public const string _eps = "eps";
			public const string _ps = "ps";
			public const string _cww = "cww";
			public const string _pskcxml = "pskcxml";
			public const string _rdf = "rdf";
			public const string _rif = "rif";
			public const string _rnc = "rnc";
			public const string _rl = "rl";
			public const string _rld = "rld";
			public const string _rs = "rs";
			public const string _gbr = "gbr";
			public const string _mft = "mft";
			public const string _roa = "roa";
			public const string _rsd = "rsd";
			public const string _rss = "rss";
			public const string _rtf = "rtf";
			public const string _sbml = "sbml";
			public const string _scq = "scq";
			public const string _scs = "scs";
			public const string _spq = "spq";
			public const string _spp = "spp";
			public const string _sdp = "sdp";
			public const string _setpay = "setpay";
			public const string _setreg = "setreg";
			public const string _shf = "shf";
			public const string _smi = "smi";
			public const string _smil = "smil";
			public const string _rq = "rq";
			public const string _srx = "srx";
			public const string _gram = "gram";
			public const string _grxml = "grxml";
			public const string _sru = "sru";
			public const string _ssdl = "ssdl";
			public const string _ssml = "ssml";
			public const string _tei = "tei";
			public const string _teicorpus = "teicorpus";
			public const string _tfi = "tfi";
			public const string _tsd = "tsd";
			public const string _plb = "plb";
			public const string _psb = "psb";
			public const string _pvb = "pvb";
			public const string _tcap = "tcap";
			public const string _pwn = "pwn";
			public const string _aso = "aso";
			public const string _imp = "imp";
			public const string _acu = "acu";
			public const string _atc = "atc";
			public const string _acutc = "acutc";
			public const string _air = "air";
			public const string _fcdt = "fcdt";
			public const string _fxp = "fxp";
			public const string _fxpl = "fxpl";
			public const string _xdp = "xdp";
			public const string _xfdf = "xfdf";
			public const string _ahead = "ahead";
			public const string _azf = "azf";
			public const string _azs = "azs";
			public const string _azw = "azw";
			public const string _acc = "acc";
			public const string _ami = "ami";
			public const string _apk = "apk";
			public const string _cii = "cii";
			public const string _fti = "fti";
			public const string _atx = "atx";
			public const string _mpkg = "mpkg";
			public const string _m3u8 = "m3u8";
			public const string _swi = "swi";
			public const string _iota = "iota";
			public const string _aep = "aep";
			public const string _mpm = "mpm";
			public const string _bmi = "bmi";
			public const string _rep = "rep";
			public const string _cdxml = "cdxml";
			public const string _mmd = "mmd";
			public const string _cdy = "cdy";
			public const string _cla = "cla";
			public const string _rp9 = "rp9";
			public const string _c4g = "c4g";
			public const string _c4d = "c4d";
			public const string _c4f = "c4f";
			public const string _c4p = "c4p";
			public const string _c4u = "c4u";
			public const string _c11amc = "c11amc";
			public const string _c11amz = "c11amz";
			public const string _csp = "csp";
			public const string _cdbcmsg = "cdbcmsg";
			public const string _cmc = "cmc";
			public const string _clkx = "clkx";
			public const string _clkk = "clkk";
			public const string _clkp = "clkp";
			public const string _clkt = "clkt";
			public const string _clkw = "clkw";
			public const string _wbs = "wbs";
			public const string _pml = "pml";
			public const string _ppd = "ppd";
			public const string _car = "car";
			public const string _pcurl = "pcurl";
			public const string _dart = "dart";
			public const string _rdz = "rdz";
			public const string _uvf = "uvf";
			public const string _uvvf = "uvvf";
			public const string _uvd = "uvd";
			public const string _uvvd = "uvvd";
			public const string _uvt = "uvt";
			public const string _uvvt = "uvvt";
			public const string _uvx = "uvx";
			public const string _uvvx = "uvvx";
			public const string _uvz = "uvz";
			public const string _uvvz = "uvvz";
			public const string _fe_launch = "fe_launch";
			public const string _dna = "dna";
			public const string _mlp = "mlp";
			public const string _dpg = "dpg";
			public const string _dfac = "dfac";
			public const string _kpxx = "kpxx";
			public const string _ait = "ait";
			public const string _svc = "svc";
			public const string _geo = "geo";
			public const string _mag = "mag";
			public const string _nml = "nml";
			public const string _esf = "esf";
			public const string _msf = "msf";
			public const string _qam = "qam";
			public const string _slt = "slt";
			public const string _ssf = "ssf";
			public const string _es3 = "es3";
			public const string _et3 = "et3";
			public const string _ez2 = "ez2";
			public const string _ez3 = "ez3";
			public const string _fdf = "fdf";
			public const string _mseed = "mseed";
			public const string _seed = "seed";
			public const string _dataless = "dataless";
			public const string _gph = "gph";
			public const string _ftc = "ftc";
			public const string _fm = "fm";
			public const string _frame = "frame";
			public const string _maker = "maker";
			public const string _book = "book";
			public const string _fnc = "fnc";
			public const string _ltf = "ltf";
			public const string _fsc = "fsc";
			public const string _oas = "oas";
			public const string _oa2 = "oa2";
			public const string _oa3 = "oa3";
			public const string _fg5 = "fg5";
			public const string _bh2 = "bh2";
			public const string _ddd = "ddd";
			public const string _xdw = "xdw";
			public const string _xbd = "xbd";
			public const string _fzs = "fzs";
			public const string _txd = "txd";
			public const string _ggb = "ggb";
			public const string _ggt = "ggt";
			public const string _gex = "gex";
			public const string _gre = "gre";
			public const string _gxt = "gxt";
			public const string _g2w = "g2w";
			public const string _g3w = "g3w";
			public const string _gmx = "gmx";
			public const string _kml = "kml";
			public const string _kmz = "kmz";
			public const string _gqf = "gqf";
			public const string _gqs = "gqs";
			public const string _gac = "gac";
			public const string _ghf = "ghf";
			public const string _gim = "gim";
			public const string _grv = "grv";
			public const string _gtm = "gtm";
			public const string _tpl = "tpl";
			public const string _vcg = "vcg";
			public const string _hal = "hal";
			public const string _zmm = "zmm";
			public const string _hbci = "hbci";
			public const string _les = "les";
			public const string _hpgl = "hpgl";
			public const string _hpid = "hpid";
			public const string _hps = "hps";
			public const string _jlt = "jlt";
			public const string _pcl = "pcl";
			public const string _pclxl = "pclxl";
			public const string _sfd_hdstx = "sfd-hdstx";
			public const string _mpy = "mpy";
			public const string _afp = "afp";
			public const string _listafp = "listafp";
			public const string _list3820 = "list3820";
			public const string _irm = "irm";
			public const string _sc = "sc";
			public const string _icc = "icc";
			public const string _icm = "icm";
			public const string _igl = "igl";
			public const string _ivp = "ivp";
			public const string _ivu = "ivu";
			public const string _igm = "igm";
			public const string _xpw = "xpw";
			public const string _xpx = "xpx";
			public const string _i2g = "i2g";
			public const string _qbo = "qbo";
			public const string _qfx = "qfx";
			public const string _rcprofile = "rcprofile";
			public const string _irp = "irp";
			public const string _xpr = "xpr";
			public const string _fcs = "fcs";
			public const string _jam = "jam";
			public const string _rms = "rms";
			public const string _jisp = "jisp";
			public const string _joda = "joda";
			public const string _ktz = "ktz";
			public const string _ktr = "ktr";
			public const string _karbon = "karbon";
			public const string _chrt = "chrt";
			public const string _kfo = "kfo";
			public const string _flw = "flw";
			public const string _kon = "kon";
			public const string _kpr = "kpr";
			public const string _kpt = "kpt";
			public const string _ksp = "ksp";
			public const string _kwd = "kwd";
			public const string _kwt = "kwt";
			public const string _htke = "htke";
			public const string _kia = "kia";
			public const string _kne = "kne";
			public const string _knp = "knp";
			public const string _skp = "skp";
			public const string _skd = "skd";
			public const string _skt = "skt";
			public const string _skm = "skm";
			public const string _sse = "sse";
			public const string _lasxml = "lasxml";
			public const string _lbd = "lbd";
			public const string _lbe = "lbe";
			public const string _123 = "123";
			public const string _apr = "apr";
			public const string _pre = "pre";
			public const string _nsf = "nsf";
			public const string _org = "org";
			public const string _scm = "scm";
			public const string _lwp = "lwp";
			public const string _portpkg = "portpkg";
			public const string _mcd = "mcd";
			public const string _mc1 = "mc1";
			public const string _cdkey = "cdkey";
			public const string _mwf = "mwf";
			public const string _mfm = "mfm";
			public const string _flo = "flo";
			public const string _igx = "igx";
			public const string _mif = "mif";
			public const string _daf = "daf";
			public const string _dis = "dis";
			public const string _mbk = "mbk";
			public const string _mqy = "mqy";
			public const string _msl = "msl";
			public const string _plc = "plc";
			public const string _txf = "txf";
			public const string _mpn = "mpn";
			public const string _mpc = "mpc";
			public const string _xul = "xul";
			public const string _cil = "cil";
			public const string _cab = "cab";
			public const string _xls = "xls";
			public const string _xlm = "xlm";
			public const string _xla = "xla";
			public const string _xlc = "xlc";
			public const string _xlt = "xlt";
			public const string _xlw = "xlw";
			public const string _xlam = "xlam";
			public const string _xlsb = "xlsb";
			public const string _xlsm = "xlsm";
			public const string _xltm = "xltm";
			public const string _eot = "eot";
			public const string _chm = "chm";
			public const string _ims = "ims";
			public const string _lrm = "lrm";
			public const string _thmx = "thmx";
			public const string _cat = "cat";
			public const string _stl = "stl";
			public const string _ppt = "ppt";
			public const string _pps = "pps";
			public const string _pot = "pot";
			public const string _ppam = "ppam";
			public const string _pptm = "pptm";
			public const string _sldm = "sldm";
			public const string _ppsm = "ppsm";
			public const string _potm = "potm";
			public const string _mpp = "mpp";
			public const string _mpt = "mpt";
			public const string _docm = "docm";
			public const string _dotm = "dotm";
			public const string _wps = "wps";
			public const string _wks = "wks";
			public const string _wcm = "wcm";
			public const string _wdb = "wdb";
			public const string _wpl = "wpl";
			public const string _xps = "xps";
			public const string _mseq = "mseq";
			public const string _mus = "mus";
			public const string _msty = "msty";
			public const string _taglet = "taglet";
			public const string _nlu = "nlu";
			public const string _ntf = "ntf";
			public const string _nitf = "nitf";
			public const string _nnd = "nnd";
			public const string _nns = "nns";
			public const string _nnw = "nnw";
			public const string _ngdat = "ngdat";
			public const string _n_gage = "n-gage";
			public const string _rpst = "rpst";
			public const string _rpss = "rpss";
			public const string _edm = "edm";
			public const string _edx = "edx";
			public const string _ext = "ext";
			public const string _odc = "odc";
			public const string _otc = "otc";
			public const string _odb = "odb";
			public const string _odf = "odf";
			public const string _odft = "odft";
			public const string _odg = "odg";
			public const string _otg = "otg";
			public const string _odi = "odi";
			public const string _oti = "oti";
			public const string _odp = "odp";
			public const string _otp = "otp";
			public const string _ods = "ods";
			public const string _ots = "ots";
			public const string _odt = "odt";
			public const string _odm = "odm";
			public const string _ott = "ott";
			public const string _oth = "oth";
			public const string _xo = "xo";
			public const string _dd2 = "dd2";
			public const string _oxt = "oxt";
			public const string _pptx = "pptx";
			public const string _sldx = "sldx";
			public const string _ppsx = "ppsx";
			public const string _potx = "potx";
			public const string _xlsx = "xlsx";
			public const string _xltx = "xltx";
			public const string _docx = "docx";
			public const string _dotx = "dotx";
			public const string _mgp = "mgp";
			public const string _dp = "dp";
			public const string _esa = "esa";
			public const string _pdb = "pdb";
			public const string _pqa = "pqa";
			public const string _oprc = "oprc";
			public const string _paw = "paw";
			public const string _str = "str";
			public const string _ei6 = "ei6";
			public const string _efif = "efif";
			public const string _wg = "wg";
			public const string _plf = "plf";
			public const string _pbd = "pbd";
			public const string _box = "box";
			public const string _mgz = "mgz";
			public const string _qps = "qps";
			public const string _ptid = "ptid";
			public const string _qxd = "qxd";
			public const string _qxt = "qxt";
			public const string _qwd = "qwd";
			public const string _qwt = "qwt";
			public const string _qxl = "qxl";
			public const string _qxb = "qxb";
			public const string _bed = "bed";
			public const string _mxl = "mxl";
			public const string _musicxml = "musicxml";
			public const string _cryptonote = "cryptonote";
			public const string _cod = "cod";
			public const string _rm = "rm";
			public const string _rmvb = "rmvb";
			public const string _link66 = "link66";
			public const string _st = "st";
			public const string _see = "see";
			public const string _sema = "sema";
			public const string _semd = "semd";
			public const string _semf = "semf";
			public const string _ifm = "ifm";
			public const string _itp = "itp";
			public const string _iif = "iif";
			public const string _ipk = "ipk";
			public const string _twd = "twd";
			public const string _twds = "twds";
			public const string _mmf = "mmf";
			public const string _teacher = "teacher";
			public const string _sdkm = "sdkm";
			public const string _sdkd = "sdkd";
			public const string _dxp = "dxp";
			public const string _sfs = "sfs";
			public const string _sdc = "sdc";
			public const string _sda = "sda";
			public const string _sdd = "sdd";
			public const string _smf = "smf";
			public const string _sdw = "sdw";
			public const string _vor = "vor";
			public const string _sgl = "sgl";
			public const string _smzip = "smzip";
			public const string _sm = "sm";
			public const string _sxc = "sxc";
			public const string _stc = "stc";
			public const string _sxd = "sxd";
			public const string _std = "std";
			public const string _sxi = "sxi";
			public const string _sti = "sti";
			public const string _sxm = "sxm";
			public const string _sxw = "sxw";
			public const string _sxg = "sxg";
			public const string _stw = "stw";
			public const string _sus = "sus";
			public const string _susp = "susp";
			public const string _svd = "svd";
			public const string _sis = "sis";
			public const string _sisx = "sisx";
			public const string _xsm = "xsm";
			public const string _bdm = "bdm";
			public const string _xdm = "xdm";
			public const string _tao = "tao";
			public const string _pcap = "pcap";
			public const string _cap = "cap";
			public const string _dmp = "dmp";
			public const string _tmo = "tmo";
			public const string _tpt = "tpt";
			public const string _mxs = "mxs";
			public const string _tra = "tra";
			public const string _ufd = "ufd";
			public const string _ufdl = "ufdl";
			public const string _utz = "utz";
			public const string _umj = "umj";
			public const string _unityweb = "unityweb";
			public const string _uoml = "uoml";
			public const string _vcx = "vcx";
			public const string _vsd = "vsd";
			public const string _vst = "vst";
			public const string _vss = "vss";
			public const string _vsw = "vsw";
			public const string _vis = "vis";
			public const string _vsf = "vsf";
			public const string _wbxml = "wbxml";
			public const string _wmlc = "wmlc";
			public const string _wmlsc = "wmlsc";
			public const string _wtb = "wtb";
			public const string _nbp = "nbp";
			public const string _wpd = "wpd";
			public const string _wqd = "wqd";
			public const string _stf = "stf";
			public const string _xar = "xar";
			public const string _xfdl = "xfdl";
			public const string _hvd = "hvd";
			public const string _hvs = "hvs";
			public const string _hvp = "hvp";
			public const string _osf = "osf";
			public const string _osfpvg = "osfpvg";
			public const string _saf = "saf";
			public const string _spf = "spf";
			public const string _cmp = "cmp";
			public const string _zir = "zir";
			public const string _zirz = "zirz";
			public const string _zaz = "zaz";
			public const string _vxml = "vxml";
			public const string _wgt = "wgt";
			public const string _hlp = "hlp";
			public const string _wsdl = "wsdl";
			public const string _wspolicy = "wspolicy";
			public const string _7z = "7z";
			public const string _abw = "abw";
			public const string _ace = "ace";
			public const string _dmg = "dmg";
			public const string _aab = "aab";
			public const string _x32 = "x32";
			public const string _u32 = "u32";
			public const string _vox = "vox";
			public const string _aam = "aam";
			public const string _aas = "aas";
			public const string _bcpio = "bcpio";
			public const string _torrent = "torrent";
			public const string _blb = "blb";
			public const string _blorb = "blorb";
			public const string _bz = "bz";
			public const string _bz2 = "bz2";
			public const string _boz = "boz";
			public const string _cbr = "cbr";
			public const string _cba = "cba";
			public const string _cbt = "cbt";
			public const string _cbz = "cbz";
			public const string _cb7 = "cb7";
			public const string _vcd = "vcd";
			public const string _cfs = "cfs";
			public const string _chat = "chat";
			public const string _pgn = "pgn";
			public const string _nsc = "nsc";
			public const string _cpio = "cpio";
			public const string _csh = "csh";
			public const string _deb = "deb";
			public const string _udeb = "udeb";
			public const string _dgc = "dgc";
			public const string _dir = "dir";
			public const string _dcr = "dcr";
			public const string _dxr = "dxr";
			public const string _cst = "cst";
			public const string _cct = "cct";
			public const string _cxt = "cxt";
			public const string _w3d = "w3d";
			public const string _fgd = "fgd";
			public const string _swa = "swa";
			public const string _wad = "wad";
			public const string _ncx = "ncx";
			public const string _dtb = "dtb";
			public const string _res = "res";
			public const string _dvi = "dvi";
			public const string _evy = "evy";
			public const string _eva = "eva";
			public const string _bdf = "bdf";
			public const string _gsf = "gsf";
			public const string _psf = "psf";
			public const string _pcf = "pcf";
			public const string _snf = "snf";
			public const string _pfa = "pfa";
			public const string _pfb = "pfb";
			public const string _pfm = "pfm";
			public const string _afm = "afm";
			public const string _arc = "arc";
			public const string _spl = "spl";
			public const string _gca = "gca";
			public const string _ulx = "ulx";
			public const string _gnumeric = "gnumeric";
			public const string _gramps = "gramps";
			public const string _gtar = "gtar";
			public const string _hdf = "hdf";
			public const string _install = "install";
			public const string _iso = "iso";
			public const string _jnlp = "jnlp";
			public const string _latex = "latex";
			public const string _lzh = "lzh";
			public const string _lha = "lha";
			public const string _mie = "mie";
			public const string _prc = "prc";
			public const string _mobi = "mobi";
			public const string _application = "application";
			public const string _lnk = "lnk";
			public const string _wmd = "wmd";
			public const string _wmz = "wmz";
			public const string _xbap = "xbap";
			public const string _mdb = "mdb";
			public const string _obd = "obd";
			public const string _crd = "crd";
			public const string _clp = "clp";
			public const string _exe = "exe";
			public const string _dll = "dll";
			public const string _com = "com";
			public const string _bat = "bat";
			public const string _msi = "msi";
			public const string _mvb = "mvb";
			public const string _m13 = "m13";
			public const string _m14 = "m14";
			public const string _wmf = "wmf";
			public const string _emf = "emf";
			public const string _emz = "emz";
			public const string _mny = "mny";
			public const string _pub = "pub";
			public const string _scd = "scd";
			public const string _trm = "trm";
			public const string _wri = "wri";
			public const string _nc = "nc";
			public const string _cdf = "cdf";
			public const string _nzb = "nzb";
			public const string _p12 = "p12";
			public const string _pfx = "pfx";
			public const string _p7b = "p7b";
			public const string _spc = "spc";
			public const string _p7r = "p7r";
			public const string _rar = "rar";
			public const string _ris = "ris";
			public const string _sh = "sh";
			public const string _shar = "shar";
			public const string _swf = "swf";
			public const string _xap = "xap";
			public const string _sql = "sql";
			public const string _sit = "sit";
			public const string _sitx = "sitx";
			public const string _srt = "srt";
			public const string _sv4cpio = "sv4cpio";
			public const string _sv4crc = "sv4crc";
			public const string _t3 = "t3";
			public const string _gam = "gam";
			public const string _tar = "tar";
			public const string _tcl = "tcl";
			public const string _tex = "tex";
			public const string _tfm = "tfm";
			public const string _texinfo = "texinfo";
			public const string _texi = "texi";
			public const string _obj = "obj";
			public const string _ustar = "ustar";
			public const string _src = "src";
			public const string _der = "der";
			public const string _crt = "crt";
			public const string _fig = "fig";
			public const string _xlf = "xlf";
			public const string _xpi = "xpi";
			public const string _xz = "xz";
			public const string _z1 = "z1";
			public const string _z2 = "z2";
			public const string _z3 = "z3";
			public const string _z4 = "z4";
			public const string _z5 = "z5";
			public const string _z6 = "z6";
			public const string _z7 = "z7";
			public const string _z8 = "z8";
			public const string _xaml = "xaml";
			public const string _xdf = "xdf";
			public const string _xenc = "xenc";
			public const string _xhtml = "xhtml";
			public const string _xht = "xht";
			public const string _xml = "xml";
			public const string _xsl = "xsl";
			public const string _dtd = "dtd";
			public const string _xop = "xop";
			public const string _xpl = "xpl";
			public const string _xslt = "xslt";
			public const string _xspf = "xspf";
			public const string _mxml = "mxml";
			public const string _xhvml = "xhvml";
			public const string _xvml = "xvml";
			public const string _xvm = "xvm";
			public const string _yang = "yang";
			public const string _yin = "yin";
			public const string _zip = "zip";
			public const string _adp = "adp";
			public const string _au = "au";
			public const string _snd = "snd";
			public const string _mid = "mid";
			public const string _midi = "midi";
			public const string _kar = "kar";
			public const string _rmi = "rmi";
			public const string _m4a = "m4a";
			public const string _mp4a = "mp4a";
			public const string _mpga = "mpga";
			public const string _mp2 = "mp2";
			public const string _mp2a = "mp2a";
			public const string _mp3 = "mp3";
			public const string _m2a = "m2a";
			public const string _m3a = "m3a";
			public const string _oga = "oga";
			public const string _ogg = "ogg";
			public const string _spx = "spx";
			public const string _opus = "opus";
			public const string _s3m = "s3m";
			public const string _sil = "sil";
			public const string _uva = "uva";
			public const string _uvva = "uvva";
			public const string _eol = "eol";
			public const string _dra = "dra";
			public const string _dts = "dts";
			public const string _dtshd = "dtshd";
			public const string _lvp = "lvp";
			public const string _pya = "pya";
			public const string _ecelp4800 = "ecelp4800";
			public const string _ecelp7470 = "ecelp7470";
			public const string _ecelp9600 = "ecelp9600";
			public const string _rip = "rip";
			public const string _weba = "weba";
			public const string _aac = "aac";
			public const string _aif = "aif";
			public const string _aiff = "aiff";
			public const string _aifc = "aifc";
			public const string _caf = "caf";
			public const string _flac = "flac";
			public const string _mka = "mka";
			public const string _m3u = "m3u";
			public const string _wax = "wax";
			public const string _wma = "wma";
			public const string _ram = "ram";
			public const string _ra = "ra";
			public const string _rmp = "rmp";
			public const string _wav = "wav";
			public const string _xm = "xm";
			public const string _cdx = "cdx";
			public const string _cif = "cif";
			public const string _cmdf = "cmdf";
			public const string _cml = "cml";
			public const string _csml = "csml";
			public const string _xyz = "xyz";
			public const string _ttc = "ttc";
			public const string _otf = "otf";
			public const string _ttf = "ttf";
			public const string _woff = "woff";
			public const string _woff2 = "woff2";
			public const string _bmp = "bmp";
			public const string _cgm = "cgm";
			public const string _g3 = "g3";
			public const string _gif = "gif";
			public const string _ief = "ief";
			public const string _jpeg = "jpeg";
			public const string _jpg = "jpg";
			public const string _jpe = "jpe";
			public const string _ktx = "ktx";
			public const string _png = "png";
			public const string _btif = "btif";
			public const string _sgi = "sgi";
			public const string _svg = "svg";
			public const string _svgz = "svgz";
			public const string _tiff = "tiff";
			public const string _tif = "tif";
			public const string _psd = "psd";
			public const string _uvi = "uvi";
			public const string _uvvi = "uvvi";
			public const string _uvg = "uvg";
			public const string _uvvg = "uvvg";
			public const string _djvu = "djvu";
			public const string _djv = "djv";
			public const string _sub = "sub";
			public const string _dwg = "dwg";
			public const string _dxf = "dxf";
			public const string _fbs = "fbs";
			public const string _fpx = "fpx";
			public const string _fst = "fst";
			public const string _mmr = "mmr";
			public const string _rlc = "rlc";
			public const string _mdi = "mdi";
			public const string _wdp = "wdp";
			public const string _npx = "npx";
			public const string _wbmp = "wbmp";
			public const string _xif = "xif";
			public const string _webp = "webp";
			public const string _3ds = "3ds";
			public const string _ras = "ras";
			public const string _cmx = "cmx";
			public const string _fh = "fh";
			public const string _fhc = "fhc";
			public const string _fh4 = "fh4";
			public const string _fh5 = "fh5";
			public const string _fh7 = "fh7";
			public const string _ico = "ico";
			public const string _sid = "sid";
			public const string _pcx = "pcx";
			public const string _pic = "pic";
			public const string _pct = "pct";
			public const string _pnm = "pnm";
			public const string _pbm = "pbm";
			public const string _pgm = "pgm";
			public const string _ppm = "ppm";
			public const string _rgb = "rgb";
			public const string _tga = "tga";
			public const string _xbm = "xbm";
			public const string _xpm = "xpm";
			public const string _xwd = "xwd";
			public const string _eml = "eml";
			public const string _mime = "mime";
			public const string _igs = "igs";
			public const string _iges = "iges";
			public const string _msh = "msh";
			public const string _mesh = "mesh";
			public const string _silo = "silo";
			public const string _dae = "dae";
			public const string _dwf = "dwf";
			public const string _gdl = "gdl";
			public const string _gtw = "gtw";
			public const string _mts = "mts";
			public const string _vtu = "vtu";
			public const string _wrl = "wrl";
			public const string _vrml = "vrml";
			public const string _x3db = "x3db";
			public const string _x3dbz = "x3dbz";
			public const string _x3dv = "x3dv";
			public const string _x3dvz = "x3dvz";
			public const string _x3d = "x3d";
			public const string _x3dz = "x3dz";
			public const string _appcache = "appcache";
			public const string _ics = "ics";
			public const string _ifb = "ifb";
			public const string _css = "css";
			public const string _csv = "csv";
			public const string _html = "html";
			public const string _htm = "htm";
			public const string _n3 = "n3";
			public const string _txt = "txt";
			public const string _text = "text";
			public const string _conf = "conf";
			public const string _def = "def";
			public const string _list = "list";
			public const string _log = "log";
			public const string _in = "in";
			public const string _dsc = "dsc";
			public const string _rtx = "rtx";
			public const string _sgml = "sgml";
			public const string _sgm = "sgm";
			public const string _tsv = "tsv";
			public const string _t = "t";
			public const string _tr = "tr";
			public const string _roff = "roff";
			public const string _man = "man";
			public const string _me = "me";
			public const string _ms = "ms";
			public const string _ttl = "ttl";
			public const string _uri = "uri";
			public const string _uris = "uris";
			public const string _urls = "urls";
			public const string _vcard = "vcard";
			public const string _curl = "curl";
			public const string _dcurl = "dcurl";
			public const string _mcurl = "mcurl";
			public const string _scurl = "scurl";
			public const string _fly = "fly";
			public const string _flx = "flx";
			public const string _gv = "gv";
			public const string _3dml = "3dml";
			public const string _spot = "spot";
			public const string _jad = "jad";
			public const string _wml = "wml";
			public const string _wmls = "wmls";
			public const string _s = "s";
			public const string _asm = "asm";
			public const string _c = "c";
			public const string _cc = "cc";
			public const string _cxx = "cxx";
			public const string _cpp = "cpp";
			public const string _h = "h";
			public const string _hh = "hh";
			public const string _dic = "dic";
			public const string _f = "f";
			public const string _for = "for";
			public const string _f77 = "f77";
			public const string _f90 = "f90";
			public const string _java = "java";
			public const string _nfo = "nfo";
			public const string _opml = "opml";
			public const string _p = "p";
			public const string _pas = "pas";
			public const string _etx = "etx";
			public const string _sfv = "sfv";
			public const string _uu = "uu";
			public const string _vcs = "vcs";
			public const string _vcf = "vcf";
			public const string _3gp = "3gp";
			public const string _3g2 = "3g2";
			public const string _h261 = "h261";
			public const string _h263 = "h263";
			public const string _h264 = "h264";
			public const string _jpgv = "jpgv";
			public const string _jpm = "jpm";
			public const string _jpgm = "jpgm";
			public const string _mj2 = "mj2";
			public const string _mjp2 = "mjp2";
			public const string _mp4 = "mp4";
			public const string _mp4v = "mp4v";
			public const string _mpg4 = "mpg4";
			public const string _mpeg = "mpeg";
			public const string _mpg = "mpg";
			public const string _mpe = "mpe";
			public const string _m1v = "m1v";
			public const string _m2v = "m2v";
			public const string _ogv = "ogv";
			public const string _qt = "qt";
			public const string _mov = "mov";
			public const string _uvh = "uvh";
			public const string _uvvh = "uvvh";
			public const string _uvm = "uvm";
			public const string _uvvm = "uvvm";
			public const string _uvp = "uvp";
			public const string _uvvp = "uvvp";
			public const string _uvs = "uvs";
			public const string _uvvs = "uvvs";
			public const string _uvv = "uvv";
			public const string _uvvv = "uvvv";
			public const string _dvb = "dvb";
			public const string _fvt = "fvt";
			public const string _mxu = "mxu";
			public const string _m4u = "m4u";
			public const string _pyv = "pyv";
			public const string _uvu = "uvu";
			public const string _uvvu = "uvvu";
			public const string _viv = "viv";
			public const string _webm = "webm";
			public const string _f4v = "f4v";
			public const string _fli = "fli";
			public const string _flv = "flv";
			public const string _m4v = "m4v";
			public const string _mkv = "mkv";
			public const string _mk3d = "mk3d";
			public const string _mks = "mks";
			public const string _mng = "mng";
			public const string _asf = "asf";
			public const string _asx = "asx";
			public const string _vob = "vob";
			public const string _wm = "wm";
			public const string _wmv = "wmv";
			public const string _wmx = "wmx";
			public const string _wvx = "wvx";
			public const string _avi = "avi";
			public const string _movie = "movie";
			public const string _smv = "smv";
			public const string _ice = "ice";
			public const string _map = "map";
			public const string _topojson = "topojson";
			public const string _jsonld = "jsonld";
			public const string _geojson = "geojson";
			public const string _mjs = "mjs";
			public const string _wasm = "wasm";
			public const string _webmanifest = "webmanifest";
			public const string _webapp = "webapp";
			public const string _f4a = "f4a";
			public const string _f4b = "f4b";
			public const string _jxr = "jxr";
			public const string _hdp = "hdp";
			public const string _jng = "jng";
			public const string _3gpp = "3gpp";
			public const string _f4p = "f4p";
			public const string _cur = "cur";
			public const string _ear = "ear";
			public const string _war = "war";
			public const string _img = "img";
			public const string _msm = "msm";
			public const string _msp = "msp";
			public const string _safariextz = "safariextz";
			public const string _bbaw = "bbaw";
			public const string _crx = "crx";
			public const string _cco = "cco";
			public const string _jardiff = "jardiff";
			public const string _run = "run";
			public const string _oex = "oex";
			public const string _pl = "pl";
			public const string _pm = "pm";
			public const string _rpm = "rpm";
			public const string _sea = "sea";
			public const string _tk = "tk";
			public const string _pem = "pem";
			public const string _shtml = "shtml";
			public const string _md = "md";
			public const string _markdown = "markdown";
			public const string _mml = "mml";
			public const string _xloc = "xloc";
			public const string _vtt = "vtt";
			public const string _htc = "htc";
			public const string _bdoc = "bdoc";
			public const string _es = "es";
			public const string _hjson = "hjson";
			public const string _json5 = "json5";
			public const string _m4p = "m4p";
			public const string _cjs = "cjs";
			public const string _buffer = "buffer";
			public const string _raml = "raml";
			public const string _owl = "owl";
			public const string _siv = "siv";
			public const string _sieve = "sieve";
			public const string _toml = "toml";
			public const string _ubj = "ubj";
			public const string _pkpass = "pkpass";
			public const string _gdoc = "gdoc";
			public const string _gslides = "gslides";
			public const string _gsheet = "gsheet";
			public const string _msg = "msg";
			public const string _arj = "arj";
			public const string _php = "php";
			public const string _kdbx = "kdbx";
			public const string _luac = "luac";
			public const string _pac = "pac";
			public const string _hdd = "hdd";
			public const string _ova = "ova";
			public const string _ovf = "ovf";
			public const string _vbox = "vbox";
			public const string _vbox_extpack = "vbox-extpack";
			public const string _vdi = "vdi";
			public const string _vhd = "vhd";
			public const string _vmdk = "vmdk";
			public const string _xsd = "xsd";
			public const string _rng = "rng";
			public const string _apng = "apng";
			public const string _avif = "avif";
			public const string _heic = "heic";
			public const string _heics = "heics";
			public const string _heif = "heif";
			public const string _heifs = "heifs";
			public const string _jp2 = "jp2";
			public const string _jpg2 = "jpg2";
			public const string _jpx = "jpx";
			public const string _jpf = "jpf";
			public const string _dds = "dds";
			public const string _manifest = "manifest";
			public const string _coffee = "coffee";
			public const string _litcoffee = "litcoffee";
			public const string _jade = "jade";
			public const string _jsx = "jsx";
			public const string _less = "less";
			public const string _mdx = "mdx";
			public const string _ini = "ini";
			public const string _shex = "shex";
			public const string _slim = "slim";
			public const string _slm = "slm";
			public const string _stylus = "stylus";
			public const string _styl = "styl";
			public const string _hbs = "hbs";
			public const string _lua = "lua";
			public const string _mkd = "mkd";
			public const string _pde = "pde";
			public const string _sass = "sass";
			public const string _scss = "scss";
			public const string _ymp = "ymp";
			public const string _yaml = "yaml";
			public const string _yml = "yml";

		}

        // List of all available extensions, used to build the dictionary
        internal static readonly Lazy<string[]> ALL_EXTS = new Lazy<string[]>(() => new [] {
            Extensions._ez,
            Extensions._aw,
            Extensions._atom,
            Extensions._atomcat,
            Extensions._atomsvc,
            Extensions._ccxml,
            Extensions._cdmia,
            Extensions._cdmic,
            Extensions._cdmid,
            Extensions._cdmio,
            Extensions._cdmiq,
            Extensions._cu,
            Extensions._davmount,
            Extensions._dbk,
            Extensions._dssc,
            Extensions._xdssc,
            Extensions._ecma,
            Extensions._emma,
            Extensions._epub,
            Extensions._exi,
            Extensions._pfr,
            Extensions._gml,
            Extensions._gpx,
            Extensions._gxf,
            Extensions._stk,
            Extensions._ink,
            Extensions._inkml,
            Extensions._ipfix,
            Extensions._jar,
            Extensions._ser,
            Extensions._class,
            Extensions._js,
            Extensions._json,
            Extensions._jsonml,
            Extensions._lostxml,
            Extensions._hqx,
            Extensions._cpt,
            Extensions._mads,
            Extensions._mrc,
            Extensions._mrcx,
            Extensions._ma,
            Extensions._nb,
            Extensions._mb,
            Extensions._mathml,
            Extensions._mbox,
            Extensions._mscml,
            Extensions._metalink,
            Extensions._meta4,
            Extensions._mets,
            Extensions._mods,
            Extensions._m21,
            Extensions._mp21,
            Extensions._mp4s,
            Extensions._doc,
            Extensions._dot,
            Extensions._mxf,
            Extensions._bin,
            Extensions._dms,
            Extensions._lrf,
            Extensions._mar,
            Extensions._so,
            Extensions._dist,
            Extensions._distz,
            Extensions._pkg,
            Extensions._bpk,
            Extensions._dump,
            Extensions._elc,
            Extensions._deploy,
            Extensions._oda,
            Extensions._opf,
            Extensions._ogx,
            Extensions._omdoc,
            Extensions._onetoc,
            Extensions._onetoc2,
            Extensions._onetmp,
            Extensions._onepkg,
            Extensions._oxps,
            Extensions._xer,
            Extensions._pdf,
            Extensions._pgp,
            Extensions._asc,
            Extensions._sig,
            Extensions._prf,
            Extensions._p10,
            Extensions._p7m,
            Extensions._p7c,
            Extensions._p7s,
            Extensions._p8,
            Extensions._ac,
            Extensions._cer,
            Extensions._crl,
            Extensions._pkipath,
            Extensions._pki,
            Extensions._pls,
            Extensions._ai,
            Extensions._eps,
            Extensions._ps,
            Extensions._cww,
            Extensions._pskcxml,
            Extensions._rdf,
            Extensions._rif,
            Extensions._rnc,
            Extensions._rl,
            Extensions._rld,
            Extensions._rs,
            Extensions._gbr,
            Extensions._mft,
            Extensions._roa,
            Extensions._rsd,
            Extensions._rss,
            Extensions._rtf,
            Extensions._sbml,
            Extensions._scq,
            Extensions._scs,
            Extensions._spq,
            Extensions._spp,
            Extensions._sdp,
            Extensions._setpay,
            Extensions._setreg,
            Extensions._shf,
            Extensions._smi,
            Extensions._smil,
            Extensions._rq,
            Extensions._srx,
            Extensions._gram,
            Extensions._grxml,
            Extensions._sru,
            Extensions._ssdl,
            Extensions._ssml,
            Extensions._tei,
            Extensions._teicorpus,
            Extensions._tfi,
            Extensions._tsd,
            Extensions._plb,
            Extensions._psb,
            Extensions._pvb,
            Extensions._tcap,
            Extensions._pwn,
            Extensions._aso,
            Extensions._imp,
            Extensions._acu,
            Extensions._atc,
            Extensions._acutc,
            Extensions._air,
            Extensions._fcdt,
            Extensions._fxp,
            Extensions._fxpl,
            Extensions._xdp,
            Extensions._xfdf,
            Extensions._ahead,
            Extensions._azf,
            Extensions._azs,
            Extensions._azw,
            Extensions._acc,
            Extensions._ami,
            Extensions._apk,
            Extensions._cii,
            Extensions._fti,
            Extensions._atx,
            Extensions._mpkg,
            Extensions._m3u8,
            Extensions._swi,
            Extensions._iota,
            Extensions._aep,
            Extensions._mpm,
            Extensions._bmi,
            Extensions._rep,
            Extensions._cdxml,
            Extensions._mmd,
            Extensions._cdy,
            Extensions._cla,
            Extensions._rp9,
            Extensions._c4g,
            Extensions._c4d,
            Extensions._c4f,
            Extensions._c4p,
            Extensions._c4u,
            Extensions._c11amc,
            Extensions._c11amz,
            Extensions._csp,
            Extensions._cdbcmsg,
            Extensions._cmc,
            Extensions._clkx,
            Extensions._clkk,
            Extensions._clkp,
            Extensions._clkt,
            Extensions._clkw,
            Extensions._wbs,
            Extensions._pml,
            Extensions._ppd,
            Extensions._car,
            Extensions._pcurl,
            Extensions._dart,
            Extensions._rdz,
            Extensions._uvf,
            Extensions._uvvf,
            Extensions._uvd,
            Extensions._uvvd,
            Extensions._uvt,
            Extensions._uvvt,
            Extensions._uvx,
            Extensions._uvvx,
            Extensions._uvz,
            Extensions._uvvz,
            Extensions._fe_launch,
            Extensions._dna,
            Extensions._mlp,
            Extensions._dpg,
            Extensions._dfac,
            Extensions._kpxx,
            Extensions._ait,
            Extensions._svc,
            Extensions._geo,
            Extensions._mag,
            Extensions._nml,
            Extensions._esf,
            Extensions._msf,
            Extensions._qam,
            Extensions._slt,
            Extensions._ssf,
            Extensions._es3,
            Extensions._et3,
            Extensions._ez2,
            Extensions._ez3,
            Extensions._fdf,
            Extensions._mseed,
            Extensions._seed,
            Extensions._dataless,
            Extensions._gph,
            Extensions._ftc,
            Extensions._fm,
            Extensions._frame,
            Extensions._maker,
            Extensions._book,
            Extensions._fnc,
            Extensions._ltf,
            Extensions._fsc,
            Extensions._oas,
            Extensions._oa2,
            Extensions._oa3,
            Extensions._fg5,
            Extensions._bh2,
            Extensions._ddd,
            Extensions._xdw,
            Extensions._xbd,
            Extensions._fzs,
            Extensions._txd,
            Extensions._ggb,
            Extensions._ggt,
            Extensions._gex,
            Extensions._gre,
            Extensions._gxt,
            Extensions._g2w,
            Extensions._g3w,
            Extensions._gmx,
            Extensions._kml,
            Extensions._kmz,
            Extensions._gqf,
            Extensions._gqs,
            Extensions._gac,
            Extensions._ghf,
            Extensions._gim,
            Extensions._grv,
            Extensions._gtm,
            Extensions._tpl,
            Extensions._vcg,
            Extensions._hal,
            Extensions._zmm,
            Extensions._hbci,
            Extensions._les,
            Extensions._hpgl,
            Extensions._hpid,
            Extensions._hps,
            Extensions._jlt,
            Extensions._pcl,
            Extensions._pclxl,
            Extensions._sfd_hdstx,
            Extensions._mpy,
            Extensions._afp,
            Extensions._listafp,
            Extensions._list3820,
            Extensions._irm,
            Extensions._sc,
            Extensions._icc,
            Extensions._icm,
            Extensions._igl,
            Extensions._ivp,
            Extensions._ivu,
            Extensions._igm,
            Extensions._xpw,
            Extensions._xpx,
            Extensions._i2g,
            Extensions._qbo,
            Extensions._qfx,
            Extensions._rcprofile,
            Extensions._irp,
            Extensions._xpr,
            Extensions._fcs,
            Extensions._jam,
            Extensions._rms,
            Extensions._jisp,
            Extensions._joda,
            Extensions._ktz,
            Extensions._ktr,
            Extensions._karbon,
            Extensions._chrt,
            Extensions._kfo,
            Extensions._flw,
            Extensions._kon,
            Extensions._kpr,
            Extensions._kpt,
            Extensions._ksp,
            Extensions._kwd,
            Extensions._kwt,
            Extensions._htke,
            Extensions._kia,
            Extensions._kne,
            Extensions._knp,
            Extensions._skp,
            Extensions._skd,
            Extensions._skt,
            Extensions._skm,
            Extensions._sse,
            Extensions._lasxml,
            Extensions._lbd,
            Extensions._lbe,
            Extensions._123,
            Extensions._apr,
            Extensions._pre,
            Extensions._nsf,
            Extensions._org,
            Extensions._scm,
            Extensions._lwp,
            Extensions._portpkg,
            Extensions._mcd,
            Extensions._mc1,
            Extensions._cdkey,
            Extensions._mwf,
            Extensions._mfm,
            Extensions._flo,
            Extensions._igx,
            Extensions._mif,
            Extensions._daf,
            Extensions._dis,
            Extensions._mbk,
            Extensions._mqy,
            Extensions._msl,
            Extensions._plc,
            Extensions._txf,
            Extensions._mpn,
            Extensions._mpc,
            Extensions._xul,
            Extensions._cil,
            Extensions._cab,
            Extensions._xls,
            Extensions._xlm,
            Extensions._xla,
            Extensions._xlc,
            Extensions._xlt,
            Extensions._xlw,
            Extensions._xlam,
            Extensions._xlsb,
            Extensions._xlsm,
            Extensions._xltm,
            Extensions._eot,
            Extensions._chm,
            Extensions._ims,
            Extensions._lrm,
            Extensions._thmx,
            Extensions._cat,
            Extensions._stl,
            Extensions._ppt,
            Extensions._pps,
            Extensions._pot,
            Extensions._ppam,
            Extensions._pptm,
            Extensions._sldm,
            Extensions._ppsm,
            Extensions._potm,
            Extensions._mpp,
            Extensions._mpt,
            Extensions._docm,
            Extensions._dotm,
            Extensions._wps,
            Extensions._wks,
            Extensions._wcm,
            Extensions._wdb,
            Extensions._wpl,
            Extensions._xps,
            Extensions._mseq,
            Extensions._mus,
            Extensions._msty,
            Extensions._taglet,
            Extensions._nlu,
            Extensions._ntf,
            Extensions._nitf,
            Extensions._nnd,
            Extensions._nns,
            Extensions._nnw,
            Extensions._ngdat,
            Extensions._n_gage,
            Extensions._rpst,
            Extensions._rpss,
            Extensions._edm,
            Extensions._edx,
            Extensions._ext,
            Extensions._odc,
            Extensions._otc,
            Extensions._odb,
            Extensions._odf,
            Extensions._odft,
            Extensions._odg,
            Extensions._otg,
            Extensions._odi,
            Extensions._oti,
            Extensions._odp,
            Extensions._otp,
            Extensions._ods,
            Extensions._ots,
            Extensions._odt,
            Extensions._odm,
            Extensions._ott,
            Extensions._oth,
            Extensions._xo,
            Extensions._dd2,
            Extensions._oxt,
            Extensions._pptx,
            Extensions._sldx,
            Extensions._ppsx,
            Extensions._potx,
            Extensions._xlsx,
            Extensions._xltx,
            Extensions._docx,
            Extensions._dotx,
            Extensions._mgp,
            Extensions._dp,
            Extensions._esa,
            Extensions._pdb,
            Extensions._pqa,
            Extensions._oprc,
            Extensions._paw,
            Extensions._str,
            Extensions._ei6,
            Extensions._efif,
            Extensions._wg,
            Extensions._plf,
            Extensions._pbd,
            Extensions._box,
            Extensions._mgz,
            Extensions._qps,
            Extensions._ptid,
            Extensions._qxd,
            Extensions._qxt,
            Extensions._qwd,
            Extensions._qwt,
            Extensions._qxl,
            Extensions._qxb,
            Extensions._bed,
            Extensions._mxl,
            Extensions._musicxml,
            Extensions._cryptonote,
            Extensions._cod,
            Extensions._rm,
            Extensions._rmvb,
            Extensions._link66,
            Extensions._st,
            Extensions._see,
            Extensions._sema,
            Extensions._semd,
            Extensions._semf,
            Extensions._ifm,
            Extensions._itp,
            Extensions._iif,
            Extensions._ipk,
            Extensions._twd,
            Extensions._twds,
            Extensions._mmf,
            Extensions._teacher,
            Extensions._sdkm,
            Extensions._sdkd,
            Extensions._dxp,
            Extensions._sfs,
            Extensions._sdc,
            Extensions._sda,
            Extensions._sdd,
            Extensions._smf,
            Extensions._sdw,
            Extensions._vor,
            Extensions._sgl,
            Extensions._smzip,
            Extensions._sm,
            Extensions._sxc,
            Extensions._stc,
            Extensions._sxd,
            Extensions._std,
            Extensions._sxi,
            Extensions._sti,
            Extensions._sxm,
            Extensions._sxw,
            Extensions._sxg,
            Extensions._stw,
            Extensions._sus,
            Extensions._susp,
            Extensions._svd,
            Extensions._sis,
            Extensions._sisx,
            Extensions._xsm,
            Extensions._bdm,
            Extensions._xdm,
            Extensions._tao,
            Extensions._pcap,
            Extensions._cap,
            Extensions._dmp,
            Extensions._tmo,
            Extensions._tpt,
            Extensions._mxs,
            Extensions._tra,
            Extensions._ufd,
            Extensions._ufdl,
            Extensions._utz,
            Extensions._umj,
            Extensions._unityweb,
            Extensions._uoml,
            Extensions._vcx,
            Extensions._vsd,
            Extensions._vst,
            Extensions._vss,
            Extensions._vsw,
            Extensions._vis,
            Extensions._vsf,
            Extensions._wbxml,
            Extensions._wmlc,
            Extensions._wmlsc,
            Extensions._wtb,
            Extensions._nbp,
            Extensions._wpd,
            Extensions._wqd,
            Extensions._stf,
            Extensions._xar,
            Extensions._xfdl,
            Extensions._hvd,
            Extensions._hvs,
            Extensions._hvp,
            Extensions._osf,
            Extensions._osfpvg,
            Extensions._saf,
            Extensions._spf,
            Extensions._cmp,
            Extensions._zir,
            Extensions._zirz,
            Extensions._zaz,
            Extensions._vxml,
            Extensions._wgt,
            Extensions._hlp,
            Extensions._wsdl,
            Extensions._wspolicy,
            Extensions._7z,
            Extensions._abw,
            Extensions._ace,
            Extensions._dmg,
            Extensions._aab,
            Extensions._x32,
            Extensions._u32,
            Extensions._vox,
            Extensions._aam,
            Extensions._aas,
            Extensions._bcpio,
            Extensions._torrent,
            Extensions._blb,
            Extensions._blorb,
            Extensions._bz,
            Extensions._bz2,
            Extensions._boz,
            Extensions._cbr,
            Extensions._cba,
            Extensions._cbt,
            Extensions._cbz,
            Extensions._cb7,
            Extensions._vcd,
            Extensions._cfs,
            Extensions._chat,
            Extensions._pgn,
            Extensions._nsc,
            Extensions._cpio,
            Extensions._csh,
            Extensions._deb,
            Extensions._udeb,
            Extensions._dgc,
            Extensions._dir,
            Extensions._dcr,
            Extensions._dxr,
            Extensions._cst,
            Extensions._cct,
            Extensions._cxt,
            Extensions._w3d,
            Extensions._fgd,
            Extensions._swa,
            Extensions._wad,
            Extensions._ncx,
            Extensions._dtb,
            Extensions._res,
            Extensions._dvi,
            Extensions._evy,
            Extensions._eva,
            Extensions._bdf,
            Extensions._gsf,
            Extensions._psf,
            Extensions._pcf,
            Extensions._snf,
            Extensions._pfa,
            Extensions._pfb,
            Extensions._pfm,
            Extensions._afm,
            Extensions._arc,
            Extensions._spl,
            Extensions._gca,
            Extensions._ulx,
            Extensions._gnumeric,
            Extensions._gramps,
            Extensions._gtar,
            Extensions._hdf,
            Extensions._install,
            Extensions._iso,
            Extensions._jnlp,
            Extensions._latex,
            Extensions._lzh,
            Extensions._lha,
            Extensions._mie,
            Extensions._prc,
            Extensions._mobi,
            Extensions._application,
            Extensions._lnk,
            Extensions._wmd,
            Extensions._wmz,
            Extensions._xbap,
            Extensions._mdb,
            Extensions._obd,
            Extensions._crd,
            Extensions._clp,
            Extensions._exe,
            Extensions._dll,
            Extensions._com,
            Extensions._bat,
            Extensions._msi,
            Extensions._mvb,
            Extensions._m13,
            Extensions._m14,
            Extensions._wmf,
            Extensions._emf,
            Extensions._emz,
            Extensions._mny,
            Extensions._pub,
            Extensions._scd,
            Extensions._trm,
            Extensions._wri,
            Extensions._nc,
            Extensions._cdf,
            Extensions._nzb,
            Extensions._p12,
            Extensions._pfx,
            Extensions._p7b,
            Extensions._spc,
            Extensions._p7r,
            Extensions._rar,
            Extensions._ris,
            Extensions._sh,
            Extensions._shar,
            Extensions._swf,
            Extensions._xap,
            Extensions._sql,
            Extensions._sit,
            Extensions._sitx,
            Extensions._srt,
            Extensions._sv4cpio,
            Extensions._sv4crc,
            Extensions._t3,
            Extensions._gam,
            Extensions._tar,
            Extensions._tcl,
            Extensions._tex,
            Extensions._tfm,
            Extensions._texinfo,
            Extensions._texi,
            Extensions._obj,
            Extensions._ustar,
            Extensions._src,
            Extensions._der,
            Extensions._crt,
            Extensions._fig,
            Extensions._xlf,
            Extensions._xpi,
            Extensions._xz,
            Extensions._z1,
            Extensions._z2,
            Extensions._z3,
            Extensions._z4,
            Extensions._z5,
            Extensions._z6,
            Extensions._z7,
            Extensions._z8,
            Extensions._xaml,
            Extensions._xdf,
            Extensions._xenc,
            Extensions._xhtml,
            Extensions._xht,
            Extensions._xml,
            Extensions._xsl,
            Extensions._dtd,
            Extensions._xop,
            Extensions._xpl,
            Extensions._xslt,
            Extensions._xspf,
            Extensions._mxml,
            Extensions._xhvml,
            Extensions._xvml,
            Extensions._xvm,
            Extensions._yang,
            Extensions._yin,
            Extensions._zip,
            Extensions._adp,
            Extensions._au,
            Extensions._snd,
            Extensions._mid,
            Extensions._midi,
            Extensions._kar,
            Extensions._rmi,
            Extensions._m4a,
            Extensions._mp4a,
            Extensions._mpga,
            Extensions._mp2,
            Extensions._mp2a,
            Extensions._mp3,
            Extensions._m2a,
            Extensions._m3a,
            Extensions._oga,
            Extensions._ogg,
            Extensions._spx,
            Extensions._opus,
            Extensions._s3m,
            Extensions._sil,
            Extensions._uva,
            Extensions._uvva,
            Extensions._eol,
            Extensions._dra,
            Extensions._dts,
            Extensions._dtshd,
            Extensions._lvp,
            Extensions._pya,
            Extensions._ecelp4800,
            Extensions._ecelp7470,
            Extensions._ecelp9600,
            Extensions._rip,
            Extensions._weba,
            Extensions._aac,
            Extensions._aif,
            Extensions._aiff,
            Extensions._aifc,
            Extensions._caf,
            Extensions._flac,
            Extensions._mka,
            Extensions._m3u,
            Extensions._wax,
            Extensions._wma,
            Extensions._ram,
            Extensions._ra,
            Extensions._rmp,
            Extensions._wav,
            Extensions._xm,
            Extensions._cdx,
            Extensions._cif,
            Extensions._cmdf,
            Extensions._cml,
            Extensions._csml,
            Extensions._xyz,
            Extensions._ttc,
            Extensions._otf,
            Extensions._ttf,
            Extensions._woff,
            Extensions._woff2,
            Extensions._bmp,
            Extensions._cgm,
            Extensions._g3,
            Extensions._gif,
            Extensions._ief,
            Extensions._jpeg,
            Extensions._jpg,
            Extensions._jpe,
            Extensions._ktx,
            Extensions._png,
            Extensions._btif,
            Extensions._sgi,
            Extensions._svg,
            Extensions._svgz,
            Extensions._tiff,
            Extensions._tif,
            Extensions._psd,
            Extensions._uvi,
            Extensions._uvvi,
            Extensions._uvg,
            Extensions._uvvg,
            Extensions._djvu,
            Extensions._djv,
            Extensions._sub,
            Extensions._dwg,
            Extensions._dxf,
            Extensions._fbs,
            Extensions._fpx,
            Extensions._fst,
            Extensions._mmr,
            Extensions._rlc,
            Extensions._mdi,
            Extensions._wdp,
            Extensions._npx,
            Extensions._wbmp,
            Extensions._xif,
            Extensions._webp,
            Extensions._3ds,
            Extensions._ras,
            Extensions._cmx,
            Extensions._fh,
            Extensions._fhc,
            Extensions._fh4,
            Extensions._fh5,
            Extensions._fh7,
            Extensions._ico,
            Extensions._sid,
            Extensions._pcx,
            Extensions._pic,
            Extensions._pct,
            Extensions._pnm,
            Extensions._pbm,
            Extensions._pgm,
            Extensions._ppm,
            Extensions._rgb,
            Extensions._tga,
            Extensions._xbm,
            Extensions._xpm,
            Extensions._xwd,
            Extensions._eml,
            Extensions._mime,
            Extensions._igs,
            Extensions._iges,
            Extensions._msh,
            Extensions._mesh,
            Extensions._silo,
            Extensions._dae,
            Extensions._dwf,
            Extensions._gdl,
            Extensions._gtw,
            Extensions._mts,
            Extensions._vtu,
            Extensions._wrl,
            Extensions._vrml,
            Extensions._x3db,
            Extensions._x3dbz,
            Extensions._x3dv,
            Extensions._x3dvz,
            Extensions._x3d,
            Extensions._x3dz,
            Extensions._appcache,
            Extensions._ics,
            Extensions._ifb,
            Extensions._css,
            Extensions._csv,
            Extensions._html,
            Extensions._htm,
            Extensions._n3,
            Extensions._txt,
            Extensions._text,
            Extensions._conf,
            Extensions._def,
            Extensions._list,
            Extensions._log,
            Extensions._in,
            Extensions._dsc,
            Extensions._rtx,
            Extensions._sgml,
            Extensions._sgm,
            Extensions._tsv,
            Extensions._t,
            Extensions._tr,
            Extensions._roff,
            Extensions._man,
            Extensions._me,
            Extensions._ms,
            Extensions._ttl,
            Extensions._uri,
            Extensions._uris,
            Extensions._urls,
            Extensions._vcard,
            Extensions._curl,
            Extensions._dcurl,
            Extensions._mcurl,
            Extensions._scurl,
            Extensions._fly,
            Extensions._flx,
            Extensions._gv,
            Extensions._3dml,
            Extensions._spot,
            Extensions._jad,
            Extensions._wml,
            Extensions._wmls,
            Extensions._s,
            Extensions._asm,
            Extensions._c,
            Extensions._cc,
            Extensions._cxx,
            Extensions._cpp,
            Extensions._h,
            Extensions._hh,
            Extensions._dic,
            Extensions._f,
            Extensions._for,
            Extensions._f77,
            Extensions._f90,
            Extensions._java,
            Extensions._nfo,
            Extensions._opml,
            Extensions._p,
            Extensions._pas,
            Extensions._etx,
            Extensions._sfv,
            Extensions._uu,
            Extensions._vcs,
            Extensions._vcf,
            Extensions._3gp,
            Extensions._3g2,
            Extensions._h261,
            Extensions._h263,
            Extensions._h264,
            Extensions._jpgv,
            Extensions._jpm,
            Extensions._jpgm,
            Extensions._mj2,
            Extensions._mjp2,
            Extensions._mp4,
            Extensions._mp4v,
            Extensions._mpg4,
            Extensions._mpeg,
            Extensions._mpg,
            Extensions._mpe,
            Extensions._m1v,
            Extensions._m2v,
            Extensions._ogv,
            Extensions._qt,
            Extensions._mov,
            Extensions._uvh,
            Extensions._uvvh,
            Extensions._uvm,
            Extensions._uvvm,
            Extensions._uvp,
            Extensions._uvvp,
            Extensions._uvs,
            Extensions._uvvs,
            Extensions._uvv,
            Extensions._uvvv,
            Extensions._dvb,
            Extensions._fvt,
            Extensions._mxu,
            Extensions._m4u,
            Extensions._pyv,
            Extensions._uvu,
            Extensions._uvvu,
            Extensions._viv,
            Extensions._webm,
            Extensions._f4v,
            Extensions._fli,
            Extensions._flv,
            Extensions._m4v,
            Extensions._mkv,
            Extensions._mk3d,
            Extensions._mks,
            Extensions._mng,
            Extensions._asf,
            Extensions._asx,
            Extensions._vob,
            Extensions._wm,
            Extensions._wmv,
            Extensions._wmx,
            Extensions._wvx,
            Extensions._avi,
            Extensions._movie,
            Extensions._smv,
            Extensions._ice,
            Extensions._map,
            Extensions._topojson,
            Extensions._jsonld,
            Extensions._geojson,
            Extensions._mjs,
            Extensions._wasm,
            Extensions._webmanifest,
            Extensions._webapp,
            Extensions._f4a,
            Extensions._f4b,
            Extensions._jxr,
            Extensions._hdp,
            Extensions._jng,
            Extensions._3gpp,
            Extensions._f4p,
            Extensions._cur,
            Extensions._ear,
            Extensions._war,
            Extensions._img,
            Extensions._msm,
            Extensions._msp,
            Extensions._safariextz,
            Extensions._bbaw,
            Extensions._crx,
            Extensions._cco,
            Extensions._jardiff,
            Extensions._run,
            Extensions._oex,
            Extensions._pl,
            Extensions._pm,
            Extensions._rpm,
            Extensions._sea,
            Extensions._tk,
            Extensions._pem,
            Extensions._shtml,
            Extensions._md,
            Extensions._markdown,
            Extensions._mml,
            Extensions._xloc,
            Extensions._vtt,
            Extensions._htc,
            Extensions._bdoc,
            Extensions._es,
            Extensions._hjson,
            Extensions._json5,
            Extensions._m4p,
            Extensions._cjs,
            Extensions._buffer,
            Extensions._raml,
            Extensions._owl,
            Extensions._siv,
            Extensions._sieve,
            Extensions._toml,
            Extensions._ubj,
            Extensions._pkpass,
            Extensions._gdoc,
            Extensions._gslides,
            Extensions._gsheet,
            Extensions._msg,
            Extensions._arj,
            Extensions._php,
            Extensions._kdbx,
            Extensions._luac,
            Extensions._pac,
            Extensions._hdd,
            Extensions._ova,
            Extensions._ovf,
            Extensions._vbox,
            Extensions._vbox_extpack,
            Extensions._vdi,
            Extensions._vhd,
            Extensions._vmdk,
            Extensions._xsd,
            Extensions._rng,
            Extensions._apng,
            Extensions._avif,
            Extensions._heic,
            Extensions._heics,
            Extensions._heif,
            Extensions._heifs,
            Extensions._jp2,
            Extensions._jpg2,
            Extensions._jpx,
            Extensions._jpf,
            Extensions._dds,
            Extensions._manifest,
            Extensions._coffee,
            Extensions._litcoffee,
            Extensions._jade,
            Extensions._jsx,
            Extensions._less,
            Extensions._mdx,
            Extensions._ini,
            Extensions._shex,
            Extensions._slim,
            Extensions._slm,
            Extensions._stylus,
            Extensions._styl,
            Extensions._hbs,
            Extensions._lua,
            Extensions._mkd,
            Extensions._pde,
            Extensions._sass,
            Extensions._scss,
            Extensions._ymp,
            Extensions._yaml,
            Extensions._yml,
        });


        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        internal static string LookupType(string type)
        {
            switch (type)
            {
			case Extensions._ez:
					return Ez;

			case Extensions._aw:
					return Aw;

			case Extensions._atom:
					return Atom;

			case Extensions._atomcat:
					return Atomcat;

			case Extensions._atomsvc:
					return Atomsvc;

			case Extensions._ccxml:
					return Ccxml;

			case Extensions._cdmia:
					return Cdmia;

			case Extensions._cdmic:
					return Cdmic;

			case Extensions._cdmid:
					return Cdmid;

			case Extensions._cdmio:
					return Cdmio;

			case Extensions._cdmiq:
					return Cdmiq;

			case Extensions._cu:
					return Cu;

			case Extensions._davmount:
					return Davmount;

			case Extensions._dbk:
					return Dbk;

			case Extensions._dssc:
					return Dssc;

			case Extensions._xdssc:
					return Xdssc;

			case Extensions._ecma:
			case Extensions._es:
					return Ecma;

			case Extensions._emma:
					return Emma;

			case Extensions._epub:
					return Epub;

			case Extensions._exi:
					return Exi;

			case Extensions._pfr:
					return Pfr;

			case Extensions._gml:
					return Gml;

			case Extensions._gpx:
					return Gpx;

			case Extensions._gxf:
					return Gxf;

			case Extensions._stk:
					return Stk;

			case Extensions._ink:
			case Extensions._inkml:
					return Ink;

			case Extensions._ipfix:
					return Ipfix;

			case Extensions._jar:
			case Extensions._ear:
			case Extensions._war:
					return Jar;

			case Extensions._ser:
					return Ser;

			case Extensions._class:
					return Class;

			case Extensions._js:
					return Js;

			case Extensions._json:
			case Extensions._map:
			case Extensions._topojson:
					return Json;

			case Extensions._jsonml:
					return Jsonml;

			case Extensions._lostxml:
					return Lostxml;

			case Extensions._hqx:
					return Hqx;

			case Extensions._cpt:
					return Cpt;

			case Extensions._mads:
					return Mads;

			case Extensions._mrc:
					return Mrc;

			case Extensions._mrcx:
					return Mrcx;

			case Extensions._ma:
			case Extensions._nb:
			case Extensions._mb:
					return Ma;

			case Extensions._mathml:
					return Mathml;

			case Extensions._mbox:
					return Mbox;

			case Extensions._mscml:
					return Mscml;

			case Extensions._metalink:
					return Metalink;

			case Extensions._meta4:
					return Meta4;

			case Extensions._mets:
					return Mets;

			case Extensions._mods:
					return Mods;

			case Extensions._m21:
			case Extensions._mp21:
					return M21;

			case Extensions._mp4s:
			case Extensions._m4p:
					return Mp4s;

			case Extensions._doc:
			case Extensions._dot:
					return Doc;

			case Extensions._mxf:
					return Mxf;

			case Extensions._bin:
			case Extensions._dms:
			case Extensions._lrf:
			case Extensions._mar:
			case Extensions._so:
			case Extensions._dist:
			case Extensions._distz:
			case Extensions._pkg:
			case Extensions._bpk:
			case Extensions._dump:
			case Extensions._elc:
			case Extensions._deploy:
			case Extensions._img:
			case Extensions._msm:
			case Extensions._msp:
			case Extensions._safariextz:
			case Extensions._buffer:
					return Bin;

			case Extensions._oda:
					return Oda;

			case Extensions._opf:
					return Opf;

			case Extensions._ogx:
					return Ogx;

			case Extensions._omdoc:
					return Omdoc;

			case Extensions._onetoc:
			case Extensions._onetoc2:
			case Extensions._onetmp:
			case Extensions._onepkg:
					return Onetoc;

			case Extensions._oxps:
					return Oxps;

			case Extensions._xer:
					return Xer;

			case Extensions._pdf:
					return Pdf;

			case Extensions._pgp:
					return Pgp;

			case Extensions._asc:
			case Extensions._sig:
					return Asc;

			case Extensions._prf:
					return Prf;

			case Extensions._p10:
					return P10;

			case Extensions._p7m:
			case Extensions._p7c:
					return P7m;

			case Extensions._p7s:
					return P7s;

			case Extensions._p8:
					return P8;

			case Extensions._ac:
					return Ac;

			case Extensions._cer:
					return Cer;

			case Extensions._crl:
					return Crl;

			case Extensions._pkipath:
					return Pkipath;

			case Extensions._pki:
					return Pki;

			case Extensions._pls:
					return Pls;

			case Extensions._ai:
			case Extensions._eps:
			case Extensions._ps:
					return Ai;

			case Extensions._cww:
					return Cww;

			case Extensions._pskcxml:
					return Pskcxml;

			case Extensions._rdf:
			case Extensions._owl:
					return Rdf;

			case Extensions._rif:
					return Rif;

			case Extensions._rnc:
					return Rnc;

			case Extensions._rl:
					return Rl;

			case Extensions._rld:
					return Rld;

			case Extensions._rs:
					return Rs;

			case Extensions._gbr:
					return Gbr;

			case Extensions._mft:
					return Mft;

			case Extensions._roa:
					return Roa;

			case Extensions._rsd:
					return Rsd;

			case Extensions._rss:
					return Rss;

			case Extensions._rtf:
					return Rtf;

			case Extensions._sbml:
					return Sbml;

			case Extensions._scq:
					return Scq;

			case Extensions._scs:
					return Scs;

			case Extensions._spq:
					return Spq;

			case Extensions._spp:
					return Spp;

			case Extensions._sdp:
					return Sdp;

			case Extensions._setpay:
					return Setpay;

			case Extensions._setreg:
					return Setreg;

			case Extensions._shf:
					return Shf;

			case Extensions._smi:
			case Extensions._smil:
					return Smi;

			case Extensions._rq:
					return Rq;

			case Extensions._srx:
					return Srx;

			case Extensions._gram:
					return Gram;

			case Extensions._grxml:
					return Grxml;

			case Extensions._sru:
					return Sru;

			case Extensions._ssdl:
					return Ssdl;

			case Extensions._ssml:
					return Ssml;

			case Extensions._tei:
			case Extensions._teicorpus:
					return Tei;

			case Extensions._tfi:
					return Tfi;

			case Extensions._tsd:
					return Tsd;

			case Extensions._plb:
					return Plb;

			case Extensions._psb:
					return Psb;

			case Extensions._pvb:
					return Pvb;

			case Extensions._tcap:
					return Tcap;

			case Extensions._pwn:
					return Pwn;

			case Extensions._aso:
					return Aso;

			case Extensions._imp:
					return Imp;

			case Extensions._acu:
					return Acu;

			case Extensions._atc:
			case Extensions._acutc:
					return Atc;

			case Extensions._air:
					return Air;

			case Extensions._fcdt:
					return Fcdt;

			case Extensions._fxp:
			case Extensions._fxpl:
					return Fxp;

			case Extensions._xdp:
					return Xdp;

			case Extensions._xfdf:
					return Xfdf;

			case Extensions._ahead:
					return Ahead;

			case Extensions._azf:
					return Azf;

			case Extensions._azs:
					return Azs;

			case Extensions._azw:
					return Azw;

			case Extensions._acc:
					return Acc;

			case Extensions._ami:
					return Ami;

			case Extensions._apk:
					return Apk;

			case Extensions._cii:
					return Cii;

			case Extensions._fti:
					return Fti;

			case Extensions._atx:
					return Atx;

			case Extensions._mpkg:
					return Mpkg;

			case Extensions._m3u8:
					return M3u8;

			case Extensions._swi:
					return Swi;

			case Extensions._iota:
					return Iota;

			case Extensions._aep:
					return Aep;

			case Extensions._mpm:
					return Mpm;

			case Extensions._bmi:
					return Bmi;

			case Extensions._rep:
					return Rep;

			case Extensions._cdxml:
					return Cdxml;

			case Extensions._mmd:
					return Mmd;

			case Extensions._cdy:
					return Cdy;

			case Extensions._cla:
					return Cla;

			case Extensions._rp9:
					return Rp9;

			case Extensions._c4g:
			case Extensions._c4d:
			case Extensions._c4f:
			case Extensions._c4p:
			case Extensions._c4u:
					return C4g;

			case Extensions._c11amc:
					return C11amc;

			case Extensions._c11amz:
					return C11amz;

			case Extensions._csp:
					return Csp;

			case Extensions._cdbcmsg:
					return Cdbcmsg;

			case Extensions._cmc:
					return Cmc;

			case Extensions._clkx:
					return Clkx;

			case Extensions._clkk:
					return Clkk;

			case Extensions._clkp:
					return Clkp;

			case Extensions._clkt:
					return Clkt;

			case Extensions._clkw:
					return Clkw;

			case Extensions._wbs:
					return Wbs;

			case Extensions._pml:
					return Pml;

			case Extensions._ppd:
					return Ppd;

			case Extensions._car:
					return Car;

			case Extensions._pcurl:
					return Pcurl;

			case Extensions._dart:
					return Dart;

			case Extensions._rdz:
					return Rdz;

			case Extensions._uvf:
			case Extensions._uvvf:
			case Extensions._uvd:
			case Extensions._uvvd:
					return Uvf;

			case Extensions._uvt:
			case Extensions._uvvt:
					return Uvt;

			case Extensions._uvx:
			case Extensions._uvvx:
					return Uvx;

			case Extensions._uvz:
			case Extensions._uvvz:
					return Uvz;

			case Extensions._fe_launch:
					return Felaunch;

			case Extensions._dna:
					return Dna;

			case Extensions._mlp:
					return Mlp;

			case Extensions._dpg:
					return Dpg;

			case Extensions._dfac:
					return Dfac;

			case Extensions._kpxx:
					return Kpxx;

			case Extensions._ait:
					return Ait;

			case Extensions._svc:
					return Svc;

			case Extensions._geo:
					return Geo;

			case Extensions._mag:
					return Mag;

			case Extensions._nml:
					return Nml;

			case Extensions._esf:
					return Esf;

			case Extensions._msf:
					return Msf;

			case Extensions._qam:
					return Qam;

			case Extensions._slt:
					return Slt;

			case Extensions._ssf:
					return Ssf;

			case Extensions._es3:
			case Extensions._et3:
					return Es3;

			case Extensions._ez2:
					return Ez2;

			case Extensions._ez3:
					return Ez3;

			case Extensions._fdf:
					return Fdf;

			case Extensions._mseed:
					return Mseed;

			case Extensions._seed:
			case Extensions._dataless:
					return Seed;

			case Extensions._gph:
					return Gph;

			case Extensions._ftc:
					return Ftc;

			case Extensions._fm:
			case Extensions._frame:
			case Extensions._maker:
			case Extensions._book:
					return Fm;

			case Extensions._fnc:
					return Fnc;

			case Extensions._ltf:
					return Ltf;

			case Extensions._fsc:
					return Fsc;

			case Extensions._oas:
					return Oas;

			case Extensions._oa2:
					return Oa2;

			case Extensions._oa3:
					return Oa3;

			case Extensions._fg5:
					return Fg5;

			case Extensions._bh2:
					return Bh2;

			case Extensions._ddd:
					return Ddd;

			case Extensions._xdw:
					return Xdw;

			case Extensions._xbd:
					return Xbd;

			case Extensions._fzs:
					return Fzs;

			case Extensions._txd:
					return Txd;

			case Extensions._ggb:
					return Ggb;

			case Extensions._ggt:
					return Ggt;

			case Extensions._gex:
			case Extensions._gre:
					return Gex;

			case Extensions._gxt:
					return Gxt;

			case Extensions._g2w:
					return G2w;

			case Extensions._g3w:
					return G3w;

			case Extensions._gmx:
					return Gmx;

			case Extensions._kml:
					return Kml;

			case Extensions._kmz:
					return Kmz;

			case Extensions._gqf:
			case Extensions._gqs:
					return Gqf;

			case Extensions._gac:
					return Gac;

			case Extensions._ghf:
					return Ghf;

			case Extensions._gim:
					return Gim;

			case Extensions._grv:
					return Grv;

			case Extensions._gtm:
					return Gtm;

			case Extensions._tpl:
					return Tpl;

			case Extensions._vcg:
					return Vcg;

			case Extensions._hal:
					return Hal;

			case Extensions._zmm:
					return Zmm;

			case Extensions._hbci:
					return Hbci;

			case Extensions._les:
					return Les;

			case Extensions._hpgl:
					return Hpgl;

			case Extensions._hpid:
					return Hpid;

			case Extensions._hps:
					return Hps;

			case Extensions._jlt:
					return Jlt;

			case Extensions._pcl:
					return Pcl;

			case Extensions._pclxl:
					return Pclxl;

			case Extensions._sfd_hdstx:
					return Sfdhdstx;

			case Extensions._mpy:
					return Mpy;

			case Extensions._afp:
			case Extensions._listafp:
			case Extensions._list3820:
					return Afp;

			case Extensions._irm:
					return Irm;

			case Extensions._sc:
					return Sc;

			case Extensions._icc:
			case Extensions._icm:
					return Icc;

			case Extensions._igl:
					return Igl;

			case Extensions._ivp:
					return Ivp;

			case Extensions._ivu:
					return Ivu;

			case Extensions._igm:
					return Igm;

			case Extensions._xpw:
			case Extensions._xpx:
					return Xpw;

			case Extensions._i2g:
					return I2g;

			case Extensions._qbo:
					return Qbo;

			case Extensions._qfx:
					return Qfx;

			case Extensions._rcprofile:
					return Rcprofile;

			case Extensions._irp:
					return Irp;

			case Extensions._xpr:
					return Xpr;

			case Extensions._fcs:
					return Fcs;

			case Extensions._jam:
					return Jam;

			case Extensions._rms:
					return Rms;

			case Extensions._jisp:
					return Jisp;

			case Extensions._joda:
					return Joda;

			case Extensions._ktz:
			case Extensions._ktr:
					return Ktz;

			case Extensions._karbon:
					return Karbon;

			case Extensions._chrt:
					return Chrt;

			case Extensions._kfo:
					return Kfo;

			case Extensions._flw:
					return Flw;

			case Extensions._kon:
					return Kon;

			case Extensions._kpr:
			case Extensions._kpt:
					return Kpr;

			case Extensions._ksp:
					return Ksp;

			case Extensions._kwd:
			case Extensions._kwt:
					return Kwd;

			case Extensions._htke:
					return Htke;

			case Extensions._kia:
					return Kia;

			case Extensions._kne:
			case Extensions._knp:
					return Kne;

			case Extensions._skp:
			case Extensions._skd:
			case Extensions._skt:
			case Extensions._skm:
					return Skp;

			case Extensions._sse:
					return Sse;

			case Extensions._lasxml:
					return Lasxml;

			case Extensions._lbd:
					return Lbd;

			case Extensions._lbe:
					return Lbe;

			case Extensions._123:
					return _123;

			case Extensions._apr:
					return Apr;

			case Extensions._pre:
					return Pre;

			case Extensions._nsf:
					return Nsf;

			case Extensions._org:
					return Org;

			case Extensions._scm:
					return Scm;

			case Extensions._lwp:
					return Lwp;

			case Extensions._portpkg:
					return Portpkg;

			case Extensions._mcd:
					return Mcd;

			case Extensions._mc1:
					return Mc1;

			case Extensions._cdkey:
					return Cdkey;

			case Extensions._mwf:
					return Mwf;

			case Extensions._mfm:
					return Mfm;

			case Extensions._flo:
					return Flo;

			case Extensions._igx:
					return Igx;

			case Extensions._mif:
					return Mif;

			case Extensions._daf:
					return Daf;

			case Extensions._dis:
					return Dis;

			case Extensions._mbk:
					return Mbk;

			case Extensions._mqy:
					return Mqy;

			case Extensions._msl:
					return Msl;

			case Extensions._plc:
					return Plc;

			case Extensions._txf:
					return Txf;

			case Extensions._mpn:
					return Mpn;

			case Extensions._mpc:
					return Mpc;

			case Extensions._xul:
					return Xul;

			case Extensions._cil:
					return Cil;

			case Extensions._cab:
					return Cab;

			case Extensions._xls:
			case Extensions._xlm:
			case Extensions._xla:
			case Extensions._xlc:
			case Extensions._xlt:
			case Extensions._xlw:
					return Xls;

			case Extensions._xlam:
					return Xlam;

			case Extensions._xlsb:
					return Xlsb;

			case Extensions._xlsm:
					return Xlsm;

			case Extensions._xltm:
					return Xltm;

			case Extensions._eot:
					return Eot;

			case Extensions._chm:
					return Chm;

			case Extensions._ims:
					return Ims;

			case Extensions._lrm:
					return Lrm;

			case Extensions._thmx:
					return Thmx;

			case Extensions._cat:
					return Cat;

			case Extensions._stl:
					return Stl;

			case Extensions._ppt:
			case Extensions._pps:
			case Extensions._pot:
					return Ppt;

			case Extensions._ppam:
					return Ppam;

			case Extensions._pptm:
					return Pptm;

			case Extensions._sldm:
					return Sldm;

			case Extensions._ppsm:
					return Ppsm;

			case Extensions._potm:
					return Potm;

			case Extensions._mpp:
			case Extensions._mpt:
					return Mpp;

			case Extensions._docm:
					return Docm;

			case Extensions._dotm:
					return Dotm;

			case Extensions._wps:
			case Extensions._wks:
			case Extensions._wcm:
			case Extensions._wdb:
					return Wps;

			case Extensions._wpl:
					return Wpl;

			case Extensions._xps:
					return Xps;

			case Extensions._mseq:
					return Mseq;

			case Extensions._mus:
					return Mus;

			case Extensions._msty:
					return Msty;

			case Extensions._taglet:
					return Taglet;

			case Extensions._nlu:
					return Nlu;

			case Extensions._ntf:
			case Extensions._nitf:
					return Ntf;

			case Extensions._nnd:
					return Nnd;

			case Extensions._nns:
					return Nns;

			case Extensions._nnw:
					return Nnw;

			case Extensions._ngdat:
					return Ngdat;

			case Extensions._n_gage:
					return Ngage;

			case Extensions._rpst:
					return Rpst;

			case Extensions._rpss:
					return Rpss;

			case Extensions._edm:
					return Edm;

			case Extensions._edx:
					return Edx;

			case Extensions._ext:
					return Ext;

			case Extensions._odc:
					return Odc;

			case Extensions._otc:
					return Otc;

			case Extensions._odb:
					return Odb;

			case Extensions._odf:
					return Odf;

			case Extensions._odft:
					return Odft;

			case Extensions._odg:
					return Odg;

			case Extensions._otg:
					return Otg;

			case Extensions._odi:
					return Odi;

			case Extensions._oti:
					return Oti;

			case Extensions._odp:
					return Odp;

			case Extensions._otp:
					return Otp;

			case Extensions._ods:
					return Ods;

			case Extensions._ots:
					return Ots;

			case Extensions._odt:
					return Odt;

			case Extensions._odm:
					return Odm;

			case Extensions._ott:
					return Ott;

			case Extensions._oth:
					return Oth;

			case Extensions._xo:
					return Xo;

			case Extensions._dd2:
					return Dd2;

			case Extensions._oxt:
					return Oxt;

			case Extensions._pptx:
					return Pptx;

			case Extensions._sldx:
					return Sldx;

			case Extensions._ppsx:
					return Ppsx;

			case Extensions._potx:
					return Potx;

			case Extensions._xlsx:
					return Xlsx;

			case Extensions._xltx:
					return Xltx;

			case Extensions._docx:
					return Docx;

			case Extensions._dotx:
					return Dotx;

			case Extensions._mgp:
					return Mgp;

			case Extensions._dp:
					return Dp;

			case Extensions._esa:
					return Esa;

			case Extensions._pdb:
			case Extensions._pqa:
			case Extensions._oprc:
					return Pdb;

			case Extensions._paw:
					return Paw;

			case Extensions._str:
					return Str;

			case Extensions._ei6:
					return Ei6;

			case Extensions._efif:
					return Efif;

			case Extensions._wg:
					return Wg;

			case Extensions._plf:
					return Plf;

			case Extensions._pbd:
					return Pbd;

			case Extensions._box:
					return Box;

			case Extensions._mgz:
					return Mgz;

			case Extensions._qps:
					return Qps;

			case Extensions._ptid:
					return Ptid;

			case Extensions._qxd:
			case Extensions._qxt:
			case Extensions._qwd:
			case Extensions._qwt:
			case Extensions._qxl:
			case Extensions._qxb:
					return Qxd;

			case Extensions._bed:
					return Bed;

			case Extensions._mxl:
					return Mxl;

			case Extensions._musicxml:
					return Musicxml;

			case Extensions._cryptonote:
					return Cryptonote;

			case Extensions._cod:
					return Cod;

			case Extensions._rm:
					return Rm;

			case Extensions._rmvb:
					return Rmvb;

			case Extensions._link66:
					return Link66;

			case Extensions._st:
					return St;

			case Extensions._see:
					return See;

			case Extensions._sema:
					return Sema;

			case Extensions._semd:
					return Semd;

			case Extensions._semf:
					return Semf;

			case Extensions._ifm:
					return Ifm;

			case Extensions._itp:
					return Itp;

			case Extensions._iif:
					return Iif;

			case Extensions._ipk:
					return Ipk;

			case Extensions._twd:
			case Extensions._twds:
					return Twd;

			case Extensions._mmf:
					return Mmf;

			case Extensions._teacher:
					return Teacher;

			case Extensions._sdkm:
			case Extensions._sdkd:
					return Sdkm;

			case Extensions._dxp:
					return Dxp;

			case Extensions._sfs:
					return Sfs;

			case Extensions._sdc:
					return Sdc;

			case Extensions._sda:
					return Sda;

			case Extensions._sdd:
					return Sdd;

			case Extensions._smf:
					return Smf;

			case Extensions._sdw:
			case Extensions._vor:
					return Sdw;

			case Extensions._sgl:
					return Sgl;

			case Extensions._smzip:
					return Smzip;

			case Extensions._sm:
					return Sm;

			case Extensions._sxc:
					return Sxc;

			case Extensions._stc:
					return Stc;

			case Extensions._sxd:
					return Sxd;

			case Extensions._std:
					return Std;

			case Extensions._sxi:
					return Sxi;

			case Extensions._sti:
					return Sti;

			case Extensions._sxm:
					return Sxm;

			case Extensions._sxw:
					return Sxw;

			case Extensions._sxg:
					return Sxg;

			case Extensions._stw:
					return Stw;

			case Extensions._sus:
			case Extensions._susp:
					return Sus;

			case Extensions._svd:
					return Svd;

			case Extensions._sis:
			case Extensions._sisx:
					return Sis;

			case Extensions._xsm:
					return Xsm;

			case Extensions._bdm:
					return Bdm;

			case Extensions._xdm:
					return Xdm;

			case Extensions._tao:
					return Tao;

			case Extensions._pcap:
			case Extensions._cap:
			case Extensions._dmp:
					return Pcap;

			case Extensions._tmo:
					return Tmo;

			case Extensions._tpt:
					return Tpt;

			case Extensions._mxs:
					return Mxs;

			case Extensions._tra:
					return Tra;

			case Extensions._ufd:
			case Extensions._ufdl:
					return Ufd;

			case Extensions._utz:
					return Utz;

			case Extensions._umj:
					return Umj;

			case Extensions._unityweb:
					return Unityweb;

			case Extensions._uoml:
					return Uoml;

			case Extensions._vcx:
					return Vcx;

			case Extensions._vsd:
			case Extensions._vst:
			case Extensions._vss:
			case Extensions._vsw:
					return Vsd;

			case Extensions._vis:
					return Vis;

			case Extensions._vsf:
					return Vsf;

			case Extensions._wbxml:
					return Wbxml;

			case Extensions._wmlc:
					return Wmlc;

			case Extensions._wmlsc:
					return Wmlsc;

			case Extensions._wtb:
					return Wtb;

			case Extensions._nbp:
					return Nbp;

			case Extensions._wpd:
					return Wpd;

			case Extensions._wqd:
					return Wqd;

			case Extensions._stf:
					return Stf;

			case Extensions._xar:
					return Xar;

			case Extensions._xfdl:
					return Xfdl;

			case Extensions._hvd:
					return Hvd;

			case Extensions._hvs:
					return Hvs;

			case Extensions._hvp:
					return Hvp;

			case Extensions._osf:
					return Osf;

			case Extensions._osfpvg:
					return Osfpvg;

			case Extensions._saf:
					return Saf;

			case Extensions._spf:
					return Spf;

			case Extensions._cmp:
					return Cmp;

			case Extensions._zir:
			case Extensions._zirz:
					return Zir;

			case Extensions._zaz:
					return Zaz;

			case Extensions._vxml:
					return Vxml;

			case Extensions._wgt:
					return Wgt;

			case Extensions._hlp:
					return Hlp;

			case Extensions._wsdl:
					return Wsdl;

			case Extensions._wspolicy:
					return Wspolicy;

			case Extensions._7z:
					return _7z;

			case Extensions._abw:
					return Abw;

			case Extensions._ace:
					return Ace;

			case Extensions._dmg:
					return Dmg;

			case Extensions._aab:
			case Extensions._x32:
			case Extensions._u32:
			case Extensions._vox:
					return Aab;

			case Extensions._aam:
					return Aam;

			case Extensions._aas:
					return Aas;

			case Extensions._bcpio:
					return Bcpio;

			case Extensions._torrent:
					return Torrent;

			case Extensions._blb:
			case Extensions._blorb:
					return Blb;

			case Extensions._bz:
					return Bz;

			case Extensions._bz2:
			case Extensions._boz:
					return Bz2;

			case Extensions._cbr:
			case Extensions._cba:
			case Extensions._cbt:
			case Extensions._cbz:
			case Extensions._cb7:
					return Cbr;

			case Extensions._vcd:
					return Vcd;

			case Extensions._cfs:
					return Cfs;

			case Extensions._chat:
					return Chat;

			case Extensions._pgn:
					return Pgn;

			case Extensions._nsc:
					return Nsc;

			case Extensions._cpio:
					return Cpio;

			case Extensions._csh:
					return Csh;

			case Extensions._deb:
			case Extensions._udeb:
					return Deb;

			case Extensions._dgc:
					return Dgc;

			case Extensions._dir:
			case Extensions._dcr:
			case Extensions._dxr:
			case Extensions._cst:
			case Extensions._cct:
			case Extensions._cxt:
			case Extensions._w3d:
			case Extensions._fgd:
			case Extensions._swa:
					return Dir;

			case Extensions._wad:
					return Wad;

			case Extensions._ncx:
					return Ncx;

			case Extensions._dtb:
					return Dtb;

			case Extensions._res:
					return Res;

			case Extensions._dvi:
					return Dvi;

			case Extensions._evy:
					return Evy;

			case Extensions._eva:
					return Eva;

			case Extensions._bdf:
					return Bdf;

			case Extensions._gsf:
					return Gsf;

			case Extensions._psf:
					return Psf;

			case Extensions._pcf:
					return Pcf;

			case Extensions._snf:
					return Snf;

			case Extensions._pfa:
			case Extensions._pfb:
			case Extensions._pfm:
			case Extensions._afm:
					return Pfa;

			case Extensions._arc:
					return Arc;

			case Extensions._spl:
					return Spl;

			case Extensions._gca:
					return Gca;

			case Extensions._ulx:
					return Ulx;

			case Extensions._gnumeric:
					return Gnumeric;

			case Extensions._gramps:
					return Gramps;

			case Extensions._gtar:
					return Gtar;

			case Extensions._hdf:
					return Hdf;

			case Extensions._install:
					return Install;

			case Extensions._iso:
					return Iso;

			case Extensions._jnlp:
					return Jnlp;

			case Extensions._latex:
					return Latex;

			case Extensions._lzh:
			case Extensions._lha:
					return Lzh;

			case Extensions._mie:
					return Mie;

			case Extensions._prc:
			case Extensions._mobi:
					return Prc;

			case Extensions._application:
					return Application;

			case Extensions._lnk:
					return Lnk;

			case Extensions._wmd:
					return Wmd;

			case Extensions._wmz:
					return Wmz;

			case Extensions._xbap:
					return Xbap;

			case Extensions._mdb:
					return Mdb;

			case Extensions._obd:
					return Obd;

			case Extensions._crd:
					return Crd;

			case Extensions._clp:
					return Clp;

			case Extensions._exe:
			case Extensions._dll:
			case Extensions._com:
			case Extensions._bat:
			case Extensions._msi:
					return Exe;

			case Extensions._mvb:
			case Extensions._m13:
			case Extensions._m14:
					return Mvb;

			case Extensions._wmf:
			case Extensions._emf:
			case Extensions._emz:
					return Wmf;

			case Extensions._mny:
					return Mny;

			case Extensions._pub:
					return Pub;

			case Extensions._scd:
					return Scd;

			case Extensions._trm:
					return Trm;

			case Extensions._wri:
					return Wri;

			case Extensions._nc:
			case Extensions._cdf:
					return Nc;

			case Extensions._nzb:
					return Nzb;

			case Extensions._p12:
			case Extensions._pfx:
					return P12;

			case Extensions._p7b:
			case Extensions._spc:
					return P7b;

			case Extensions._p7r:
					return P7r;

			case Extensions._rar:
					return Rar;

			case Extensions._ris:
					return Ris;

			case Extensions._sh:
					return Sh;

			case Extensions._shar:
					return Shar;

			case Extensions._swf:
					return Swf;

			case Extensions._xap:
					return Xap;

			case Extensions._sql:
					return Sql;

			case Extensions._sit:
					return Sit;

			case Extensions._sitx:
					return Sitx;

			case Extensions._srt:
					return Srt;

			case Extensions._sv4cpio:
					return Sv4cpio;

			case Extensions._sv4crc:
					return Sv4crc;

			case Extensions._t3:
					return T3;

			case Extensions._gam:
					return Gam;

			case Extensions._tar:
					return Tar;

			case Extensions._tcl:
			case Extensions._tk:
					return Tcl;

			case Extensions._tex:
					return Tex;

			case Extensions._tfm:
					return Tfm;

			case Extensions._texinfo:
			case Extensions._texi:
					return Texinfo;

			case Extensions._obj:
					return Obj;

			case Extensions._ustar:
					return Ustar;

			case Extensions._src:
					return Src;

			case Extensions._der:
			case Extensions._crt:
			case Extensions._pem:
					return Der;

			case Extensions._fig:
					return Fig;

			case Extensions._xlf:
					return Xlf;

			case Extensions._xpi:
					return Xpi;

			case Extensions._xz:
					return Xz;

			case Extensions._z1:
			case Extensions._z2:
			case Extensions._z3:
			case Extensions._z4:
			case Extensions._z5:
			case Extensions._z6:
			case Extensions._z7:
			case Extensions._z8:
					return Z1;

			case Extensions._xaml:
					return Xaml;

			case Extensions._xdf:
					return Xdf;

			case Extensions._xenc:
					return Xenc;

			case Extensions._xhtml:
			case Extensions._xht:
					return Xhtml;

			case Extensions._xml:
			case Extensions._xsl:
			case Extensions._xsd:
			case Extensions._rng:
					return Xml;

			case Extensions._dtd:
					return Dtd;

			case Extensions._xop:
					return Xop;

			case Extensions._xpl:
					return Xpl;

			case Extensions._xslt:
					return Xslt;

			case Extensions._xspf:
					return Xspf;

			case Extensions._mxml:
			case Extensions._xhvml:
			case Extensions._xvml:
			case Extensions._xvm:
					return Mxml;

			case Extensions._yang:
					return Yang;

			case Extensions._yin:
					return Yin;

			case Extensions._zip:
					return Zip;

			case Extensions._adp:
					return Adp;

			case Extensions._au:
			case Extensions._snd:
					return Au;

			case Extensions._mid:
			case Extensions._midi:
			case Extensions._kar:
			case Extensions._rmi:
					return Mid;

			case Extensions._m4a:
			case Extensions._mp4a:
			case Extensions._f4a:
			case Extensions._f4b:
					return M4a;

			case Extensions._mpga:
			case Extensions._mp2:
			case Extensions._mp2a:
			case Extensions._mp3:
			case Extensions._m2a:
			case Extensions._m3a:
					return Mpga;

			case Extensions._oga:
			case Extensions._ogg:
			case Extensions._spx:
			case Extensions._opus:
					return Oga;

			case Extensions._s3m:
					return S3m;

			case Extensions._sil:
					return Sil;

			case Extensions._uva:
			case Extensions._uvva:
					return Uva;

			case Extensions._eol:
					return Eol;

			case Extensions._dra:
					return Dra;

			case Extensions._dts:
					return Dts;

			case Extensions._dtshd:
					return Dtshd;

			case Extensions._lvp:
					return Lvp;

			case Extensions._pya:
					return Pya;

			case Extensions._ecelp4800:
					return Ecelp4800;

			case Extensions._ecelp7470:
					return Ecelp7470;

			case Extensions._ecelp9600:
					return Ecelp9600;

			case Extensions._rip:
					return Rip;

			case Extensions._weba:
					return Weba;

			case Extensions._aac:
					return Aac;

			case Extensions._aif:
			case Extensions._aiff:
			case Extensions._aifc:
					return Aif;

			case Extensions._caf:
					return Caf;

			case Extensions._flac:
					return Flac;

			case Extensions._mka:
					return Mka;

			case Extensions._m3u:
					return M3u;

			case Extensions._wax:
					return Wax;

			case Extensions._wma:
					return Wma;

			case Extensions._ram:
			case Extensions._ra:
					return Ram;

			case Extensions._rmp:
					return Rmp;

			case Extensions._wav:
					return Wav;

			case Extensions._xm:
					return Xm;

			case Extensions._cdx:
					return Cdx;

			case Extensions._cif:
					return Cif;

			case Extensions._cmdf:
					return Cmdf;

			case Extensions._cml:
					return Cml;

			case Extensions._csml:
					return Csml;

			case Extensions._xyz:
					return Xyz;

			case Extensions._ttc:
					return Ttc;

			case Extensions._otf:
					return Otf;

			case Extensions._ttf:
					return Ttf;

			case Extensions._woff:
					return Woff;

			case Extensions._woff2:
					return Woff2;

			case Extensions._bmp:
					return Bmp;

			case Extensions._cgm:
					return Cgm;

			case Extensions._g3:
					return G3;

			case Extensions._gif:
					return Gif;

			case Extensions._ief:
					return Ief;

			case Extensions._jpeg:
			case Extensions._jpg:
			case Extensions._jpe:
					return Jpeg;

			case Extensions._ktx:
					return Ktx;

			case Extensions._png:
					return Png;

			case Extensions._btif:
					return Btif;

			case Extensions._sgi:
					return Sgi;

			case Extensions._svg:
			case Extensions._svgz:
					return Svg;

			case Extensions._tiff:
			case Extensions._tif:
					return Tiff;

			case Extensions._psd:
					return Psd;

			case Extensions._uvi:
			case Extensions._uvvi:
			case Extensions._uvg:
			case Extensions._uvvg:
					return Uvi;

			case Extensions._djvu:
			case Extensions._djv:
					return Djvu;

			case Extensions._sub:
					return Sub;

			case Extensions._dwg:
					return Dwg;

			case Extensions._dxf:
					return Dxf;

			case Extensions._fbs:
					return Fbs;

			case Extensions._fpx:
					return Fpx;

			case Extensions._fst:
					return Fst;

			case Extensions._mmr:
					return Mmr;

			case Extensions._rlc:
					return Rlc;

			case Extensions._mdi:
					return Mdi;

			case Extensions._wdp:
					return Wdp;

			case Extensions._npx:
					return Npx;

			case Extensions._wbmp:
					return Wbmp;

			case Extensions._xif:
					return Xif;

			case Extensions._webp:
					return Webp;

			case Extensions._3ds:
					return _3ds;

			case Extensions._ras:
					return Ras;

			case Extensions._cmx:
					return Cmx;

			case Extensions._fh:
			case Extensions._fhc:
			case Extensions._fh4:
			case Extensions._fh5:
			case Extensions._fh7:
					return Fh;

			case Extensions._ico:
			case Extensions._cur:
					return Ico;

			case Extensions._sid:
					return Sid;

			case Extensions._pcx:
					return Pcx;

			case Extensions._pic:
			case Extensions._pct:
					return Pic;

			case Extensions._pnm:
					return Pnm;

			case Extensions._pbm:
					return Pbm;

			case Extensions._pgm:
					return Pgm;

			case Extensions._ppm:
					return Ppm;

			case Extensions._rgb:
					return Rgb;

			case Extensions._tga:
					return Tga;

			case Extensions._xbm:
					return Xbm;

			case Extensions._xpm:
					return Xpm;

			case Extensions._xwd:
					return Xwd;

			case Extensions._eml:
			case Extensions._mime:
					return Eml;

			case Extensions._igs:
			case Extensions._iges:
					return Igs;

			case Extensions._msh:
			case Extensions._mesh:
			case Extensions._silo:
					return Msh;

			case Extensions._dae:
					return Dae;

			case Extensions._dwf:
					return Dwf;

			case Extensions._gdl:
					return Gdl;

			case Extensions._gtw:
					return Gtw;

			case Extensions._mts:
					return Mts;

			case Extensions._vtu:
					return Vtu;

			case Extensions._wrl:
			case Extensions._vrml:
					return Wrl;

			case Extensions._x3db:
			case Extensions._x3dbz:
					return X3db;

			case Extensions._x3dv:
			case Extensions._x3dvz:
					return X3dv;

			case Extensions._x3d:
			case Extensions._x3dz:
					return X3d;

			case Extensions._appcache:
			case Extensions._manifest:
					return Appcache;

			case Extensions._ics:
			case Extensions._ifb:
					return Ics;

			case Extensions._css:
					return Css;

			case Extensions._csv:
					return Csv;

			case Extensions._html:
			case Extensions._htm:
			case Extensions._shtml:
					return Html;

			case Extensions._n3:
					return N3;

			case Extensions._txt:
			case Extensions._text:
			case Extensions._conf:
			case Extensions._def:
			case Extensions._list:
			case Extensions._log:
			case Extensions._in:
			case Extensions._ini:
					return Txt;

			case Extensions._dsc:
					return Dsc;

			case Extensions._rtx:
					return Rtx;

			case Extensions._sgml:
			case Extensions._sgm:
					return Sgml;

			case Extensions._tsv:
					return Tsv;

			case Extensions._t:
			case Extensions._tr:
			case Extensions._roff:
			case Extensions._man:
			case Extensions._me:
			case Extensions._ms:
					return T;

			case Extensions._ttl:
					return Ttl;

			case Extensions._uri:
			case Extensions._uris:
			case Extensions._urls:
					return Uri;

			case Extensions._vcard:
					return Vcard;

			case Extensions._curl:
					return Curl;

			case Extensions._dcurl:
					return Dcurl;

			case Extensions._mcurl:
					return Mcurl;

			case Extensions._scurl:
					return Scurl;

			case Extensions._fly:
					return Fly;

			case Extensions._flx:
					return Flx;

			case Extensions._gv:
					return Gv;

			case Extensions._3dml:
					return _3dml;

			case Extensions._spot:
					return Spot;

			case Extensions._jad:
					return Jad;

			case Extensions._wml:
					return Wml;

			case Extensions._wmls:
					return Wmls;

			case Extensions._s:
			case Extensions._asm:
					return S;

			case Extensions._c:
			case Extensions._cc:
			case Extensions._cxx:
			case Extensions._cpp:
			case Extensions._h:
			case Extensions._hh:
			case Extensions._dic:
					return C;

			case Extensions._f:
			case Extensions._for:
			case Extensions._f77:
			case Extensions._f90:
					return F;

			case Extensions._java:
					return Java;

			case Extensions._nfo:
					return Nfo;

			case Extensions._opml:
					return Opml;

			case Extensions._p:
			case Extensions._pas:
					return P;

			case Extensions._etx:
					return Etx;

			case Extensions._sfv:
					return Sfv;

			case Extensions._uu:
					return Uu;

			case Extensions._vcs:
					return Vcs;

			case Extensions._vcf:
					return Vcf;

			case Extensions._3gp:
			case Extensions._3gpp:
					return _3gp;

			case Extensions._3g2:
					return _3g2;

			case Extensions._h261:
					return H261;

			case Extensions._h263:
					return H263;

			case Extensions._h264:
					return H264;

			case Extensions._jpgv:
					return Jpgv;

			case Extensions._jpm:
			case Extensions._jpgm:
					return Jpm;

			case Extensions._mj2:
			case Extensions._mjp2:
					return Mj2;

			case Extensions._mp4:
			case Extensions._mp4v:
			case Extensions._mpg4:
			case Extensions._f4p:
					return Mp4;

			case Extensions._mpeg:
			case Extensions._mpg:
			case Extensions._mpe:
			case Extensions._m1v:
			case Extensions._m2v:
					return Mpeg;

			case Extensions._ogv:
					return Ogv;

			case Extensions._qt:
			case Extensions._mov:
					return Qt;

			case Extensions._uvh:
			case Extensions._uvvh:
					return Uvh;

			case Extensions._uvm:
			case Extensions._uvvm:
					return Uvm;

			case Extensions._uvp:
			case Extensions._uvvp:
					return Uvp;

			case Extensions._uvs:
			case Extensions._uvvs:
					return Uvs;

			case Extensions._uvv:
			case Extensions._uvvv:
					return Uvv;

			case Extensions._dvb:
					return Dvb;

			case Extensions._fvt:
					return Fvt;

			case Extensions._mxu:
			case Extensions._m4u:
					return Mxu;

			case Extensions._pyv:
					return Pyv;

			case Extensions._uvu:
			case Extensions._uvvu:
					return Uvu;

			case Extensions._viv:
					return Viv;

			case Extensions._webm:
					return Webm;

			case Extensions._f4v:
					return F4v;

			case Extensions._fli:
					return Fli;

			case Extensions._flv:
					return Flv;

			case Extensions._m4v:
					return M4v;

			case Extensions._mkv:
			case Extensions._mk3d:
			case Extensions._mks:
					return Mkv;

			case Extensions._mng:
					return Mng;

			case Extensions._asf:
			case Extensions._asx:
					return Asf;

			case Extensions._vob:
					return Vob;

			case Extensions._wm:
					return Wm;

			case Extensions._wmv:
					return Wmv;

			case Extensions._wmx:
					return Wmx;

			case Extensions._wvx:
					return Wvx;

			case Extensions._avi:
					return Avi;

			case Extensions._movie:
					return Movie;

			case Extensions._smv:
					return Smv;

			case Extensions._ice:
					return Ice;

			case Extensions._jsonld:
					return Jsonld;

			case Extensions._geojson:
					return Geojson;

			case Extensions._mjs:
					return Mjs;

			case Extensions._wasm:
					return Wasm;

			case Extensions._webmanifest:
					return Webmanifest;

			case Extensions._webapp:
					return Webapp;

			case Extensions._jxr:
			case Extensions._hdp:
					return Jxr;

			case Extensions._jng:
					return Jng;

			case Extensions._bbaw:
					return Bbaw;

			case Extensions._crx:
					return Crx;

			case Extensions._cco:
					return Cco;

			case Extensions._jardiff:
					return Jardiff;

			case Extensions._run:
					return Run;

			case Extensions._oex:
					return Oex;

			case Extensions._pl:
			case Extensions._pm:
					return Pl;

			case Extensions._rpm:
					return Rpm;

			case Extensions._sea:
					return Sea;

			case Extensions._md:
			case Extensions._markdown:
					return Md;

			case Extensions._mml:
					return Mml;

			case Extensions._xloc:
					return Xloc;

			case Extensions._vtt:
					return Vtt;

			case Extensions._htc:
					return Htc;

			case Extensions._bdoc:
					return Bdoc;

			case Extensions._hjson:
					return Hjson;

			case Extensions._json5:
					return Json5;

			case Extensions._cjs:
					return Cjs;

			case Extensions._raml:
					return Raml;

			case Extensions._siv:
			case Extensions._sieve:
					return Siv;

			case Extensions._toml:
					return Toml;

			case Extensions._ubj:
					return Ubj;

			case Extensions._pkpass:
					return Pkpass;

			case Extensions._gdoc:
					return Gdoc;

			case Extensions._gslides:
					return Gslides;

			case Extensions._gsheet:
					return Gsheet;

			case Extensions._msg:
					return Msg;

			case Extensions._arj:
					return Arj;

			case Extensions._php:
					return Php;

			case Extensions._kdbx:
					return Kdbx;

			case Extensions._luac:
					return Luac;

			case Extensions._pac:
					return Pac;

			case Extensions._hdd:
					return Hdd;

			case Extensions._ova:
					return Ova;

			case Extensions._ovf:
					return Ovf;

			case Extensions._vbox:
					return Vbox;

			case Extensions._vbox_extpack:
					return Vboxextpack;

			case Extensions._vdi:
					return Vdi;

			case Extensions._vhd:
					return Vhd;

			case Extensions._vmdk:
					return Vmdk;

			case Extensions._apng:
					return Apng;

			case Extensions._avif:
					return Avif;

			case Extensions._heic:
					return Heic;

			case Extensions._heics:
					return Heics;

			case Extensions._heif:
					return Heif;

			case Extensions._heifs:
					return Heifs;

			case Extensions._jp2:
			case Extensions._jpg2:
					return Jp2;

			case Extensions._jpx:
			case Extensions._jpf:
					return Jpx;

			case Extensions._dds:
					return Dds;

			case Extensions._coffee:
			case Extensions._litcoffee:
					return Coffee;

			case Extensions._jade:
					return Jade;

			case Extensions._jsx:
					return Jsx;

			case Extensions._less:
					return Less;

			case Extensions._mdx:
					return Mdx;

			case Extensions._shex:
					return Shex;

			case Extensions._slim:
			case Extensions._slm:
					return Slim;

			case Extensions._stylus:
			case Extensions._styl:
					return Stylus;

			case Extensions._hbs:
					return Hbs;

			case Extensions._lua:
					return Lua;

			case Extensions._mkd:
					return Mkd;

			case Extensions._pde:
					return Pde;

			case Extensions._sass:
					return Sass;

			case Extensions._scss:
					return Scss;

			case Extensions._ymp:
					return Ymp;

			case Extensions._yaml:
			case Extensions._yml:
					return Yaml;

				default: 
					return null;
            }
        }

        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        internal static string[] LookupMimeType(string mimeType)
        {
            switch (mimeType)
            {
				case Ez:
					return new[] {Extensions._ez};
				case Aw:
					return new[] {Extensions._aw};
				case Atom:
					return new[] {Extensions._atom};
				case Atomcat:
					return new[] {Extensions._atomcat};
				case Atomsvc:
					return new[] {Extensions._atomsvc};
				case Ccxml:
					return new[] {Extensions._ccxml};
				case Cdmia:
					return new[] {Extensions._cdmia};
				case Cdmic:
					return new[] {Extensions._cdmic};
				case Cdmid:
					return new[] {Extensions._cdmid};
				case Cdmio:
					return new[] {Extensions._cdmio};
				case Cdmiq:
					return new[] {Extensions._cdmiq};
				case Cu:
					return new[] {Extensions._cu};
				case Davmount:
					return new[] {Extensions._davmount};
				case Dbk:
					return new[] {Extensions._dbk};
				case Dssc:
					return new[] {Extensions._dssc};
				case Xdssc:
					return new[] {Extensions._xdssc};
				case Ecma:
				//case Es:
					return new[] {Extensions._ecma, Extensions._es};
				case Emma:
					return new[] {Extensions._emma};
				case Epub:
					return new[] {Extensions._epub};
				case Exi:
					return new[] {Extensions._exi};
				case Pfr:
					return new[] {Extensions._pfr};
				case Gml:
					return new[] {Extensions._gml};
				case Gpx:
					return new[] {Extensions._gpx};
				case Gxf:
					return new[] {Extensions._gxf};
				case Stk:
					return new[] {Extensions._stk};
				case Ink:
				//case Inkml:
					return new[] {Extensions._ink, Extensions._inkml};
				case Ipfix:
					return new[] {Extensions._ipfix};
				case Jar:
				//case Ear:
				//case War:
					return new[] {Extensions._jar, Extensions._ear, Extensions._war};
				case Ser:
					return new[] {Extensions._ser};
				case Class:
					return new[] {Extensions._class};
				case Js:
					return new[] {Extensions._js};
				case Json:
				//case Map:
				//case Topojson:
					return new[] {Extensions._json, Extensions._map, Extensions._topojson};
				case Jsonml:
					return new[] {Extensions._jsonml};
				case Lostxml:
					return new[] {Extensions._lostxml};
				case Hqx:
					return new[] {Extensions._hqx};
				case Cpt:
					return new[] {Extensions._cpt};
				case Mads:
					return new[] {Extensions._mads};
				case Mrc:
					return new[] {Extensions._mrc};
				case Mrcx:
					return new[] {Extensions._mrcx};
				case Ma:
				//case Nb:
				//case Mb:
					return new[] {Extensions._ma, Extensions._nb, Extensions._mb};
				case Mathml:
					return new[] {Extensions._mathml};
				case Mbox:
					return new[] {Extensions._mbox};
				case Mscml:
					return new[] {Extensions._mscml};
				case Metalink:
					return new[] {Extensions._metalink};
				case Meta4:
					return new[] {Extensions._meta4};
				case Mets:
					return new[] {Extensions._mets};
				case Mods:
					return new[] {Extensions._mods};
				case M21:
				//case Mp21:
					return new[] {Extensions._m21, Extensions._mp21};
				case Mp4s:
				//case M4p:
					return new[] {Extensions._mp4s, Extensions._m4p};
				case Doc:
				//case Dot:
					return new[] {Extensions._doc, Extensions._dot};
				case Mxf:
					return new[] {Extensions._mxf};
				case Bin:
				//case Dms:
				//case Lrf:
				//case Mar:
				//case So:
				//case Dist:
				//case Distz:
				//case Pkg:
				//case Bpk:
				//case Dump:
				//case Elc:
				//case Deploy:
				//case Img:
				//case Msm:
				//case Msp:
				//case Safariextz:
				//case Buffer:
					return new[] {Extensions._bin, Extensions._dms, Extensions._lrf, Extensions._mar, Extensions._so, Extensions._dist, Extensions._distz, Extensions._pkg, Extensions._bpk, Extensions._dump, Extensions._elc, Extensions._deploy, Extensions._img, Extensions._msm, Extensions._msp, Extensions._safariextz, Extensions._buffer};
				case Oda:
					return new[] {Extensions._oda};
				case Opf:
					return new[] {Extensions._opf};
				case Ogx:
					return new[] {Extensions._ogx};
				case Omdoc:
					return new[] {Extensions._omdoc};
				case Onetoc:
				//case Onetoc2:
				//case Onetmp:
				//case Onepkg:
					return new[] {Extensions._onetoc, Extensions._onetoc2, Extensions._onetmp, Extensions._onepkg};
				case Oxps:
					return new[] {Extensions._oxps};
				case Xer:
					return new[] {Extensions._xer};
				case Pdf:
					return new[] {Extensions._pdf};
				case Pgp:
					return new[] {Extensions._pgp};
				case Asc:
				//case Sig:
					return new[] {Extensions._asc, Extensions._sig};
				case Prf:
					return new[] {Extensions._prf};
				case P10:
					return new[] {Extensions._p10};
				case P7m:
				//case P7c:
					return new[] {Extensions._p7m, Extensions._p7c};
				case P7s:
					return new[] {Extensions._p7s};
				case P8:
					return new[] {Extensions._p8};
				case Ac:
					return new[] {Extensions._ac};
				case Cer:
					return new[] {Extensions._cer};
				case Crl:
					return new[] {Extensions._crl};
				case Pkipath:
					return new[] {Extensions._pkipath};
				case Pki:
					return new[] {Extensions._pki};
				case Pls:
					return new[] {Extensions._pls};
				case Ai:
				//case Eps:
				//case Ps:
					return new[] {Extensions._ai, Extensions._eps, Extensions._ps};
				case Cww:
					return new[] {Extensions._cww};
				case Pskcxml:
					return new[] {Extensions._pskcxml};
				case Rdf:
				//case Owl:
					return new[] {Extensions._rdf, Extensions._owl};
				case Rif:
					return new[] {Extensions._rif};
				case Rnc:
					return new[] {Extensions._rnc};
				case Rl:
					return new[] {Extensions._rl};
				case Rld:
					return new[] {Extensions._rld};
				case Rs:
					return new[] {Extensions._rs};
				case Gbr:
					return new[] {Extensions._gbr};
				case Mft:
					return new[] {Extensions._mft};
				case Roa:
					return new[] {Extensions._roa};
				case Rsd:
					return new[] {Extensions._rsd};
				case Rss:
					return new[] {Extensions._rss};
				case Rtf:
					return new[] {Extensions._rtf};
				case Sbml:
					return new[] {Extensions._sbml};
				case Scq:
					return new[] {Extensions._scq};
				case Scs:
					return new[] {Extensions._scs};
				case Spq:
					return new[] {Extensions._spq};
				case Spp:
					return new[] {Extensions._spp};
				case Sdp:
					return new[] {Extensions._sdp};
				case Setpay:
					return new[] {Extensions._setpay};
				case Setreg:
					return new[] {Extensions._setreg};
				case Shf:
					return new[] {Extensions._shf};
				case Smi:
				//case Smil:
					return new[] {Extensions._smi, Extensions._smil};
				case Rq:
					return new[] {Extensions._rq};
				case Srx:
					return new[] {Extensions._srx};
				case Gram:
					return new[] {Extensions._gram};
				case Grxml:
					return new[] {Extensions._grxml};
				case Sru:
					return new[] {Extensions._sru};
				case Ssdl:
					return new[] {Extensions._ssdl};
				case Ssml:
					return new[] {Extensions._ssml};
				case Tei:
				//case Teicorpus:
					return new[] {Extensions._tei, Extensions._teicorpus};
				case Tfi:
					return new[] {Extensions._tfi};
				case Tsd:
					return new[] {Extensions._tsd};
				case Plb:
					return new[] {Extensions._plb};
				case Psb:
					return new[] {Extensions._psb};
				case Pvb:
					return new[] {Extensions._pvb};
				case Tcap:
					return new[] {Extensions._tcap};
				case Pwn:
					return new[] {Extensions._pwn};
				case Aso:
					return new[] {Extensions._aso};
				case Imp:
					return new[] {Extensions._imp};
				case Acu:
					return new[] {Extensions._acu};
				case Atc:
				//case Acutc:
					return new[] {Extensions._atc, Extensions._acutc};
				case Air:
					return new[] {Extensions._air};
				case Fcdt:
					return new[] {Extensions._fcdt};
				case Fxp:
				//case Fxpl:
					return new[] {Extensions._fxp, Extensions._fxpl};
				case Xdp:
					return new[] {Extensions._xdp};
				case Xfdf:
					return new[] {Extensions._xfdf};
				case Ahead:
					return new[] {Extensions._ahead};
				case Azf:
					return new[] {Extensions._azf};
				case Azs:
					return new[] {Extensions._azs};
				case Azw:
					return new[] {Extensions._azw};
				case Acc:
					return new[] {Extensions._acc};
				case Ami:
					return new[] {Extensions._ami};
				case Apk:
					return new[] {Extensions._apk};
				case Cii:
					return new[] {Extensions._cii};
				case Fti:
					return new[] {Extensions._fti};
				case Atx:
					return new[] {Extensions._atx};
				case Mpkg:
					return new[] {Extensions._mpkg};
				case M3u8:
					return new[] {Extensions._m3u8};
				case Swi:
					return new[] {Extensions._swi};
				case Iota:
					return new[] {Extensions._iota};
				case Aep:
					return new[] {Extensions._aep};
				case Mpm:
					return new[] {Extensions._mpm};
				case Bmi:
					return new[] {Extensions._bmi};
				case Rep:
					return new[] {Extensions._rep};
				case Cdxml:
					return new[] {Extensions._cdxml};
				case Mmd:
					return new[] {Extensions._mmd};
				case Cdy:
					return new[] {Extensions._cdy};
				case Cla:
					return new[] {Extensions._cla};
				case Rp9:
					return new[] {Extensions._rp9};
				case C4g:
				//case C4d:
				//case C4f:
				//case C4p:
				//case C4u:
					return new[] {Extensions._c4g, Extensions._c4d, Extensions._c4f, Extensions._c4p, Extensions._c4u};
				case C11amc:
					return new[] {Extensions._c11amc};
				case C11amz:
					return new[] {Extensions._c11amz};
				case Csp:
					return new[] {Extensions._csp};
				case Cdbcmsg:
					return new[] {Extensions._cdbcmsg};
				case Cmc:
					return new[] {Extensions._cmc};
				case Clkx:
					return new[] {Extensions._clkx};
				case Clkk:
					return new[] {Extensions._clkk};
				case Clkp:
					return new[] {Extensions._clkp};
				case Clkt:
					return new[] {Extensions._clkt};
				case Clkw:
					return new[] {Extensions._clkw};
				case Wbs:
					return new[] {Extensions._wbs};
				case Pml:
					return new[] {Extensions._pml};
				case Ppd:
					return new[] {Extensions._ppd};
				case Car:
					return new[] {Extensions._car};
				case Pcurl:
					return new[] {Extensions._pcurl};
				case Dart:
					return new[] {Extensions._dart};
				case Rdz:
					return new[] {Extensions._rdz};
				case Uvf:
				//case Uvvf:
				//case Uvd:
				//case Uvvd:
					return new[] {Extensions._uvf, Extensions._uvvf, Extensions._uvd, Extensions._uvvd};
				case Uvt:
				//case Uvvt:
					return new[] {Extensions._uvt, Extensions._uvvt};
				case Uvx:
				//case Uvvx:
					return new[] {Extensions._uvx, Extensions._uvvx};
				case Uvz:
				//case Uvvz:
					return new[] {Extensions._uvz, Extensions._uvvz};
				case Felaunch:
					return new[] {Extensions._fe_launch};
				case Dna:
					return new[] {Extensions._dna};
				case Mlp:
					return new[] {Extensions._mlp};
				case Dpg:
					return new[] {Extensions._dpg};
				case Dfac:
					return new[] {Extensions._dfac};
				case Kpxx:
					return new[] {Extensions._kpxx};
				case Ait:
					return new[] {Extensions._ait};
				case Svc:
					return new[] {Extensions._svc};
				case Geo:
					return new[] {Extensions._geo};
				case Mag:
					return new[] {Extensions._mag};
				case Nml:
					return new[] {Extensions._nml};
				case Esf:
					return new[] {Extensions._esf};
				case Msf:
					return new[] {Extensions._msf};
				case Qam:
					return new[] {Extensions._qam};
				case Slt:
					return new[] {Extensions._slt};
				case Ssf:
					return new[] {Extensions._ssf};
				case Es3:
				//case Et3:
					return new[] {Extensions._es3, Extensions._et3};
				case Ez2:
					return new[] {Extensions._ez2};
				case Ez3:
					return new[] {Extensions._ez3};
				case Fdf:
					return new[] {Extensions._fdf};
				case Mseed:
					return new[] {Extensions._mseed};
				case Seed:
				//case Dataless:
					return new[] {Extensions._seed, Extensions._dataless};
				case Gph:
					return new[] {Extensions._gph};
				case Ftc:
					return new[] {Extensions._ftc};
				case Fm:
				//case Frame:
				//case Maker:
				//case Book:
					return new[] {Extensions._fm, Extensions._frame, Extensions._maker, Extensions._book};
				case Fnc:
					return new[] {Extensions._fnc};
				case Ltf:
					return new[] {Extensions._ltf};
				case Fsc:
					return new[] {Extensions._fsc};
				case Oas:
					return new[] {Extensions._oas};
				case Oa2:
					return new[] {Extensions._oa2};
				case Oa3:
					return new[] {Extensions._oa3};
				case Fg5:
					return new[] {Extensions._fg5};
				case Bh2:
					return new[] {Extensions._bh2};
				case Ddd:
					return new[] {Extensions._ddd};
				case Xdw:
					return new[] {Extensions._xdw};
				case Xbd:
					return new[] {Extensions._xbd};
				case Fzs:
					return new[] {Extensions._fzs};
				case Txd:
					return new[] {Extensions._txd};
				case Ggb:
					return new[] {Extensions._ggb};
				case Ggt:
					return new[] {Extensions._ggt};
				case Gex:
				//case Gre:
					return new[] {Extensions._gex, Extensions._gre};
				case Gxt:
					return new[] {Extensions._gxt};
				case G2w:
					return new[] {Extensions._g2w};
				case G3w:
					return new[] {Extensions._g3w};
				case Gmx:
					return new[] {Extensions._gmx};
				case Kml:
					return new[] {Extensions._kml};
				case Kmz:
					return new[] {Extensions._kmz};
				case Gqf:
				//case Gqs:
					return new[] {Extensions._gqf, Extensions._gqs};
				case Gac:
					return new[] {Extensions._gac};
				case Ghf:
					return new[] {Extensions._ghf};
				case Gim:
					return new[] {Extensions._gim};
				case Grv:
					return new[] {Extensions._grv};
				case Gtm:
					return new[] {Extensions._gtm};
				case Tpl:
					return new[] {Extensions._tpl};
				case Vcg:
					return new[] {Extensions._vcg};
				case Hal:
					return new[] {Extensions._hal};
				case Zmm:
					return new[] {Extensions._zmm};
				case Hbci:
					return new[] {Extensions._hbci};
				case Les:
					return new[] {Extensions._les};
				case Hpgl:
					return new[] {Extensions._hpgl};
				case Hpid:
					return new[] {Extensions._hpid};
				case Hps:
					return new[] {Extensions._hps};
				case Jlt:
					return new[] {Extensions._jlt};
				case Pcl:
					return new[] {Extensions._pcl};
				case Pclxl:
					return new[] {Extensions._pclxl};
				case Sfdhdstx:
					return new[] {Extensions._sfd_hdstx};
				case Mpy:
					return new[] {Extensions._mpy};
				case Afp:
				//case Listafp:
				//case List3820:
					return new[] {Extensions._afp, Extensions._listafp, Extensions._list3820};
				case Irm:
					return new[] {Extensions._irm};
				case Sc:
					return new[] {Extensions._sc};
				case Icc:
				//case Icm:
					return new[] {Extensions._icc, Extensions._icm};
				case Igl:
					return new[] {Extensions._igl};
				case Ivp:
					return new[] {Extensions._ivp};
				case Ivu:
					return new[] {Extensions._ivu};
				case Igm:
					return new[] {Extensions._igm};
				case Xpw:
				//case Xpx:
					return new[] {Extensions._xpw, Extensions._xpx};
				case I2g:
					return new[] {Extensions._i2g};
				case Qbo:
					return new[] {Extensions._qbo};
				case Qfx:
					return new[] {Extensions._qfx};
				case Rcprofile:
					return new[] {Extensions._rcprofile};
				case Irp:
					return new[] {Extensions._irp};
				case Xpr:
					return new[] {Extensions._xpr};
				case Fcs:
					return new[] {Extensions._fcs};
				case Jam:
					return new[] {Extensions._jam};
				case Rms:
					return new[] {Extensions._rms};
				case Jisp:
					return new[] {Extensions._jisp};
				case Joda:
					return new[] {Extensions._joda};
				case Ktz:
				//case Ktr:
					return new[] {Extensions._ktz, Extensions._ktr};
				case Karbon:
					return new[] {Extensions._karbon};
				case Chrt:
					return new[] {Extensions._chrt};
				case Kfo:
					return new[] {Extensions._kfo};
				case Flw:
					return new[] {Extensions._flw};
				case Kon:
					return new[] {Extensions._kon};
				case Kpr:
				//case Kpt:
					return new[] {Extensions._kpr, Extensions._kpt};
				case Ksp:
					return new[] {Extensions._ksp};
				case Kwd:
				//case Kwt:
					return new[] {Extensions._kwd, Extensions._kwt};
				case Htke:
					return new[] {Extensions._htke};
				case Kia:
					return new[] {Extensions._kia};
				case Kne:
				//case Knp:
					return new[] {Extensions._kne, Extensions._knp};
				case Skp:
				//case Skd:
				//case Skt:
				//case Skm:
					return new[] {Extensions._skp, Extensions._skd, Extensions._skt, Extensions._skm};
				case Sse:
					return new[] {Extensions._sse};
				case Lasxml:
					return new[] {Extensions._lasxml};
				case Lbd:
					return new[] {Extensions._lbd};
				case Lbe:
					return new[] {Extensions._lbe};
				case _123:
					return new[] {Extensions._123};
				case Apr:
					return new[] {Extensions._apr};
				case Pre:
					return new[] {Extensions._pre};
				case Nsf:
					return new[] {Extensions._nsf};
				case Org:
					return new[] {Extensions._org};
				case Scm:
					return new[] {Extensions._scm};
				case Lwp:
					return new[] {Extensions._lwp};
				case Portpkg:
					return new[] {Extensions._portpkg};
				case Mcd:
					return new[] {Extensions._mcd};
				case Mc1:
					return new[] {Extensions._mc1};
				case Cdkey:
					return new[] {Extensions._cdkey};
				case Mwf:
					return new[] {Extensions._mwf};
				case Mfm:
					return new[] {Extensions._mfm};
				case Flo:
					return new[] {Extensions._flo};
				case Igx:
					return new[] {Extensions._igx};
				case Mif:
					return new[] {Extensions._mif};
				case Daf:
					return new[] {Extensions._daf};
				case Dis:
					return new[] {Extensions._dis};
				case Mbk:
					return new[] {Extensions._mbk};
				case Mqy:
					return new[] {Extensions._mqy};
				case Msl:
					return new[] {Extensions._msl};
				case Plc:
					return new[] {Extensions._plc};
				case Txf:
					return new[] {Extensions._txf};
				case Mpn:
					return new[] {Extensions._mpn};
				case Mpc:
					return new[] {Extensions._mpc};
				case Xul:
					return new[] {Extensions._xul};
				case Cil:
					return new[] {Extensions._cil};
				case Cab:
					return new[] {Extensions._cab};
				case Xls:
				//case Xlm:
				//case Xla:
				//case Xlc:
				//case Xlt:
				//case Xlw:
					return new[] {Extensions._xls, Extensions._xlm, Extensions._xla, Extensions._xlc, Extensions._xlt, Extensions._xlw};
				case Xlam:
					return new[] {Extensions._xlam};
				case Xlsb:
					return new[] {Extensions._xlsb};
				case Xlsm:
					return new[] {Extensions._xlsm};
				case Xltm:
					return new[] {Extensions._xltm};
				case Eot:
					return new[] {Extensions._eot};
				case Chm:
					return new[] {Extensions._chm};
				case Ims:
					return new[] {Extensions._ims};
				case Lrm:
					return new[] {Extensions._lrm};
				case Thmx:
					return new[] {Extensions._thmx};
				case Cat:
					return new[] {Extensions._cat};
				case Stl:
					return new[] {Extensions._stl};
				case Ppt:
				//case Pps:
				//case Pot:
					return new[] {Extensions._ppt, Extensions._pps, Extensions._pot};
				case Ppam:
					return new[] {Extensions._ppam};
				case Pptm:
					return new[] {Extensions._pptm};
				case Sldm:
					return new[] {Extensions._sldm};
				case Ppsm:
					return new[] {Extensions._ppsm};
				case Potm:
					return new[] {Extensions._potm};
				case Mpp:
				//case Mpt:
					return new[] {Extensions._mpp, Extensions._mpt};
				case Docm:
					return new[] {Extensions._docm};
				case Dotm:
					return new[] {Extensions._dotm};
				case Wps:
				//case Wks:
				//case Wcm:
				//case Wdb:
					return new[] {Extensions._wps, Extensions._wks, Extensions._wcm, Extensions._wdb};
				case Wpl:
					return new[] {Extensions._wpl};
				case Xps:
					return new[] {Extensions._xps};
				case Mseq:
					return new[] {Extensions._mseq};
				case Mus:
					return new[] {Extensions._mus};
				case Msty:
					return new[] {Extensions._msty};
				case Taglet:
					return new[] {Extensions._taglet};
				case Nlu:
					return new[] {Extensions._nlu};
				case Ntf:
				//case Nitf:
					return new[] {Extensions._ntf, Extensions._nitf};
				case Nnd:
					return new[] {Extensions._nnd};
				case Nns:
					return new[] {Extensions._nns};
				case Nnw:
					return new[] {Extensions._nnw};
				case Ngdat:
					return new[] {Extensions._ngdat};
				case Ngage:
					return new[] {Extensions._n_gage};
				case Rpst:
					return new[] {Extensions._rpst};
				case Rpss:
					return new[] {Extensions._rpss};
				case Edm:
					return new[] {Extensions._edm};
				case Edx:
					return new[] {Extensions._edx};
				case Ext:
					return new[] {Extensions._ext};
				case Odc:
					return new[] {Extensions._odc};
				case Otc:
					return new[] {Extensions._otc};
				case Odb:
					return new[] {Extensions._odb};
				case Odf:
					return new[] {Extensions._odf};
				case Odft:
					return new[] {Extensions._odft};
				case Odg:
					return new[] {Extensions._odg};
				case Otg:
					return new[] {Extensions._otg};
				case Odi:
					return new[] {Extensions._odi};
				case Oti:
					return new[] {Extensions._oti};
				case Odp:
					return new[] {Extensions._odp};
				case Otp:
					return new[] {Extensions._otp};
				case Ods:
					return new[] {Extensions._ods};
				case Ots:
					return new[] {Extensions._ots};
				case Odt:
					return new[] {Extensions._odt};
				case Odm:
					return new[] {Extensions._odm};
				case Ott:
					return new[] {Extensions._ott};
				case Oth:
					return new[] {Extensions._oth};
				case Xo:
					return new[] {Extensions._xo};
				case Dd2:
					return new[] {Extensions._dd2};
				case Oxt:
					return new[] {Extensions._oxt};
				case Pptx:
					return new[] {Extensions._pptx};
				case Sldx:
					return new[] {Extensions._sldx};
				case Ppsx:
					return new[] {Extensions._ppsx};
				case Potx:
					return new[] {Extensions._potx};
				case Xlsx:
					return new[] {Extensions._xlsx};
				case Xltx:
					return new[] {Extensions._xltx};
				case Docx:
					return new[] {Extensions._docx};
				case Dotx:
					return new[] {Extensions._dotx};
				case Mgp:
					return new[] {Extensions._mgp};
				case Dp:
					return new[] {Extensions._dp};
				case Esa:
					return new[] {Extensions._esa};
				case Pdb:
				//case Pqa:
				//case Oprc:
					return new[] {Extensions._pdb, Extensions._pqa, Extensions._oprc};
				case Paw:
					return new[] {Extensions._paw};
				case Str:
					return new[] {Extensions._str};
				case Ei6:
					return new[] {Extensions._ei6};
				case Efif:
					return new[] {Extensions._efif};
				case Wg:
					return new[] {Extensions._wg};
				case Plf:
					return new[] {Extensions._plf};
				case Pbd:
					return new[] {Extensions._pbd};
				case Box:
					return new[] {Extensions._box};
				case Mgz:
					return new[] {Extensions._mgz};
				case Qps:
					return new[] {Extensions._qps};
				case Ptid:
					return new[] {Extensions._ptid};
				case Qxd:
				//case Qxt:
				//case Qwd:
				//case Qwt:
				//case Qxl:
				//case Qxb:
					return new[] {Extensions._qxd, Extensions._qxt, Extensions._qwd, Extensions._qwt, Extensions._qxl, Extensions._qxb};
				case Bed:
					return new[] {Extensions._bed};
				case Mxl:
					return new[] {Extensions._mxl};
				case Musicxml:
					return new[] {Extensions._musicxml};
				case Cryptonote:
					return new[] {Extensions._cryptonote};
				case Cod:
					return new[] {Extensions._cod};
				case Rm:
					return new[] {Extensions._rm};
				case Rmvb:
					return new[] {Extensions._rmvb};
				case Link66:
					return new[] {Extensions._link66};
				case St:
					return new[] {Extensions._st};
				case See:
					return new[] {Extensions._see};
				case Sema:
					return new[] {Extensions._sema};
				case Semd:
					return new[] {Extensions._semd};
				case Semf:
					return new[] {Extensions._semf};
				case Ifm:
					return new[] {Extensions._ifm};
				case Itp:
					return new[] {Extensions._itp};
				case Iif:
					return new[] {Extensions._iif};
				case Ipk:
					return new[] {Extensions._ipk};
				case Twd:
				//case Twds:
					return new[] {Extensions._twd, Extensions._twds};
				case Mmf:
					return new[] {Extensions._mmf};
				case Teacher:
					return new[] {Extensions._teacher};
				case Sdkm:
				//case Sdkd:
					return new[] {Extensions._sdkm, Extensions._sdkd};
				case Dxp:
					return new[] {Extensions._dxp};
				case Sfs:
					return new[] {Extensions._sfs};
				case Sdc:
					return new[] {Extensions._sdc};
				case Sda:
					return new[] {Extensions._sda};
				case Sdd:
					return new[] {Extensions._sdd};
				case Smf:
					return new[] {Extensions._smf};
				case Sdw:
				//case Vor:
					return new[] {Extensions._sdw, Extensions._vor};
				case Sgl:
					return new[] {Extensions._sgl};
				case Smzip:
					return new[] {Extensions._smzip};
				case Sm:
					return new[] {Extensions._sm};
				case Sxc:
					return new[] {Extensions._sxc};
				case Stc:
					return new[] {Extensions._stc};
				case Sxd:
					return new[] {Extensions._sxd};
				case Std:
					return new[] {Extensions._std};
				case Sxi:
					return new[] {Extensions._sxi};
				case Sti:
					return new[] {Extensions._sti};
				case Sxm:
					return new[] {Extensions._sxm};
				case Sxw:
					return new[] {Extensions._sxw};
				case Sxg:
					return new[] {Extensions._sxg};
				case Stw:
					return new[] {Extensions._stw};
				case Sus:
				//case Susp:
					return new[] {Extensions._sus, Extensions._susp};
				case Svd:
					return new[] {Extensions._svd};
				case Sis:
				//case Sisx:
					return new[] {Extensions._sis, Extensions._sisx};
				case Xsm:
					return new[] {Extensions._xsm};
				case Bdm:
					return new[] {Extensions._bdm};
				case Xdm:
					return new[] {Extensions._xdm};
				case Tao:
					return new[] {Extensions._tao};
				case Pcap:
				//case Cap:
				//case Dmp:
					return new[] {Extensions._pcap, Extensions._cap, Extensions._dmp};
				case Tmo:
					return new[] {Extensions._tmo};
				case Tpt:
					return new[] {Extensions._tpt};
				case Mxs:
					return new[] {Extensions._mxs};
				case Tra:
					return new[] {Extensions._tra};
				case Ufd:
				//case Ufdl:
					return new[] {Extensions._ufd, Extensions._ufdl};
				case Utz:
					return new[] {Extensions._utz};
				case Umj:
					return new[] {Extensions._umj};
				case Unityweb:
					return new[] {Extensions._unityweb};
				case Uoml:
					return new[] {Extensions._uoml};
				case Vcx:
					return new[] {Extensions._vcx};
				case Vsd:
				//case Vst:
				//case Vss:
				//case Vsw:
					return new[] {Extensions._vsd, Extensions._vst, Extensions._vss, Extensions._vsw};
				case Vis:
					return new[] {Extensions._vis};
				case Vsf:
					return new[] {Extensions._vsf};
				case Wbxml:
					return new[] {Extensions._wbxml};
				case Wmlc:
					return new[] {Extensions._wmlc};
				case Wmlsc:
					return new[] {Extensions._wmlsc};
				case Wtb:
					return new[] {Extensions._wtb};
				case Nbp:
					return new[] {Extensions._nbp};
				case Wpd:
					return new[] {Extensions._wpd};
				case Wqd:
					return new[] {Extensions._wqd};
				case Stf:
					return new[] {Extensions._stf};
				case Xar:
					return new[] {Extensions._xar};
				case Xfdl:
					return new[] {Extensions._xfdl};
				case Hvd:
					return new[] {Extensions._hvd};
				case Hvs:
					return new[] {Extensions._hvs};
				case Hvp:
					return new[] {Extensions._hvp};
				case Osf:
					return new[] {Extensions._osf};
				case Osfpvg:
					return new[] {Extensions._osfpvg};
				case Saf:
					return new[] {Extensions._saf};
				case Spf:
					return new[] {Extensions._spf};
				case Cmp:
					return new[] {Extensions._cmp};
				case Zir:
				//case Zirz:
					return new[] {Extensions._zir, Extensions._zirz};
				case Zaz:
					return new[] {Extensions._zaz};
				case Vxml:
					return new[] {Extensions._vxml};
				case Wgt:
					return new[] {Extensions._wgt};
				case Hlp:
					return new[] {Extensions._hlp};
				case Wsdl:
					return new[] {Extensions._wsdl};
				case Wspolicy:
					return new[] {Extensions._wspolicy};
				case _7z:
					return new[] {Extensions._7z};
				case Abw:
					return new[] {Extensions._abw};
				case Ace:
					return new[] {Extensions._ace};
				case Dmg:
					return new[] {Extensions._dmg};
				case Aab:
				//case X32:
				//case U32:
				//case Vox:
					return new[] {Extensions._aab, Extensions._x32, Extensions._u32, Extensions._vox};
				case Aam:
					return new[] {Extensions._aam};
				case Aas:
					return new[] {Extensions._aas};
				case Bcpio:
					return new[] {Extensions._bcpio};
				case Torrent:
					return new[] {Extensions._torrent};
				case Blb:
				//case Blorb:
					return new[] {Extensions._blb, Extensions._blorb};
				case Bz:
					return new[] {Extensions._bz};
				case Bz2:
				//case Boz:
					return new[] {Extensions._bz2, Extensions._boz};
				case Cbr:
				//case Cba:
				//case Cbt:
				//case Cbz:
				//case Cb7:
					return new[] {Extensions._cbr, Extensions._cba, Extensions._cbt, Extensions._cbz, Extensions._cb7};
				case Vcd:
					return new[] {Extensions._vcd};
				case Cfs:
					return new[] {Extensions._cfs};
				case Chat:
					return new[] {Extensions._chat};
				case Pgn:
					return new[] {Extensions._pgn};
				case Nsc:
					return new[] {Extensions._nsc};
				case Cpio:
					return new[] {Extensions._cpio};
				case Csh:
					return new[] {Extensions._csh};
				case Deb:
				//case Udeb:
					return new[] {Extensions._deb, Extensions._udeb};
				case Dgc:
					return new[] {Extensions._dgc};
				case Dir:
				//case Dcr:
				//case Dxr:
				//case Cst:
				//case Cct:
				//case Cxt:
				//case W3d:
				//case Fgd:
				//case Swa:
					return new[] {Extensions._dir, Extensions._dcr, Extensions._dxr, Extensions._cst, Extensions._cct, Extensions._cxt, Extensions._w3d, Extensions._fgd, Extensions._swa};
				case Wad:
					return new[] {Extensions._wad};
				case Ncx:
					return new[] {Extensions._ncx};
				case Dtb:
					return new[] {Extensions._dtb};
				case Res:
					return new[] {Extensions._res};
				case Dvi:
					return new[] {Extensions._dvi};
				case Evy:
					return new[] {Extensions._evy};
				case Eva:
					return new[] {Extensions._eva};
				case Bdf:
					return new[] {Extensions._bdf};
				case Gsf:
					return new[] {Extensions._gsf};
				case Psf:
					return new[] {Extensions._psf};
				case Pcf:
					return new[] {Extensions._pcf};
				case Snf:
					return new[] {Extensions._snf};
				case Pfa:
				//case Pfb:
				//case Pfm:
				//case Afm:
					return new[] {Extensions._pfa, Extensions._pfb, Extensions._pfm, Extensions._afm};
				case Arc:
					return new[] {Extensions._arc};
				case Spl:
					return new[] {Extensions._spl};
				case Gca:
					return new[] {Extensions._gca};
				case Ulx:
					return new[] {Extensions._ulx};
				case Gnumeric:
					return new[] {Extensions._gnumeric};
				case Gramps:
					return new[] {Extensions._gramps};
				case Gtar:
					return new[] {Extensions._gtar};
				case Hdf:
					return new[] {Extensions._hdf};
				case Install:
					return new[] {Extensions._install};
				case Iso:
					return new[] {Extensions._iso};
				case Jnlp:
					return new[] {Extensions._jnlp};
				case Latex:
					return new[] {Extensions._latex};
				case Lzh:
				//case Lha:
					return new[] {Extensions._lzh, Extensions._lha};
				case Mie:
					return new[] {Extensions._mie};
				case Prc:
				//case Mobi:
					return new[] {Extensions._prc, Extensions._mobi};
				case Application:
					return new[] {Extensions._application};
				case Lnk:
					return new[] {Extensions._lnk};
				case Wmd:
					return new[] {Extensions._wmd};
				case Wmz:
					return new[] {Extensions._wmz};
				case Xbap:
					return new[] {Extensions._xbap};
				case Mdb:
					return new[] {Extensions._mdb};
				case Obd:
					return new[] {Extensions._obd};
				case Crd:
					return new[] {Extensions._crd};
				case Clp:
					return new[] {Extensions._clp};
				case Exe:
				//case Dll:
				//case Com:
				//case Bat:
				//case Msi:
					return new[] {Extensions._exe, Extensions._dll, Extensions._com, Extensions._bat, Extensions._msi};
				case Mvb:
				//case M13:
				//case M14:
					return new[] {Extensions._mvb, Extensions._m13, Extensions._m14};
				case Wmf:
				//case Emf:
				//case Emz:
					return new[] {Extensions._wmf, Extensions._emf, Extensions._emz};
				case Mny:
					return new[] {Extensions._mny};
				case Pub:
					return new[] {Extensions._pub};
				case Scd:
					return new[] {Extensions._scd};
				case Trm:
					return new[] {Extensions._trm};
				case Wri:
					return new[] {Extensions._wri};
				case Nc:
				//case Cdf:
					return new[] {Extensions._nc, Extensions._cdf};
				case Nzb:
					return new[] {Extensions._nzb};
				case P12:
				//case Pfx:
					return new[] {Extensions._p12, Extensions._pfx};
				case P7b:
				//case Spc:
					return new[] {Extensions._p7b, Extensions._spc};
				case P7r:
					return new[] {Extensions._p7r};
				case Rar:
					return new[] {Extensions._rar};
				case Ris:
					return new[] {Extensions._ris};
				case Sh:
					return new[] {Extensions._sh};
				case Shar:
					return new[] {Extensions._shar};
				case Swf:
					return new[] {Extensions._swf};
				case Xap:
					return new[] {Extensions._xap};
				case Sql:
					return new[] {Extensions._sql};
				case Sit:
					return new[] {Extensions._sit};
				case Sitx:
					return new[] {Extensions._sitx};
				case Srt:
					return new[] {Extensions._srt};
				case Sv4cpio:
					return new[] {Extensions._sv4cpio};
				case Sv4crc:
					return new[] {Extensions._sv4crc};
				case T3:
					return new[] {Extensions._t3};
				case Gam:
					return new[] {Extensions._gam};
				case Tar:
					return new[] {Extensions._tar};
				case Tcl:
				//case Tk:
					return new[] {Extensions._tcl, Extensions._tk};
				case Tex:
					return new[] {Extensions._tex};
				case Tfm:
					return new[] {Extensions._tfm};
				case Texinfo:
				//case Texi:
					return new[] {Extensions._texinfo, Extensions._texi};
				case Obj:
					return new[] {Extensions._obj};
				case Ustar:
					return new[] {Extensions._ustar};
				case Src:
					return new[] {Extensions._src};
				case Der:
				//case Crt:
				//case Pem:
					return new[] {Extensions._der, Extensions._crt, Extensions._pem};
				case Fig:
					return new[] {Extensions._fig};
				case Xlf:
					return new[] {Extensions._xlf};
				case Xpi:
					return new[] {Extensions._xpi};
				case Xz:
					return new[] {Extensions._xz};
				case Z1:
				//case Z2:
				//case Z3:
				//case Z4:
				//case Z5:
				//case Z6:
				//case Z7:
				//case Z8:
					return new[] {Extensions._z1, Extensions._z2, Extensions._z3, Extensions._z4, Extensions._z5, Extensions._z6, Extensions._z7, Extensions._z8};
				case Xaml:
					return new[] {Extensions._xaml};
				case Xdf:
					return new[] {Extensions._xdf};
				case Xenc:
					return new[] {Extensions._xenc};
				case Xhtml:
				//case Xht:
					return new[] {Extensions._xhtml, Extensions._xht};
				case Xml:
				//case Xsl:
				//case Xsd:
				//case Rng:
					return new[] {Extensions._xml, Extensions._xsl, Extensions._xsd, Extensions._rng};
				case Dtd:
					return new[] {Extensions._dtd};
				case Xop:
					return new[] {Extensions._xop};
				case Xpl:
					return new[] {Extensions._xpl};
				case Xslt:
					return new[] {Extensions._xslt};
				case Xspf:
					return new[] {Extensions._xspf};
				case Mxml:
				//case Xhvml:
				//case Xvml:
				//case Xvm:
					return new[] {Extensions._mxml, Extensions._xhvml, Extensions._xvml, Extensions._xvm};
				case Yang:
					return new[] {Extensions._yang};
				case Yin:
					return new[] {Extensions._yin};
				case Zip:
					return new[] {Extensions._zip};
				case Adp:
					return new[] {Extensions._adp};
				case Au:
				//case Snd:
					return new[] {Extensions._au, Extensions._snd};
				case Mid:
				//case Midi:
				//case Kar:
				//case Rmi:
					return new[] {Extensions._mid, Extensions._midi, Extensions._kar, Extensions._rmi};
				case M4a:
				//case Mp4a:
				//case F4a:
				//case F4b:
					return new[] {Extensions._m4a, Extensions._mp4a, Extensions._f4a, Extensions._f4b};
				case Mpga:
				//case Mp2:
				//case Mp2a:
				//case Mp3:
				//case M2a:
				//case M3a:
					return new[] {Extensions._mpga, Extensions._mp2, Extensions._mp2a, Extensions._mp3, Extensions._m2a, Extensions._m3a};
				case Oga:
				//case Ogg:
				//case Spx:
				//case Opus:
					return new[] {Extensions._oga, Extensions._ogg, Extensions._spx, Extensions._opus};
				case S3m:
					return new[] {Extensions._s3m};
				case Sil:
					return new[] {Extensions._sil};
				case Uva:
				//case Uvva:
					return new[] {Extensions._uva, Extensions._uvva};
				case Eol:
					return new[] {Extensions._eol};
				case Dra:
					return new[] {Extensions._dra};
				case Dts:
					return new[] {Extensions._dts};
				case Dtshd:
					return new[] {Extensions._dtshd};
				case Lvp:
					return new[] {Extensions._lvp};
				case Pya:
					return new[] {Extensions._pya};
				case Ecelp4800:
					return new[] {Extensions._ecelp4800};
				case Ecelp7470:
					return new[] {Extensions._ecelp7470};
				case Ecelp9600:
					return new[] {Extensions._ecelp9600};
				case Rip:
					return new[] {Extensions._rip};
				case Weba:
					return new[] {Extensions._weba};
				case Aac:
					return new[] {Extensions._aac};
				case Aif:
				//case Aiff:
				//case Aifc:
					return new[] {Extensions._aif, Extensions._aiff, Extensions._aifc};
				case Caf:
					return new[] {Extensions._caf};
				case Flac:
					return new[] {Extensions._flac};
				case Mka:
					return new[] {Extensions._mka};
				case M3u:
					return new[] {Extensions._m3u};
				case Wax:
					return new[] {Extensions._wax};
				case Wma:
					return new[] {Extensions._wma};
				case Ram:
				//case Ra:
					return new[] {Extensions._ram, Extensions._ra};
				case Rmp:
					return new[] {Extensions._rmp};
				case Wav:
					return new[] {Extensions._wav};
				case Xm:
					return new[] {Extensions._xm};
				case Cdx:
					return new[] {Extensions._cdx};
				case Cif:
					return new[] {Extensions._cif};
				case Cmdf:
					return new[] {Extensions._cmdf};
				case Cml:
					return new[] {Extensions._cml};
				case Csml:
					return new[] {Extensions._csml};
				case Xyz:
					return new[] {Extensions._xyz};
				case Ttc:
					return new[] {Extensions._ttc};
				case Otf:
					return new[] {Extensions._otf};
				case Ttf:
					return new[] {Extensions._ttf};
				case Woff:
					return new[] {Extensions._woff};
				case Woff2:
					return new[] {Extensions._woff2};
				case Bmp:
					return new[] {Extensions._bmp};
				case Cgm:
					return new[] {Extensions._cgm};
				case G3:
					return new[] {Extensions._g3};
				case Gif:
					return new[] {Extensions._gif};
				case Ief:
					return new[] {Extensions._ief};
				case Jpeg:
				//case Jpg:
				//case Jpe:
					return new[] {Extensions._jpeg, Extensions._jpg, Extensions._jpe};
				case Ktx:
					return new[] {Extensions._ktx};
				case Png:
					return new[] {Extensions._png};
				case Btif:
					return new[] {Extensions._btif};
				case Sgi:
					return new[] {Extensions._sgi};
				case Svg:
				//case Svgz:
					return new[] {Extensions._svg, Extensions._svgz};
				case Tiff:
				//case Tif:
					return new[] {Extensions._tiff, Extensions._tif};
				case Psd:
					return new[] {Extensions._psd};
				case Uvi:
				//case Uvvi:
				//case Uvg:
				//case Uvvg:
					return new[] {Extensions._uvi, Extensions._uvvi, Extensions._uvg, Extensions._uvvg};
				case Djvu:
				//case Djv:
					return new[] {Extensions._djvu, Extensions._djv};
				case Sub:
					return new[] {Extensions._sub};
				case Dwg:
					return new[] {Extensions._dwg};
				case Dxf:
					return new[] {Extensions._dxf};
				case Fbs:
					return new[] {Extensions._fbs};
				case Fpx:
					return new[] {Extensions._fpx};
				case Fst:
					return new[] {Extensions._fst};
				case Mmr:
					return new[] {Extensions._mmr};
				case Rlc:
					return new[] {Extensions._rlc};
				case Mdi:
					return new[] {Extensions._mdi};
				case Wdp:
					return new[] {Extensions._wdp};
				case Npx:
					return new[] {Extensions._npx};
				case Wbmp:
					return new[] {Extensions._wbmp};
				case Xif:
					return new[] {Extensions._xif};
				case Webp:
					return new[] {Extensions._webp};
				case _3ds:
					return new[] {Extensions._3ds};
				case Ras:
					return new[] {Extensions._ras};
				case Cmx:
					return new[] {Extensions._cmx};
				case Fh:
				//case Fhc:
				//case Fh4:
				//case Fh5:
				//case Fh7:
					return new[] {Extensions._fh, Extensions._fhc, Extensions._fh4, Extensions._fh5, Extensions._fh7};
				case Ico:
				//case Cur:
					return new[] {Extensions._ico, Extensions._cur};
				case Sid:
					return new[] {Extensions._sid};
				case Pcx:
					return new[] {Extensions._pcx};
				case Pic:
				//case Pct:
					return new[] {Extensions._pic, Extensions._pct};
				case Pnm:
					return new[] {Extensions._pnm};
				case Pbm:
					return new[] {Extensions._pbm};
				case Pgm:
					return new[] {Extensions._pgm};
				case Ppm:
					return new[] {Extensions._ppm};
				case Rgb:
					return new[] {Extensions._rgb};
				case Tga:
					return new[] {Extensions._tga};
				case Xbm:
					return new[] {Extensions._xbm};
				case Xpm:
					return new[] {Extensions._xpm};
				case Xwd:
					return new[] {Extensions._xwd};
				case Eml:
				//case Mime:
					return new[] {Extensions._eml, Extensions._mime};
				case Igs:
				//case Iges:
					return new[] {Extensions._igs, Extensions._iges};
				case Msh:
				//case Mesh:
				//case Silo:
					return new[] {Extensions._msh, Extensions._mesh, Extensions._silo};
				case Dae:
					return new[] {Extensions._dae};
				case Dwf:
					return new[] {Extensions._dwf};
				case Gdl:
					return new[] {Extensions._gdl};
				case Gtw:
					return new[] {Extensions._gtw};
				case Mts:
					return new[] {Extensions._mts};
				case Vtu:
					return new[] {Extensions._vtu};
				case Wrl:
				//case Vrml:
					return new[] {Extensions._wrl, Extensions._vrml};
				case X3db:
				//case X3dbz:
					return new[] {Extensions._x3db, Extensions._x3dbz};
				case X3dv:
				//case X3dvz:
					return new[] {Extensions._x3dv, Extensions._x3dvz};
				case X3d:
				//case X3dz:
					return new[] {Extensions._x3d, Extensions._x3dz};
				case Appcache:
				//case Manifest:
					return new[] {Extensions._appcache, Extensions._manifest};
				case Ics:
				//case Ifb:
					return new[] {Extensions._ics, Extensions._ifb};
				case Css:
					return new[] {Extensions._css};
				case Csv:
					return new[] {Extensions._csv};
				case Html:
				//case Htm:
				//case Shtml:
					return new[] {Extensions._html, Extensions._htm, Extensions._shtml};
				case N3:
					return new[] {Extensions._n3};
				case Txt:
				//case Text:
				//case Conf:
				//case Def:
				//case List:
				//case Log:
				//case In:
				//case Ini:
					return new[] {Extensions._txt, Extensions._text, Extensions._conf, Extensions._def, Extensions._list, Extensions._log, Extensions._in, Extensions._ini};
				case Dsc:
					return new[] {Extensions._dsc};
				case Rtx:
					return new[] {Extensions._rtx};
				case Sgml:
				//case Sgm:
					return new[] {Extensions._sgml, Extensions._sgm};
				case Tsv:
					return new[] {Extensions._tsv};
				case T:
				//case Tr:
				//case Roff:
				//case Man:
				//case Me:
				//case Ms:
					return new[] {Extensions._t, Extensions._tr, Extensions._roff, Extensions._man, Extensions._me, Extensions._ms};
				case Ttl:
					return new[] {Extensions._ttl};
				case Uri:
				//case Uris:
				//case Urls:
					return new[] {Extensions._uri, Extensions._uris, Extensions._urls};
				case Vcard:
					return new[] {Extensions._vcard};
				case Curl:
					return new[] {Extensions._curl};
				case Dcurl:
					return new[] {Extensions._dcurl};
				case Mcurl:
					return new[] {Extensions._mcurl};
				case Scurl:
					return new[] {Extensions._scurl};
				case Fly:
					return new[] {Extensions._fly};
				case Flx:
					return new[] {Extensions._flx};
				case Gv:
					return new[] {Extensions._gv};
				case _3dml:
					return new[] {Extensions._3dml};
				case Spot:
					return new[] {Extensions._spot};
				case Jad:
					return new[] {Extensions._jad};
				case Wml:
					return new[] {Extensions._wml};
				case Wmls:
					return new[] {Extensions._wmls};
				case S:
				//case Asm:
					return new[] {Extensions._s, Extensions._asm};
				case C:
				//case Cc:
				//case Cxx:
				//case Cpp:
				//case H:
				//case Hh:
				//case Dic:
					return new[] {Extensions._c, Extensions._cc, Extensions._cxx, Extensions._cpp, Extensions._h, Extensions._hh, Extensions._dic};
				case F:
				//case For:
				//case F77:
				//case F90:
					return new[] {Extensions._f, Extensions._for, Extensions._f77, Extensions._f90};
				case Java:
					return new[] {Extensions._java};
				case Nfo:
					return new[] {Extensions._nfo};
				case Opml:
					return new[] {Extensions._opml};
				case P:
				//case Pas:
					return new[] {Extensions._p, Extensions._pas};
				case Etx:
					return new[] {Extensions._etx};
				case Sfv:
					return new[] {Extensions._sfv};
				case Uu:
					return new[] {Extensions._uu};
				case Vcs:
					return new[] {Extensions._vcs};
				case Vcf:
					return new[] {Extensions._vcf};
				case _3gp:
				//case _3gpp:
					return new[] {Extensions._3gp, Extensions._3gpp};
				case _3g2:
					return new[] {Extensions._3g2};
				case H261:
					return new[] {Extensions._h261};
				case H263:
					return new[] {Extensions._h263};
				case H264:
					return new[] {Extensions._h264};
				case Jpgv:
					return new[] {Extensions._jpgv};
				case Jpm:
				//case Jpgm:
					return new[] {Extensions._jpm, Extensions._jpgm};
				case Mj2:
				//case Mjp2:
					return new[] {Extensions._mj2, Extensions._mjp2};
				case Mp4:
				//case Mp4v:
				//case Mpg4:
				//case F4p:
					return new[] {Extensions._mp4, Extensions._mp4v, Extensions._mpg4, Extensions._f4p};
				case Mpeg:
				//case Mpg:
				//case Mpe:
				//case M1v:
				//case M2v:
					return new[] {Extensions._mpeg, Extensions._mpg, Extensions._mpe, Extensions._m1v, Extensions._m2v};
				case Ogv:
					return new[] {Extensions._ogv};
				case Qt:
				//case Mov:
					return new[] {Extensions._qt, Extensions._mov};
				case Uvh:
				//case Uvvh:
					return new[] {Extensions._uvh, Extensions._uvvh};
				case Uvm:
				//case Uvvm:
					return new[] {Extensions._uvm, Extensions._uvvm};
				case Uvp:
				//case Uvvp:
					return new[] {Extensions._uvp, Extensions._uvvp};
				case Uvs:
				//case Uvvs:
					return new[] {Extensions._uvs, Extensions._uvvs};
				case Uvv:
				//case Uvvv:
					return new[] {Extensions._uvv, Extensions._uvvv};
				case Dvb:
					return new[] {Extensions._dvb};
				case Fvt:
					return new[] {Extensions._fvt};
				case Mxu:
				//case M4u:
					return new[] {Extensions._mxu, Extensions._m4u};
				case Pyv:
					return new[] {Extensions._pyv};
				case Uvu:
				//case Uvvu:
					return new[] {Extensions._uvu, Extensions._uvvu};
				case Viv:
					return new[] {Extensions._viv};
				case Webm:
					return new[] {Extensions._webm};
				case F4v:
					return new[] {Extensions._f4v};
				case Fli:
					return new[] {Extensions._fli};
				case Flv:
					return new[] {Extensions._flv};
				case M4v:
					return new[] {Extensions._m4v};
				case Mkv:
				//case Mk3d:
				//case Mks:
					return new[] {Extensions._mkv, Extensions._mk3d, Extensions._mks};
				case Mng:
					return new[] {Extensions._mng};
				case Asf:
				//case Asx:
					return new[] {Extensions._asf, Extensions._asx};
				case Vob:
					return new[] {Extensions._vob};
				case Wm:
					return new[] {Extensions._wm};
				case Wmv:
					return new[] {Extensions._wmv};
				case Wmx:
					return new[] {Extensions._wmx};
				case Wvx:
					return new[] {Extensions._wvx};
				case Avi:
					return new[] {Extensions._avi};
				case Movie:
					return new[] {Extensions._movie};
				case Smv:
					return new[] {Extensions._smv};
				case Ice:
					return new[] {Extensions._ice};
				case Jsonld:
					return new[] {Extensions._jsonld};
				case Geojson:
					return new[] {Extensions._geojson};
				case Mjs:
					return new[] {Extensions._mjs};
				case Wasm:
					return new[] {Extensions._wasm};
				case Webmanifest:
					return new[] {Extensions._webmanifest};
				case Webapp:
					return new[] {Extensions._webapp};
				case Jxr:
				//case Hdp:
					return new[] {Extensions._jxr, Extensions._hdp};
				case Jng:
					return new[] {Extensions._jng};
				case Bbaw:
					return new[] {Extensions._bbaw};
				case Crx:
					return new[] {Extensions._crx};
				case Cco:
					return new[] {Extensions._cco};
				case Jardiff:
					return new[] {Extensions._jardiff};
				case Run:
					return new[] {Extensions._run};
				case Oex:
					return new[] {Extensions._oex};
				case Pl:
				//case Pm:
					return new[] {Extensions._pl, Extensions._pm};
				case Rpm:
					return new[] {Extensions._rpm};
				case Sea:
					return new[] {Extensions._sea};
				case Md:
				//case Markdown:
					return new[] {Extensions._md, Extensions._markdown};
				case Mml:
					return new[] {Extensions._mml};
				case Xloc:
					return new[] {Extensions._xloc};
				case Vtt:
					return new[] {Extensions._vtt};
				case Htc:
					return new[] {Extensions._htc};
				case Bdoc:
					return new[] {Extensions._bdoc};
				case Hjson:
					return new[] {Extensions._hjson};
				case Json5:
					return new[] {Extensions._json5};
				case Cjs:
					return new[] {Extensions._cjs};
				case Raml:
					return new[] {Extensions._raml};
				case Siv:
				//case Sieve:
					return new[] {Extensions._siv, Extensions._sieve};
				case Toml:
					return new[] {Extensions._toml};
				case Ubj:
					return new[] {Extensions._ubj};
				case Pkpass:
					return new[] {Extensions._pkpass};
				case Gdoc:
					return new[] {Extensions._gdoc};
				case Gslides:
					return new[] {Extensions._gslides};
				case Gsheet:
					return new[] {Extensions._gsheet};
				case Msg:
					return new[] {Extensions._msg};
				case Arj:
					return new[] {Extensions._arj};
				case Php:
					return new[] {Extensions._php};
				case Kdbx:
					return new[] {Extensions._kdbx};
				case Luac:
					return new[] {Extensions._luac};
				case Pac:
					return new[] {Extensions._pac};
				case Hdd:
					return new[] {Extensions._hdd};
				case Ova:
					return new[] {Extensions._ova};
				case Ovf:
					return new[] {Extensions._ovf};
				case Vbox:
					return new[] {Extensions._vbox};
				case Vboxextpack:
					return new[] {Extensions._vbox_extpack};
				case Vdi:
					return new[] {Extensions._vdi};
				case Vhd:
					return new[] {Extensions._vhd};
				case Vmdk:
					return new[] {Extensions._vmdk};
				case Apng:
					return new[] {Extensions._apng};
				case Avif:
					return new[] {Extensions._avif};
				case Heic:
					return new[] {Extensions._heic};
				case Heics:
					return new[] {Extensions._heics};
				case Heif:
					return new[] {Extensions._heif};
				case Heifs:
					return new[] {Extensions._heifs};
				case Jp2:
				//case Jpg2:
					return new[] {Extensions._jp2, Extensions._jpg2};
				case Jpx:
				//case Jpf:
					return new[] {Extensions._jpx, Extensions._jpf};
				case Dds:
					return new[] {Extensions._dds};
				case Coffee:
				//case Litcoffee:
					return new[] {Extensions._coffee, Extensions._litcoffee};
				case Jade:
					return new[] {Extensions._jade};
				case Jsx:
					return new[] {Extensions._jsx};
				case Less:
					return new[] {Extensions._less};
				case Mdx:
					return new[] {Extensions._mdx};
				case Shex:
					return new[] {Extensions._shex};
				case Slim:
				//case Slm:
					return new[] {Extensions._slim, Extensions._slm};
				case Stylus:
				//case Styl:
					return new[] {Extensions._stylus, Extensions._styl};
				case Hbs:
					return new[] {Extensions._hbs};
				case Lua:
					return new[] {Extensions._lua};
				case Mkd:
					return new[] {Extensions._mkd};
				case Pde:
					return new[] {Extensions._pde};
				case Sass:
					return new[] {Extensions._sass};
				case Scss:
					return new[] {Extensions._scss};
				case Ymp:
					return new[] {Extensions._ymp};
				case Yaml:
				//case Yml:
					return new[] {Extensions._yaml, Extensions._yml};
				default: 
					return null;
            }
		}
    }
}
