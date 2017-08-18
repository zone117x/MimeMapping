

using System;
using System.Collections.Generic;

namespace MimeMapping
{

	///<summary>
	/// MIME type constants. Last updated on 2017-08-18T19:21:28Z. 
	/// Generated from the <a href="http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types">apache</a> and <a href="https://raw.githubusercontent.com/h5bp/server-configs-nginx/master/mime.types">nginx</a> sources
	///</summary>
    public static class KnownMimeTypes
    {

        // Dupe for wmz: using application/x-ms-wmz vs application/x-msmetafile 
        // Dupe for sub: using image/vnd.dvb.subtitle vs text/vnd.dvb.subtitle 
        // Dupe for rdf: using application/rdf+xml vs application/xml 
        // Dupe for aac: using audio/x-aac vs audio/mp4 
        // Dupe for ra: using audio/x-pn-realaudio vs audio/x-realaudio 
        // Dupe for wdp: using image/vnd.ms-photo vs image/jxr 
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

		// Generated 785 unique mime type values
        // Generated 1022 type key pairs


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

		///<summary>woff</summary>
        public const string Woff = "application/font-woff";

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

		///<summary>otf</summary>
        public const string Otf = "application/x-font-otf";

		///<summary>pcf</summary>
        public const string Pcf = "application/x-font-pcf";

		///<summary>snf</summary>
        public const string Snf = "application/x-font-snf";

		///<summary>ttf</summary>
        public const string Ttf = "application/x-font-ttf";

		///<summary>ttc</summary>
        public const string Ttc = "application/x-font-ttf";

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
        public const string Geojson = "application/vnd.geo+json";

		///<summary>webmanifest</summary>
        public const string Webmanifest = "application/manifest+json";

		///<summary>webapp</summary>
        public const string Webapp = "application/x-web-app-manifest+json";

		///<summary>f4a</summary>
        public const string F4a = "audio/mp4";

		///<summary>f4b</summary>
        public const string F4b = "audio/mp4";

		///<summary>opus</summary>
        public const string Opus = "audio/ogg";

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

		///<summary>woff2</summary>
        public const string Woff2 = "application/font-woff2";

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

		///<summary>mml</summary>
        public const string Mml = "text/mathml";

		///<summary>xloc</summary>
        public const string Xloc = "text/vnd.rim.location.xloc";

		///<summary>vtt</summary>
        public const string Vtt = "text/vtt";

		///<summary>htc</summary>
        public const string Htc = "text/x-component";


        const string _ext_ez = "ez";
        const string _ext_aw = "aw";
        const string _ext_atom = "atom";
        const string _ext_atomcat = "atomcat";
        const string _ext_atomsvc = "atomsvc";
        const string _ext_ccxml = "ccxml";
        const string _ext_cdmia = "cdmia";
        const string _ext_cdmic = "cdmic";
        const string _ext_cdmid = "cdmid";
        const string _ext_cdmio = "cdmio";
        const string _ext_cdmiq = "cdmiq";
        const string _ext_cu = "cu";
        const string _ext_davmount = "davmount";
        const string _ext_dbk = "dbk";
        const string _ext_dssc = "dssc";
        const string _ext_xdssc = "xdssc";
        const string _ext_ecma = "ecma";
        const string _ext_emma = "emma";
        const string _ext_epub = "epub";
        const string _ext_exi = "exi";
        const string _ext_pfr = "pfr";
        const string _ext_woff = "woff";
        const string _ext_gml = "gml";
        const string _ext_gpx = "gpx";
        const string _ext_gxf = "gxf";
        const string _ext_stk = "stk";
        const string _ext_ink = "ink";
        const string _ext_inkml = "inkml";
        const string _ext_ipfix = "ipfix";
        const string _ext_jar = "jar";
        const string _ext_ser = "ser";
        const string _ext_class = "class";
        const string _ext_js = "js";
        const string _ext_json = "json";
        const string _ext_jsonml = "jsonml";
        const string _ext_lostxml = "lostxml";
        const string _ext_hqx = "hqx";
        const string _ext_cpt = "cpt";
        const string _ext_mads = "mads";
        const string _ext_mrc = "mrc";
        const string _ext_mrcx = "mrcx";
        const string _ext_ma = "ma";
        const string _ext_nb = "nb";
        const string _ext_mb = "mb";
        const string _ext_mathml = "mathml";
        const string _ext_mbox = "mbox";
        const string _ext_mscml = "mscml";
        const string _ext_metalink = "metalink";
        const string _ext_meta4 = "meta4";
        const string _ext_mets = "mets";
        const string _ext_mods = "mods";
        const string _ext_m21 = "m21";
        const string _ext_mp21 = "mp21";
        const string _ext_mp4s = "mp4s";
        const string _ext_doc = "doc";
        const string _ext_dot = "dot";
        const string _ext_mxf = "mxf";
        const string _ext_bin = "bin";
        const string _ext_dms = "dms";
        const string _ext_lrf = "lrf";
        const string _ext_mar = "mar";
        const string _ext_so = "so";
        const string _ext_dist = "dist";
        const string _ext_distz = "distz";
        const string _ext_pkg = "pkg";
        const string _ext_bpk = "bpk";
        const string _ext_dump = "dump";
        const string _ext_elc = "elc";
        const string _ext_deploy = "deploy";
        const string _ext_oda = "oda";
        const string _ext_opf = "opf";
        const string _ext_ogx = "ogx";
        const string _ext_omdoc = "omdoc";
        const string _ext_onetoc = "onetoc";
        const string _ext_onetoc2 = "onetoc2";
        const string _ext_onetmp = "onetmp";
        const string _ext_onepkg = "onepkg";
        const string _ext_oxps = "oxps";
        const string _ext_xer = "xer";
        const string _ext_pdf = "pdf";
        const string _ext_pgp = "pgp";
        const string _ext_asc = "asc";
        const string _ext_sig = "sig";
        const string _ext_prf = "prf";
        const string _ext_p10 = "p10";
        const string _ext_p7m = "p7m";
        const string _ext_p7c = "p7c";
        const string _ext_p7s = "p7s";
        const string _ext_p8 = "p8";
        const string _ext_ac = "ac";
        const string _ext_cer = "cer";
        const string _ext_crl = "crl";
        const string _ext_pkipath = "pkipath";
        const string _ext_pki = "pki";
        const string _ext_pls = "pls";
        const string _ext_ai = "ai";
        const string _ext_eps = "eps";
        const string _ext_ps = "ps";
        const string _ext_cww = "cww";
        const string _ext_pskcxml = "pskcxml";
        const string _ext_rdf = "rdf";
        const string _ext_rif = "rif";
        const string _ext_rnc = "rnc";
        const string _ext_rl = "rl";
        const string _ext_rld = "rld";
        const string _ext_rs = "rs";
        const string _ext_gbr = "gbr";
        const string _ext_mft = "mft";
        const string _ext_roa = "roa";
        const string _ext_rsd = "rsd";
        const string _ext_rss = "rss";
        const string _ext_rtf = "rtf";
        const string _ext_sbml = "sbml";
        const string _ext_scq = "scq";
        const string _ext_scs = "scs";
        const string _ext_spq = "spq";
        const string _ext_spp = "spp";
        const string _ext_sdp = "sdp";
        const string _ext_setpay = "setpay";
        const string _ext_setreg = "setreg";
        const string _ext_shf = "shf";
        const string _ext_smi = "smi";
        const string _ext_smil = "smil";
        const string _ext_rq = "rq";
        const string _ext_srx = "srx";
        const string _ext_gram = "gram";
        const string _ext_grxml = "grxml";
        const string _ext_sru = "sru";
        const string _ext_ssdl = "ssdl";
        const string _ext_ssml = "ssml";
        const string _ext_tei = "tei";
        const string _ext_teicorpus = "teicorpus";
        const string _ext_tfi = "tfi";
        const string _ext_tsd = "tsd";
        const string _ext_plb = "plb";
        const string _ext_psb = "psb";
        const string _ext_pvb = "pvb";
        const string _ext_tcap = "tcap";
        const string _ext_pwn = "pwn";
        const string _ext_aso = "aso";
        const string _ext_imp = "imp";
        const string _ext_acu = "acu";
        const string _ext_atc = "atc";
        const string _ext_acutc = "acutc";
        const string _ext_air = "air";
        const string _ext_fcdt = "fcdt";
        const string _ext_fxp = "fxp";
        const string _ext_fxpl = "fxpl";
        const string _ext_xdp = "xdp";
        const string _ext_xfdf = "xfdf";
        const string _ext_ahead = "ahead";
        const string _ext_azf = "azf";
        const string _ext_azs = "azs";
        const string _ext_azw = "azw";
        const string _ext_acc = "acc";
        const string _ext_ami = "ami";
        const string _ext_apk = "apk";
        const string _ext_cii = "cii";
        const string _ext_fti = "fti";
        const string _ext_atx = "atx";
        const string _ext_mpkg = "mpkg";
        const string _ext_m3u8 = "m3u8";
        const string _ext_swi = "swi";
        const string _ext_iota = "iota";
        const string _ext_aep = "aep";
        const string _ext_mpm = "mpm";
        const string _ext_bmi = "bmi";
        const string _ext_rep = "rep";
        const string _ext_cdxml = "cdxml";
        const string _ext_mmd = "mmd";
        const string _ext_cdy = "cdy";
        const string _ext_cla = "cla";
        const string _ext_rp9 = "rp9";
        const string _ext_c4g = "c4g";
        const string _ext_c4d = "c4d";
        const string _ext_c4f = "c4f";
        const string _ext_c4p = "c4p";
        const string _ext_c4u = "c4u";
        const string _ext_c11amc = "c11amc";
        const string _ext_c11amz = "c11amz";
        const string _ext_csp = "csp";
        const string _ext_cdbcmsg = "cdbcmsg";
        const string _ext_cmc = "cmc";
        const string _ext_clkx = "clkx";
        const string _ext_clkk = "clkk";
        const string _ext_clkp = "clkp";
        const string _ext_clkt = "clkt";
        const string _ext_clkw = "clkw";
        const string _ext_wbs = "wbs";
        const string _ext_pml = "pml";
        const string _ext_ppd = "ppd";
        const string _ext_car = "car";
        const string _ext_pcurl = "pcurl";
        const string _ext_dart = "dart";
        const string _ext_rdz = "rdz";
        const string _ext_uvf = "uvf";
        const string _ext_uvvf = "uvvf";
        const string _ext_uvd = "uvd";
        const string _ext_uvvd = "uvvd";
        const string _ext_uvt = "uvt";
        const string _ext_uvvt = "uvvt";
        const string _ext_uvx = "uvx";
        const string _ext_uvvx = "uvvx";
        const string _ext_uvz = "uvz";
        const string _ext_uvvz = "uvvz";
        const string _ext_fe_launch = "fe_launch";
        const string _ext_dna = "dna";
        const string _ext_mlp = "mlp";
        const string _ext_dpg = "dpg";
        const string _ext_dfac = "dfac";
        const string _ext_kpxx = "kpxx";
        const string _ext_ait = "ait";
        const string _ext_svc = "svc";
        const string _ext_geo = "geo";
        const string _ext_mag = "mag";
        const string _ext_nml = "nml";
        const string _ext_esf = "esf";
        const string _ext_msf = "msf";
        const string _ext_qam = "qam";
        const string _ext_slt = "slt";
        const string _ext_ssf = "ssf";
        const string _ext_es3 = "es3";
        const string _ext_et3 = "et3";
        const string _ext_ez2 = "ez2";
        const string _ext_ez3 = "ez3";
        const string _ext_fdf = "fdf";
        const string _ext_mseed = "mseed";
        const string _ext_seed = "seed";
        const string _ext_dataless = "dataless";
        const string _ext_gph = "gph";
        const string _ext_ftc = "ftc";
        const string _ext_fm = "fm";
        const string _ext_frame = "frame";
        const string _ext_maker = "maker";
        const string _ext_book = "book";
        const string _ext_fnc = "fnc";
        const string _ext_ltf = "ltf";
        const string _ext_fsc = "fsc";
        const string _ext_oas = "oas";
        const string _ext_oa2 = "oa2";
        const string _ext_oa3 = "oa3";
        const string _ext_fg5 = "fg5";
        const string _ext_bh2 = "bh2";
        const string _ext_ddd = "ddd";
        const string _ext_xdw = "xdw";
        const string _ext_xbd = "xbd";
        const string _ext_fzs = "fzs";
        const string _ext_txd = "txd";
        const string _ext_ggb = "ggb";
        const string _ext_ggt = "ggt";
        const string _ext_gex = "gex";
        const string _ext_gre = "gre";
        const string _ext_gxt = "gxt";
        const string _ext_g2w = "g2w";
        const string _ext_g3w = "g3w";
        const string _ext_gmx = "gmx";
        const string _ext_kml = "kml";
        const string _ext_kmz = "kmz";
        const string _ext_gqf = "gqf";
        const string _ext_gqs = "gqs";
        const string _ext_gac = "gac";
        const string _ext_ghf = "ghf";
        const string _ext_gim = "gim";
        const string _ext_grv = "grv";
        const string _ext_gtm = "gtm";
        const string _ext_tpl = "tpl";
        const string _ext_vcg = "vcg";
        const string _ext_hal = "hal";
        const string _ext_zmm = "zmm";
        const string _ext_hbci = "hbci";
        const string _ext_les = "les";
        const string _ext_hpgl = "hpgl";
        const string _ext_hpid = "hpid";
        const string _ext_hps = "hps";
        const string _ext_jlt = "jlt";
        const string _ext_pcl = "pcl";
        const string _ext_pclxl = "pclxl";
        const string _ext_sfd_hdstx = "sfd-hdstx";
        const string _ext_mpy = "mpy";
        const string _ext_afp = "afp";
        const string _ext_listafp = "listafp";
        const string _ext_list3820 = "list3820";
        const string _ext_irm = "irm";
        const string _ext_sc = "sc";
        const string _ext_icc = "icc";
        const string _ext_icm = "icm";
        const string _ext_igl = "igl";
        const string _ext_ivp = "ivp";
        const string _ext_ivu = "ivu";
        const string _ext_igm = "igm";
        const string _ext_xpw = "xpw";
        const string _ext_xpx = "xpx";
        const string _ext_i2g = "i2g";
        const string _ext_qbo = "qbo";
        const string _ext_qfx = "qfx";
        const string _ext_rcprofile = "rcprofile";
        const string _ext_irp = "irp";
        const string _ext_xpr = "xpr";
        const string _ext_fcs = "fcs";
        const string _ext_jam = "jam";
        const string _ext_rms = "rms";
        const string _ext_jisp = "jisp";
        const string _ext_joda = "joda";
        const string _ext_ktz = "ktz";
        const string _ext_ktr = "ktr";
        const string _ext_karbon = "karbon";
        const string _ext_chrt = "chrt";
        const string _ext_kfo = "kfo";
        const string _ext_flw = "flw";
        const string _ext_kon = "kon";
        const string _ext_kpr = "kpr";
        const string _ext_kpt = "kpt";
        const string _ext_ksp = "ksp";
        const string _ext_kwd = "kwd";
        const string _ext_kwt = "kwt";
        const string _ext_htke = "htke";
        const string _ext_kia = "kia";
        const string _ext_kne = "kne";
        const string _ext_knp = "knp";
        const string _ext_skp = "skp";
        const string _ext_skd = "skd";
        const string _ext_skt = "skt";
        const string _ext_skm = "skm";
        const string _ext_sse = "sse";
        const string _ext_lasxml = "lasxml";
        const string _ext_lbd = "lbd";
        const string _ext_lbe = "lbe";
        const string _ext_123 = "123";
        const string _ext_apr = "apr";
        const string _ext_pre = "pre";
        const string _ext_nsf = "nsf";
        const string _ext_org = "org";
        const string _ext_scm = "scm";
        const string _ext_lwp = "lwp";
        const string _ext_portpkg = "portpkg";
        const string _ext_mcd = "mcd";
        const string _ext_mc1 = "mc1";
        const string _ext_cdkey = "cdkey";
        const string _ext_mwf = "mwf";
        const string _ext_mfm = "mfm";
        const string _ext_flo = "flo";
        const string _ext_igx = "igx";
        const string _ext_mif = "mif";
        const string _ext_daf = "daf";
        const string _ext_dis = "dis";
        const string _ext_mbk = "mbk";
        const string _ext_mqy = "mqy";
        const string _ext_msl = "msl";
        const string _ext_plc = "plc";
        const string _ext_txf = "txf";
        const string _ext_mpn = "mpn";
        const string _ext_mpc = "mpc";
        const string _ext_xul = "xul";
        const string _ext_cil = "cil";
        const string _ext_cab = "cab";
        const string _ext_xls = "xls";
        const string _ext_xlm = "xlm";
        const string _ext_xla = "xla";
        const string _ext_xlc = "xlc";
        const string _ext_xlt = "xlt";
        const string _ext_xlw = "xlw";
        const string _ext_xlam = "xlam";
        const string _ext_xlsb = "xlsb";
        const string _ext_xlsm = "xlsm";
        const string _ext_xltm = "xltm";
        const string _ext_eot = "eot";
        const string _ext_chm = "chm";
        const string _ext_ims = "ims";
        const string _ext_lrm = "lrm";
        const string _ext_thmx = "thmx";
        const string _ext_cat = "cat";
        const string _ext_stl = "stl";
        const string _ext_ppt = "ppt";
        const string _ext_pps = "pps";
        const string _ext_pot = "pot";
        const string _ext_ppam = "ppam";
        const string _ext_pptm = "pptm";
        const string _ext_sldm = "sldm";
        const string _ext_ppsm = "ppsm";
        const string _ext_potm = "potm";
        const string _ext_mpp = "mpp";
        const string _ext_mpt = "mpt";
        const string _ext_docm = "docm";
        const string _ext_dotm = "dotm";
        const string _ext_wps = "wps";
        const string _ext_wks = "wks";
        const string _ext_wcm = "wcm";
        const string _ext_wdb = "wdb";
        const string _ext_wpl = "wpl";
        const string _ext_xps = "xps";
        const string _ext_mseq = "mseq";
        const string _ext_mus = "mus";
        const string _ext_msty = "msty";
        const string _ext_taglet = "taglet";
        const string _ext_nlu = "nlu";
        const string _ext_ntf = "ntf";
        const string _ext_nitf = "nitf";
        const string _ext_nnd = "nnd";
        const string _ext_nns = "nns";
        const string _ext_nnw = "nnw";
        const string _ext_ngdat = "ngdat";
        const string _ext_n_gage = "n-gage";
        const string _ext_rpst = "rpst";
        const string _ext_rpss = "rpss";
        const string _ext_edm = "edm";
        const string _ext_edx = "edx";
        const string _ext_ext = "ext";
        const string _ext_odc = "odc";
        const string _ext_otc = "otc";
        const string _ext_odb = "odb";
        const string _ext_odf = "odf";
        const string _ext_odft = "odft";
        const string _ext_odg = "odg";
        const string _ext_otg = "otg";
        const string _ext_odi = "odi";
        const string _ext_oti = "oti";
        const string _ext_odp = "odp";
        const string _ext_otp = "otp";
        const string _ext_ods = "ods";
        const string _ext_ots = "ots";
        const string _ext_odt = "odt";
        const string _ext_odm = "odm";
        const string _ext_ott = "ott";
        const string _ext_oth = "oth";
        const string _ext_xo = "xo";
        const string _ext_dd2 = "dd2";
        const string _ext_oxt = "oxt";
        const string _ext_pptx = "pptx";
        const string _ext_sldx = "sldx";
        const string _ext_ppsx = "ppsx";
        const string _ext_potx = "potx";
        const string _ext_xlsx = "xlsx";
        const string _ext_xltx = "xltx";
        const string _ext_docx = "docx";
        const string _ext_dotx = "dotx";
        const string _ext_mgp = "mgp";
        const string _ext_dp = "dp";
        const string _ext_esa = "esa";
        const string _ext_pdb = "pdb";
        const string _ext_pqa = "pqa";
        const string _ext_oprc = "oprc";
        const string _ext_paw = "paw";
        const string _ext_str = "str";
        const string _ext_ei6 = "ei6";
        const string _ext_efif = "efif";
        const string _ext_wg = "wg";
        const string _ext_plf = "plf";
        const string _ext_pbd = "pbd";
        const string _ext_box = "box";
        const string _ext_mgz = "mgz";
        const string _ext_qps = "qps";
        const string _ext_ptid = "ptid";
        const string _ext_qxd = "qxd";
        const string _ext_qxt = "qxt";
        const string _ext_qwd = "qwd";
        const string _ext_qwt = "qwt";
        const string _ext_qxl = "qxl";
        const string _ext_qxb = "qxb";
        const string _ext_bed = "bed";
        const string _ext_mxl = "mxl";
        const string _ext_musicxml = "musicxml";
        const string _ext_cryptonote = "cryptonote";
        const string _ext_cod = "cod";
        const string _ext_rm = "rm";
        const string _ext_rmvb = "rmvb";
        const string _ext_link66 = "link66";
        const string _ext_st = "st";
        const string _ext_see = "see";
        const string _ext_sema = "sema";
        const string _ext_semd = "semd";
        const string _ext_semf = "semf";
        const string _ext_ifm = "ifm";
        const string _ext_itp = "itp";
        const string _ext_iif = "iif";
        const string _ext_ipk = "ipk";
        const string _ext_twd = "twd";
        const string _ext_twds = "twds";
        const string _ext_mmf = "mmf";
        const string _ext_teacher = "teacher";
        const string _ext_sdkm = "sdkm";
        const string _ext_sdkd = "sdkd";
        const string _ext_dxp = "dxp";
        const string _ext_sfs = "sfs";
        const string _ext_sdc = "sdc";
        const string _ext_sda = "sda";
        const string _ext_sdd = "sdd";
        const string _ext_smf = "smf";
        const string _ext_sdw = "sdw";
        const string _ext_vor = "vor";
        const string _ext_sgl = "sgl";
        const string _ext_smzip = "smzip";
        const string _ext_sm = "sm";
        const string _ext_sxc = "sxc";
        const string _ext_stc = "stc";
        const string _ext_sxd = "sxd";
        const string _ext_std = "std";
        const string _ext_sxi = "sxi";
        const string _ext_sti = "sti";
        const string _ext_sxm = "sxm";
        const string _ext_sxw = "sxw";
        const string _ext_sxg = "sxg";
        const string _ext_stw = "stw";
        const string _ext_sus = "sus";
        const string _ext_susp = "susp";
        const string _ext_svd = "svd";
        const string _ext_sis = "sis";
        const string _ext_sisx = "sisx";
        const string _ext_xsm = "xsm";
        const string _ext_bdm = "bdm";
        const string _ext_xdm = "xdm";
        const string _ext_tao = "tao";
        const string _ext_pcap = "pcap";
        const string _ext_cap = "cap";
        const string _ext_dmp = "dmp";
        const string _ext_tmo = "tmo";
        const string _ext_tpt = "tpt";
        const string _ext_mxs = "mxs";
        const string _ext_tra = "tra";
        const string _ext_ufd = "ufd";
        const string _ext_ufdl = "ufdl";
        const string _ext_utz = "utz";
        const string _ext_umj = "umj";
        const string _ext_unityweb = "unityweb";
        const string _ext_uoml = "uoml";
        const string _ext_vcx = "vcx";
        const string _ext_vsd = "vsd";
        const string _ext_vst = "vst";
        const string _ext_vss = "vss";
        const string _ext_vsw = "vsw";
        const string _ext_vis = "vis";
        const string _ext_vsf = "vsf";
        const string _ext_wbxml = "wbxml";
        const string _ext_wmlc = "wmlc";
        const string _ext_wmlsc = "wmlsc";
        const string _ext_wtb = "wtb";
        const string _ext_nbp = "nbp";
        const string _ext_wpd = "wpd";
        const string _ext_wqd = "wqd";
        const string _ext_stf = "stf";
        const string _ext_xar = "xar";
        const string _ext_xfdl = "xfdl";
        const string _ext_hvd = "hvd";
        const string _ext_hvs = "hvs";
        const string _ext_hvp = "hvp";
        const string _ext_osf = "osf";
        const string _ext_osfpvg = "osfpvg";
        const string _ext_saf = "saf";
        const string _ext_spf = "spf";
        const string _ext_cmp = "cmp";
        const string _ext_zir = "zir";
        const string _ext_zirz = "zirz";
        const string _ext_zaz = "zaz";
        const string _ext_vxml = "vxml";
        const string _ext_wgt = "wgt";
        const string _ext_hlp = "hlp";
        const string _ext_wsdl = "wsdl";
        const string _ext_wspolicy = "wspolicy";
        const string _ext_7z = "7z";
        const string _ext_abw = "abw";
        const string _ext_ace = "ace";
        const string _ext_dmg = "dmg";
        const string _ext_aab = "aab";
        const string _ext_x32 = "x32";
        const string _ext_u32 = "u32";
        const string _ext_vox = "vox";
        const string _ext_aam = "aam";
        const string _ext_aas = "aas";
        const string _ext_bcpio = "bcpio";
        const string _ext_torrent = "torrent";
        const string _ext_blb = "blb";
        const string _ext_blorb = "blorb";
        const string _ext_bz = "bz";
        const string _ext_bz2 = "bz2";
        const string _ext_boz = "boz";
        const string _ext_cbr = "cbr";
        const string _ext_cba = "cba";
        const string _ext_cbt = "cbt";
        const string _ext_cbz = "cbz";
        const string _ext_cb7 = "cb7";
        const string _ext_vcd = "vcd";
        const string _ext_cfs = "cfs";
        const string _ext_chat = "chat";
        const string _ext_pgn = "pgn";
        const string _ext_nsc = "nsc";
        const string _ext_cpio = "cpio";
        const string _ext_csh = "csh";
        const string _ext_deb = "deb";
        const string _ext_udeb = "udeb";
        const string _ext_dgc = "dgc";
        const string _ext_dir = "dir";
        const string _ext_dcr = "dcr";
        const string _ext_dxr = "dxr";
        const string _ext_cst = "cst";
        const string _ext_cct = "cct";
        const string _ext_cxt = "cxt";
        const string _ext_w3d = "w3d";
        const string _ext_fgd = "fgd";
        const string _ext_swa = "swa";
        const string _ext_wad = "wad";
        const string _ext_ncx = "ncx";
        const string _ext_dtb = "dtb";
        const string _ext_res = "res";
        const string _ext_dvi = "dvi";
        const string _ext_evy = "evy";
        const string _ext_eva = "eva";
        const string _ext_bdf = "bdf";
        const string _ext_gsf = "gsf";
        const string _ext_psf = "psf";
        const string _ext_otf = "otf";
        const string _ext_pcf = "pcf";
        const string _ext_snf = "snf";
        const string _ext_ttf = "ttf";
        const string _ext_ttc = "ttc";
        const string _ext_pfa = "pfa";
        const string _ext_pfb = "pfb";
        const string _ext_pfm = "pfm";
        const string _ext_afm = "afm";
        const string _ext_arc = "arc";
        const string _ext_spl = "spl";
        const string _ext_gca = "gca";
        const string _ext_ulx = "ulx";
        const string _ext_gnumeric = "gnumeric";
        const string _ext_gramps = "gramps";
        const string _ext_gtar = "gtar";
        const string _ext_hdf = "hdf";
        const string _ext_install = "install";
        const string _ext_iso = "iso";
        const string _ext_jnlp = "jnlp";
        const string _ext_latex = "latex";
        const string _ext_lzh = "lzh";
        const string _ext_lha = "lha";
        const string _ext_mie = "mie";
        const string _ext_prc = "prc";
        const string _ext_mobi = "mobi";
        const string _ext_application = "application";
        const string _ext_lnk = "lnk";
        const string _ext_wmd = "wmd";
        const string _ext_wmz = "wmz";
        const string _ext_xbap = "xbap";
        const string _ext_mdb = "mdb";
        const string _ext_obd = "obd";
        const string _ext_crd = "crd";
        const string _ext_clp = "clp";
        const string _ext_exe = "exe";
        const string _ext_dll = "dll";
        const string _ext_com = "com";
        const string _ext_bat = "bat";
        const string _ext_msi = "msi";
        const string _ext_mvb = "mvb";
        const string _ext_m13 = "m13";
        const string _ext_m14 = "m14";
        const string _ext_wmf = "wmf";
        const string _ext_emf = "emf";
        const string _ext_emz = "emz";
        const string _ext_mny = "mny";
        const string _ext_pub = "pub";
        const string _ext_scd = "scd";
        const string _ext_trm = "trm";
        const string _ext_wri = "wri";
        const string _ext_nc = "nc";
        const string _ext_cdf = "cdf";
        const string _ext_nzb = "nzb";
        const string _ext_p12 = "p12";
        const string _ext_pfx = "pfx";
        const string _ext_p7b = "p7b";
        const string _ext_spc = "spc";
        const string _ext_p7r = "p7r";
        const string _ext_rar = "rar";
        const string _ext_ris = "ris";
        const string _ext_sh = "sh";
        const string _ext_shar = "shar";
        const string _ext_swf = "swf";
        const string _ext_xap = "xap";
        const string _ext_sql = "sql";
        const string _ext_sit = "sit";
        const string _ext_sitx = "sitx";
        const string _ext_srt = "srt";
        const string _ext_sv4cpio = "sv4cpio";
        const string _ext_sv4crc = "sv4crc";
        const string _ext_t3 = "t3";
        const string _ext_gam = "gam";
        const string _ext_tar = "tar";
        const string _ext_tcl = "tcl";
        const string _ext_tex = "tex";
        const string _ext_tfm = "tfm";
        const string _ext_texinfo = "texinfo";
        const string _ext_texi = "texi";
        const string _ext_obj = "obj";
        const string _ext_ustar = "ustar";
        const string _ext_src = "src";
        const string _ext_der = "der";
        const string _ext_crt = "crt";
        const string _ext_fig = "fig";
        const string _ext_xlf = "xlf";
        const string _ext_xpi = "xpi";
        const string _ext_xz = "xz";
        const string _ext_z1 = "z1";
        const string _ext_z2 = "z2";
        const string _ext_z3 = "z3";
        const string _ext_z4 = "z4";
        const string _ext_z5 = "z5";
        const string _ext_z6 = "z6";
        const string _ext_z7 = "z7";
        const string _ext_z8 = "z8";
        const string _ext_xaml = "xaml";
        const string _ext_xdf = "xdf";
        const string _ext_xenc = "xenc";
        const string _ext_xhtml = "xhtml";
        const string _ext_xht = "xht";
        const string _ext_xml = "xml";
        const string _ext_xsl = "xsl";
        const string _ext_dtd = "dtd";
        const string _ext_xop = "xop";
        const string _ext_xpl = "xpl";
        const string _ext_xslt = "xslt";
        const string _ext_xspf = "xspf";
        const string _ext_mxml = "mxml";
        const string _ext_xhvml = "xhvml";
        const string _ext_xvml = "xvml";
        const string _ext_xvm = "xvm";
        const string _ext_yang = "yang";
        const string _ext_yin = "yin";
        const string _ext_zip = "zip";
        const string _ext_adp = "adp";
        const string _ext_au = "au";
        const string _ext_snd = "snd";
        const string _ext_mid = "mid";
        const string _ext_midi = "midi";
        const string _ext_kar = "kar";
        const string _ext_rmi = "rmi";
        const string _ext_m4a = "m4a";
        const string _ext_mp4a = "mp4a";
        const string _ext_mpga = "mpga";
        const string _ext_mp2 = "mp2";
        const string _ext_mp2a = "mp2a";
        const string _ext_mp3 = "mp3";
        const string _ext_m2a = "m2a";
        const string _ext_m3a = "m3a";
        const string _ext_oga = "oga";
        const string _ext_ogg = "ogg";
        const string _ext_spx = "spx";
        const string _ext_s3m = "s3m";
        const string _ext_sil = "sil";
        const string _ext_uva = "uva";
        const string _ext_uvva = "uvva";
        const string _ext_eol = "eol";
        const string _ext_dra = "dra";
        const string _ext_dts = "dts";
        const string _ext_dtshd = "dtshd";
        const string _ext_lvp = "lvp";
        const string _ext_pya = "pya";
        const string _ext_ecelp4800 = "ecelp4800";
        const string _ext_ecelp7470 = "ecelp7470";
        const string _ext_ecelp9600 = "ecelp9600";
        const string _ext_rip = "rip";
        const string _ext_weba = "weba";
        const string _ext_aac = "aac";
        const string _ext_aif = "aif";
        const string _ext_aiff = "aiff";
        const string _ext_aifc = "aifc";
        const string _ext_caf = "caf";
        const string _ext_flac = "flac";
        const string _ext_mka = "mka";
        const string _ext_m3u = "m3u";
        const string _ext_wax = "wax";
        const string _ext_wma = "wma";
        const string _ext_ram = "ram";
        const string _ext_ra = "ra";
        const string _ext_rmp = "rmp";
        const string _ext_wav = "wav";
        const string _ext_xm = "xm";
        const string _ext_cdx = "cdx";
        const string _ext_cif = "cif";
        const string _ext_cmdf = "cmdf";
        const string _ext_cml = "cml";
        const string _ext_csml = "csml";
        const string _ext_xyz = "xyz";
        const string _ext_bmp = "bmp";
        const string _ext_cgm = "cgm";
        const string _ext_g3 = "g3";
        const string _ext_gif = "gif";
        const string _ext_ief = "ief";
        const string _ext_jpeg = "jpeg";
        const string _ext_jpg = "jpg";
        const string _ext_jpe = "jpe";
        const string _ext_ktx = "ktx";
        const string _ext_png = "png";
        const string _ext_btif = "btif";
        const string _ext_sgi = "sgi";
        const string _ext_svg = "svg";
        const string _ext_svgz = "svgz";
        const string _ext_tiff = "tiff";
        const string _ext_tif = "tif";
        const string _ext_psd = "psd";
        const string _ext_uvi = "uvi";
        const string _ext_uvvi = "uvvi";
        const string _ext_uvg = "uvg";
        const string _ext_uvvg = "uvvg";
        const string _ext_djvu = "djvu";
        const string _ext_djv = "djv";
        const string _ext_sub = "sub";
        const string _ext_dwg = "dwg";
        const string _ext_dxf = "dxf";
        const string _ext_fbs = "fbs";
        const string _ext_fpx = "fpx";
        const string _ext_fst = "fst";
        const string _ext_mmr = "mmr";
        const string _ext_rlc = "rlc";
        const string _ext_mdi = "mdi";
        const string _ext_wdp = "wdp";
        const string _ext_npx = "npx";
        const string _ext_wbmp = "wbmp";
        const string _ext_xif = "xif";
        const string _ext_webp = "webp";
        const string _ext_3ds = "3ds";
        const string _ext_ras = "ras";
        const string _ext_cmx = "cmx";
        const string _ext_fh = "fh";
        const string _ext_fhc = "fhc";
        const string _ext_fh4 = "fh4";
        const string _ext_fh5 = "fh5";
        const string _ext_fh7 = "fh7";
        const string _ext_ico = "ico";
        const string _ext_sid = "sid";
        const string _ext_pcx = "pcx";
        const string _ext_pic = "pic";
        const string _ext_pct = "pct";
        const string _ext_pnm = "pnm";
        const string _ext_pbm = "pbm";
        const string _ext_pgm = "pgm";
        const string _ext_ppm = "ppm";
        const string _ext_rgb = "rgb";
        const string _ext_tga = "tga";
        const string _ext_xbm = "xbm";
        const string _ext_xpm = "xpm";
        const string _ext_xwd = "xwd";
        const string _ext_eml = "eml";
        const string _ext_mime = "mime";
        const string _ext_igs = "igs";
        const string _ext_iges = "iges";
        const string _ext_msh = "msh";
        const string _ext_mesh = "mesh";
        const string _ext_silo = "silo";
        const string _ext_dae = "dae";
        const string _ext_dwf = "dwf";
        const string _ext_gdl = "gdl";
        const string _ext_gtw = "gtw";
        const string _ext_mts = "mts";
        const string _ext_vtu = "vtu";
        const string _ext_wrl = "wrl";
        const string _ext_vrml = "vrml";
        const string _ext_x3db = "x3db";
        const string _ext_x3dbz = "x3dbz";
        const string _ext_x3dv = "x3dv";
        const string _ext_x3dvz = "x3dvz";
        const string _ext_x3d = "x3d";
        const string _ext_x3dz = "x3dz";
        const string _ext_appcache = "appcache";
        const string _ext_ics = "ics";
        const string _ext_ifb = "ifb";
        const string _ext_css = "css";
        const string _ext_csv = "csv";
        const string _ext_html = "html";
        const string _ext_htm = "htm";
        const string _ext_n3 = "n3";
        const string _ext_txt = "txt";
        const string _ext_text = "text";
        const string _ext_conf = "conf";
        const string _ext_def = "def";
        const string _ext_list = "list";
        const string _ext_log = "log";
        const string _ext_in = "in";
        const string _ext_dsc = "dsc";
        const string _ext_rtx = "rtx";
        const string _ext_sgml = "sgml";
        const string _ext_sgm = "sgm";
        const string _ext_tsv = "tsv";
        const string _ext_t = "t";
        const string _ext_tr = "tr";
        const string _ext_roff = "roff";
        const string _ext_man = "man";
        const string _ext_me = "me";
        const string _ext_ms = "ms";
        const string _ext_ttl = "ttl";
        const string _ext_uri = "uri";
        const string _ext_uris = "uris";
        const string _ext_urls = "urls";
        const string _ext_vcard = "vcard";
        const string _ext_curl = "curl";
        const string _ext_dcurl = "dcurl";
        const string _ext_mcurl = "mcurl";
        const string _ext_scurl = "scurl";
        const string _ext_fly = "fly";
        const string _ext_flx = "flx";
        const string _ext_gv = "gv";
        const string _ext_3dml = "3dml";
        const string _ext_spot = "spot";
        const string _ext_jad = "jad";
        const string _ext_wml = "wml";
        const string _ext_wmls = "wmls";
        const string _ext_s = "s";
        const string _ext_asm = "asm";
        const string _ext_c = "c";
        const string _ext_cc = "cc";
        const string _ext_cxx = "cxx";
        const string _ext_cpp = "cpp";
        const string _ext_h = "h";
        const string _ext_hh = "hh";
        const string _ext_dic = "dic";
        const string _ext_f = "f";
        const string _ext_for = "for";
        const string _ext_f77 = "f77";
        const string _ext_f90 = "f90";
        const string _ext_java = "java";
        const string _ext_nfo = "nfo";
        const string _ext_opml = "opml";
        const string _ext_p = "p";
        const string _ext_pas = "pas";
        const string _ext_etx = "etx";
        const string _ext_sfv = "sfv";
        const string _ext_uu = "uu";
        const string _ext_vcs = "vcs";
        const string _ext_vcf = "vcf";
        const string _ext_3gp = "3gp";
        const string _ext_3g2 = "3g2";
        const string _ext_h261 = "h261";
        const string _ext_h263 = "h263";
        const string _ext_h264 = "h264";
        const string _ext_jpgv = "jpgv";
        const string _ext_jpm = "jpm";
        const string _ext_jpgm = "jpgm";
        const string _ext_mj2 = "mj2";
        const string _ext_mjp2 = "mjp2";
        const string _ext_mp4 = "mp4";
        const string _ext_mp4v = "mp4v";
        const string _ext_mpg4 = "mpg4";
        const string _ext_mpeg = "mpeg";
        const string _ext_mpg = "mpg";
        const string _ext_mpe = "mpe";
        const string _ext_m1v = "m1v";
        const string _ext_m2v = "m2v";
        const string _ext_ogv = "ogv";
        const string _ext_qt = "qt";
        const string _ext_mov = "mov";
        const string _ext_uvh = "uvh";
        const string _ext_uvvh = "uvvh";
        const string _ext_uvm = "uvm";
        const string _ext_uvvm = "uvvm";
        const string _ext_uvp = "uvp";
        const string _ext_uvvp = "uvvp";
        const string _ext_uvs = "uvs";
        const string _ext_uvvs = "uvvs";
        const string _ext_uvv = "uvv";
        const string _ext_uvvv = "uvvv";
        const string _ext_dvb = "dvb";
        const string _ext_fvt = "fvt";
        const string _ext_mxu = "mxu";
        const string _ext_m4u = "m4u";
        const string _ext_pyv = "pyv";
        const string _ext_uvu = "uvu";
        const string _ext_uvvu = "uvvu";
        const string _ext_viv = "viv";
        const string _ext_webm = "webm";
        const string _ext_f4v = "f4v";
        const string _ext_fli = "fli";
        const string _ext_flv = "flv";
        const string _ext_m4v = "m4v";
        const string _ext_mkv = "mkv";
        const string _ext_mk3d = "mk3d";
        const string _ext_mks = "mks";
        const string _ext_mng = "mng";
        const string _ext_asf = "asf";
        const string _ext_asx = "asx";
        const string _ext_vob = "vob";
        const string _ext_wm = "wm";
        const string _ext_wmv = "wmv";
        const string _ext_wmx = "wmx";
        const string _ext_wvx = "wvx";
        const string _ext_avi = "avi";
        const string _ext_movie = "movie";
        const string _ext_smv = "smv";
        const string _ext_ice = "ice";
        const string _ext_map = "map";
        const string _ext_topojson = "topojson";
        const string _ext_jsonld = "jsonld";
        const string _ext_geojson = "geojson";
        const string _ext_webmanifest = "webmanifest";
        const string _ext_webapp = "webapp";
        const string _ext_f4a = "f4a";
        const string _ext_f4b = "f4b";
        const string _ext_opus = "opus";
        const string _ext_jxr = "jxr";
        const string _ext_hdp = "hdp";
        const string _ext_jng = "jng";
        const string _ext_3gpp = "3gpp";
        const string _ext_f4p = "f4p";
        const string _ext_cur = "cur";
        const string _ext_woff2 = "woff2";
        const string _ext_ear = "ear";
        const string _ext_war = "war";
        const string _ext_img = "img";
        const string _ext_msm = "msm";
        const string _ext_msp = "msp";
        const string _ext_safariextz = "safariextz";
        const string _ext_bbaw = "bbaw";
        const string _ext_crx = "crx";
        const string _ext_cco = "cco";
        const string _ext_jardiff = "jardiff";
        const string _ext_run = "run";
        const string _ext_oex = "oex";
        const string _ext_pl = "pl";
        const string _ext_pm = "pm";
        const string _ext_rpm = "rpm";
        const string _ext_sea = "sea";
        const string _ext_tk = "tk";
        const string _ext_pem = "pem";
        const string _ext_shtml = "shtml";
        const string _ext_md = "md";
        const string _ext_mml = "mml";
        const string _ext_xloc = "xloc";
        const string _ext_vtt = "vtt";
        const string _ext_htc = "htc";



        // List of all available extensions, used to build the dictionary
        static internal readonly Lazy<string[]> ALL_EXTS = new Lazy<string[]>(() => new [] {
            _ext_ez,
            _ext_aw,
            _ext_atom,
            _ext_atomcat,
            _ext_atomsvc,
            _ext_ccxml,
            _ext_cdmia,
            _ext_cdmic,
            _ext_cdmid,
            _ext_cdmio,
            _ext_cdmiq,
            _ext_cu,
            _ext_davmount,
            _ext_dbk,
            _ext_dssc,
            _ext_xdssc,
            _ext_ecma,
            _ext_emma,
            _ext_epub,
            _ext_exi,
            _ext_pfr,
            _ext_woff,
            _ext_gml,
            _ext_gpx,
            _ext_gxf,
            _ext_stk,
            _ext_ink,
            _ext_inkml,
            _ext_ipfix,
            _ext_jar,
            _ext_ser,
            _ext_class,
            _ext_js,
            _ext_json,
            _ext_jsonml,
            _ext_lostxml,
            _ext_hqx,
            _ext_cpt,
            _ext_mads,
            _ext_mrc,
            _ext_mrcx,
            _ext_ma,
            _ext_nb,
            _ext_mb,
            _ext_mathml,
            _ext_mbox,
            _ext_mscml,
            _ext_metalink,
            _ext_meta4,
            _ext_mets,
            _ext_mods,
            _ext_m21,
            _ext_mp21,
            _ext_mp4s,
            _ext_doc,
            _ext_dot,
            _ext_mxf,
            _ext_bin,
            _ext_dms,
            _ext_lrf,
            _ext_mar,
            _ext_so,
            _ext_dist,
            _ext_distz,
            _ext_pkg,
            _ext_bpk,
            _ext_dump,
            _ext_elc,
            _ext_deploy,
            _ext_oda,
            _ext_opf,
            _ext_ogx,
            _ext_omdoc,
            _ext_onetoc,
            _ext_onetoc2,
            _ext_onetmp,
            _ext_onepkg,
            _ext_oxps,
            _ext_xer,
            _ext_pdf,
            _ext_pgp,
            _ext_asc,
            _ext_sig,
            _ext_prf,
            _ext_p10,
            _ext_p7m,
            _ext_p7c,
            _ext_p7s,
            _ext_p8,
            _ext_ac,
            _ext_cer,
            _ext_crl,
            _ext_pkipath,
            _ext_pki,
            _ext_pls,
            _ext_ai,
            _ext_eps,
            _ext_ps,
            _ext_cww,
            _ext_pskcxml,
            _ext_rdf,
            _ext_rif,
            _ext_rnc,
            _ext_rl,
            _ext_rld,
            _ext_rs,
            _ext_gbr,
            _ext_mft,
            _ext_roa,
            _ext_rsd,
            _ext_rss,
            _ext_rtf,
            _ext_sbml,
            _ext_scq,
            _ext_scs,
            _ext_spq,
            _ext_spp,
            _ext_sdp,
            _ext_setpay,
            _ext_setreg,
            _ext_shf,
            _ext_smi,
            _ext_smil,
            _ext_rq,
            _ext_srx,
            _ext_gram,
            _ext_grxml,
            _ext_sru,
            _ext_ssdl,
            _ext_ssml,
            _ext_tei,
            _ext_teicorpus,
            _ext_tfi,
            _ext_tsd,
            _ext_plb,
            _ext_psb,
            _ext_pvb,
            _ext_tcap,
            _ext_pwn,
            _ext_aso,
            _ext_imp,
            _ext_acu,
            _ext_atc,
            _ext_acutc,
            _ext_air,
            _ext_fcdt,
            _ext_fxp,
            _ext_fxpl,
            _ext_xdp,
            _ext_xfdf,
            _ext_ahead,
            _ext_azf,
            _ext_azs,
            _ext_azw,
            _ext_acc,
            _ext_ami,
            _ext_apk,
            _ext_cii,
            _ext_fti,
            _ext_atx,
            _ext_mpkg,
            _ext_m3u8,
            _ext_swi,
            _ext_iota,
            _ext_aep,
            _ext_mpm,
            _ext_bmi,
            _ext_rep,
            _ext_cdxml,
            _ext_mmd,
            _ext_cdy,
            _ext_cla,
            _ext_rp9,
            _ext_c4g,
            _ext_c4d,
            _ext_c4f,
            _ext_c4p,
            _ext_c4u,
            _ext_c11amc,
            _ext_c11amz,
            _ext_csp,
            _ext_cdbcmsg,
            _ext_cmc,
            _ext_clkx,
            _ext_clkk,
            _ext_clkp,
            _ext_clkt,
            _ext_clkw,
            _ext_wbs,
            _ext_pml,
            _ext_ppd,
            _ext_car,
            _ext_pcurl,
            _ext_dart,
            _ext_rdz,
            _ext_uvf,
            _ext_uvvf,
            _ext_uvd,
            _ext_uvvd,
            _ext_uvt,
            _ext_uvvt,
            _ext_uvx,
            _ext_uvvx,
            _ext_uvz,
            _ext_uvvz,
            _ext_fe_launch,
            _ext_dna,
            _ext_mlp,
            _ext_dpg,
            _ext_dfac,
            _ext_kpxx,
            _ext_ait,
            _ext_svc,
            _ext_geo,
            _ext_mag,
            _ext_nml,
            _ext_esf,
            _ext_msf,
            _ext_qam,
            _ext_slt,
            _ext_ssf,
            _ext_es3,
            _ext_et3,
            _ext_ez2,
            _ext_ez3,
            _ext_fdf,
            _ext_mseed,
            _ext_seed,
            _ext_dataless,
            _ext_gph,
            _ext_ftc,
            _ext_fm,
            _ext_frame,
            _ext_maker,
            _ext_book,
            _ext_fnc,
            _ext_ltf,
            _ext_fsc,
            _ext_oas,
            _ext_oa2,
            _ext_oa3,
            _ext_fg5,
            _ext_bh2,
            _ext_ddd,
            _ext_xdw,
            _ext_xbd,
            _ext_fzs,
            _ext_txd,
            _ext_ggb,
            _ext_ggt,
            _ext_gex,
            _ext_gre,
            _ext_gxt,
            _ext_g2w,
            _ext_g3w,
            _ext_gmx,
            _ext_kml,
            _ext_kmz,
            _ext_gqf,
            _ext_gqs,
            _ext_gac,
            _ext_ghf,
            _ext_gim,
            _ext_grv,
            _ext_gtm,
            _ext_tpl,
            _ext_vcg,
            _ext_hal,
            _ext_zmm,
            _ext_hbci,
            _ext_les,
            _ext_hpgl,
            _ext_hpid,
            _ext_hps,
            _ext_jlt,
            _ext_pcl,
            _ext_pclxl,
            _ext_sfd_hdstx,
            _ext_mpy,
            _ext_afp,
            _ext_listafp,
            _ext_list3820,
            _ext_irm,
            _ext_sc,
            _ext_icc,
            _ext_icm,
            _ext_igl,
            _ext_ivp,
            _ext_ivu,
            _ext_igm,
            _ext_xpw,
            _ext_xpx,
            _ext_i2g,
            _ext_qbo,
            _ext_qfx,
            _ext_rcprofile,
            _ext_irp,
            _ext_xpr,
            _ext_fcs,
            _ext_jam,
            _ext_rms,
            _ext_jisp,
            _ext_joda,
            _ext_ktz,
            _ext_ktr,
            _ext_karbon,
            _ext_chrt,
            _ext_kfo,
            _ext_flw,
            _ext_kon,
            _ext_kpr,
            _ext_kpt,
            _ext_ksp,
            _ext_kwd,
            _ext_kwt,
            _ext_htke,
            _ext_kia,
            _ext_kne,
            _ext_knp,
            _ext_skp,
            _ext_skd,
            _ext_skt,
            _ext_skm,
            _ext_sse,
            _ext_lasxml,
            _ext_lbd,
            _ext_lbe,
            _ext_123,
            _ext_apr,
            _ext_pre,
            _ext_nsf,
            _ext_org,
            _ext_scm,
            _ext_lwp,
            _ext_portpkg,
            _ext_mcd,
            _ext_mc1,
            _ext_cdkey,
            _ext_mwf,
            _ext_mfm,
            _ext_flo,
            _ext_igx,
            _ext_mif,
            _ext_daf,
            _ext_dis,
            _ext_mbk,
            _ext_mqy,
            _ext_msl,
            _ext_plc,
            _ext_txf,
            _ext_mpn,
            _ext_mpc,
            _ext_xul,
            _ext_cil,
            _ext_cab,
            _ext_xls,
            _ext_xlm,
            _ext_xla,
            _ext_xlc,
            _ext_xlt,
            _ext_xlw,
            _ext_xlam,
            _ext_xlsb,
            _ext_xlsm,
            _ext_xltm,
            _ext_eot,
            _ext_chm,
            _ext_ims,
            _ext_lrm,
            _ext_thmx,
            _ext_cat,
            _ext_stl,
            _ext_ppt,
            _ext_pps,
            _ext_pot,
            _ext_ppam,
            _ext_pptm,
            _ext_sldm,
            _ext_ppsm,
            _ext_potm,
            _ext_mpp,
            _ext_mpt,
            _ext_docm,
            _ext_dotm,
            _ext_wps,
            _ext_wks,
            _ext_wcm,
            _ext_wdb,
            _ext_wpl,
            _ext_xps,
            _ext_mseq,
            _ext_mus,
            _ext_msty,
            _ext_taglet,
            _ext_nlu,
            _ext_ntf,
            _ext_nitf,
            _ext_nnd,
            _ext_nns,
            _ext_nnw,
            _ext_ngdat,
            _ext_n_gage,
            _ext_rpst,
            _ext_rpss,
            _ext_edm,
            _ext_edx,
            _ext_ext,
            _ext_odc,
            _ext_otc,
            _ext_odb,
            _ext_odf,
            _ext_odft,
            _ext_odg,
            _ext_otg,
            _ext_odi,
            _ext_oti,
            _ext_odp,
            _ext_otp,
            _ext_ods,
            _ext_ots,
            _ext_odt,
            _ext_odm,
            _ext_ott,
            _ext_oth,
            _ext_xo,
            _ext_dd2,
            _ext_oxt,
            _ext_pptx,
            _ext_sldx,
            _ext_ppsx,
            _ext_potx,
            _ext_xlsx,
            _ext_xltx,
            _ext_docx,
            _ext_dotx,
            _ext_mgp,
            _ext_dp,
            _ext_esa,
            _ext_pdb,
            _ext_pqa,
            _ext_oprc,
            _ext_paw,
            _ext_str,
            _ext_ei6,
            _ext_efif,
            _ext_wg,
            _ext_plf,
            _ext_pbd,
            _ext_box,
            _ext_mgz,
            _ext_qps,
            _ext_ptid,
            _ext_qxd,
            _ext_qxt,
            _ext_qwd,
            _ext_qwt,
            _ext_qxl,
            _ext_qxb,
            _ext_bed,
            _ext_mxl,
            _ext_musicxml,
            _ext_cryptonote,
            _ext_cod,
            _ext_rm,
            _ext_rmvb,
            _ext_link66,
            _ext_st,
            _ext_see,
            _ext_sema,
            _ext_semd,
            _ext_semf,
            _ext_ifm,
            _ext_itp,
            _ext_iif,
            _ext_ipk,
            _ext_twd,
            _ext_twds,
            _ext_mmf,
            _ext_teacher,
            _ext_sdkm,
            _ext_sdkd,
            _ext_dxp,
            _ext_sfs,
            _ext_sdc,
            _ext_sda,
            _ext_sdd,
            _ext_smf,
            _ext_sdw,
            _ext_vor,
            _ext_sgl,
            _ext_smzip,
            _ext_sm,
            _ext_sxc,
            _ext_stc,
            _ext_sxd,
            _ext_std,
            _ext_sxi,
            _ext_sti,
            _ext_sxm,
            _ext_sxw,
            _ext_sxg,
            _ext_stw,
            _ext_sus,
            _ext_susp,
            _ext_svd,
            _ext_sis,
            _ext_sisx,
            _ext_xsm,
            _ext_bdm,
            _ext_xdm,
            _ext_tao,
            _ext_pcap,
            _ext_cap,
            _ext_dmp,
            _ext_tmo,
            _ext_tpt,
            _ext_mxs,
            _ext_tra,
            _ext_ufd,
            _ext_ufdl,
            _ext_utz,
            _ext_umj,
            _ext_unityweb,
            _ext_uoml,
            _ext_vcx,
            _ext_vsd,
            _ext_vst,
            _ext_vss,
            _ext_vsw,
            _ext_vis,
            _ext_vsf,
            _ext_wbxml,
            _ext_wmlc,
            _ext_wmlsc,
            _ext_wtb,
            _ext_nbp,
            _ext_wpd,
            _ext_wqd,
            _ext_stf,
            _ext_xar,
            _ext_xfdl,
            _ext_hvd,
            _ext_hvs,
            _ext_hvp,
            _ext_osf,
            _ext_osfpvg,
            _ext_saf,
            _ext_spf,
            _ext_cmp,
            _ext_zir,
            _ext_zirz,
            _ext_zaz,
            _ext_vxml,
            _ext_wgt,
            _ext_hlp,
            _ext_wsdl,
            _ext_wspolicy,
            _ext_7z,
            _ext_abw,
            _ext_ace,
            _ext_dmg,
            _ext_aab,
            _ext_x32,
            _ext_u32,
            _ext_vox,
            _ext_aam,
            _ext_aas,
            _ext_bcpio,
            _ext_torrent,
            _ext_blb,
            _ext_blorb,
            _ext_bz,
            _ext_bz2,
            _ext_boz,
            _ext_cbr,
            _ext_cba,
            _ext_cbt,
            _ext_cbz,
            _ext_cb7,
            _ext_vcd,
            _ext_cfs,
            _ext_chat,
            _ext_pgn,
            _ext_nsc,
            _ext_cpio,
            _ext_csh,
            _ext_deb,
            _ext_udeb,
            _ext_dgc,
            _ext_dir,
            _ext_dcr,
            _ext_dxr,
            _ext_cst,
            _ext_cct,
            _ext_cxt,
            _ext_w3d,
            _ext_fgd,
            _ext_swa,
            _ext_wad,
            _ext_ncx,
            _ext_dtb,
            _ext_res,
            _ext_dvi,
            _ext_evy,
            _ext_eva,
            _ext_bdf,
            _ext_gsf,
            _ext_psf,
            _ext_otf,
            _ext_pcf,
            _ext_snf,
            _ext_ttf,
            _ext_ttc,
            _ext_pfa,
            _ext_pfb,
            _ext_pfm,
            _ext_afm,
            _ext_arc,
            _ext_spl,
            _ext_gca,
            _ext_ulx,
            _ext_gnumeric,
            _ext_gramps,
            _ext_gtar,
            _ext_hdf,
            _ext_install,
            _ext_iso,
            _ext_jnlp,
            _ext_latex,
            _ext_lzh,
            _ext_lha,
            _ext_mie,
            _ext_prc,
            _ext_mobi,
            _ext_application,
            _ext_lnk,
            _ext_wmd,
            _ext_wmz,
            _ext_xbap,
            _ext_mdb,
            _ext_obd,
            _ext_crd,
            _ext_clp,
            _ext_exe,
            _ext_dll,
            _ext_com,
            _ext_bat,
            _ext_msi,
            _ext_mvb,
            _ext_m13,
            _ext_m14,
            _ext_wmf,
            _ext_emf,
            _ext_emz,
            _ext_mny,
            _ext_pub,
            _ext_scd,
            _ext_trm,
            _ext_wri,
            _ext_nc,
            _ext_cdf,
            _ext_nzb,
            _ext_p12,
            _ext_pfx,
            _ext_p7b,
            _ext_spc,
            _ext_p7r,
            _ext_rar,
            _ext_ris,
            _ext_sh,
            _ext_shar,
            _ext_swf,
            _ext_xap,
            _ext_sql,
            _ext_sit,
            _ext_sitx,
            _ext_srt,
            _ext_sv4cpio,
            _ext_sv4crc,
            _ext_t3,
            _ext_gam,
            _ext_tar,
            _ext_tcl,
            _ext_tex,
            _ext_tfm,
            _ext_texinfo,
            _ext_texi,
            _ext_obj,
            _ext_ustar,
            _ext_src,
            _ext_der,
            _ext_crt,
            _ext_fig,
            _ext_xlf,
            _ext_xpi,
            _ext_xz,
            _ext_z1,
            _ext_z2,
            _ext_z3,
            _ext_z4,
            _ext_z5,
            _ext_z6,
            _ext_z7,
            _ext_z8,
            _ext_xaml,
            _ext_xdf,
            _ext_xenc,
            _ext_xhtml,
            _ext_xht,
            _ext_xml,
            _ext_xsl,
            _ext_dtd,
            _ext_xop,
            _ext_xpl,
            _ext_xslt,
            _ext_xspf,
            _ext_mxml,
            _ext_xhvml,
            _ext_xvml,
            _ext_xvm,
            _ext_yang,
            _ext_yin,
            _ext_zip,
            _ext_adp,
            _ext_au,
            _ext_snd,
            _ext_mid,
            _ext_midi,
            _ext_kar,
            _ext_rmi,
            _ext_m4a,
            _ext_mp4a,
            _ext_mpga,
            _ext_mp2,
            _ext_mp2a,
            _ext_mp3,
            _ext_m2a,
            _ext_m3a,
            _ext_oga,
            _ext_ogg,
            _ext_spx,
            _ext_s3m,
            _ext_sil,
            _ext_uva,
            _ext_uvva,
            _ext_eol,
            _ext_dra,
            _ext_dts,
            _ext_dtshd,
            _ext_lvp,
            _ext_pya,
            _ext_ecelp4800,
            _ext_ecelp7470,
            _ext_ecelp9600,
            _ext_rip,
            _ext_weba,
            _ext_aac,
            _ext_aif,
            _ext_aiff,
            _ext_aifc,
            _ext_caf,
            _ext_flac,
            _ext_mka,
            _ext_m3u,
            _ext_wax,
            _ext_wma,
            _ext_ram,
            _ext_ra,
            _ext_rmp,
            _ext_wav,
            _ext_xm,
            _ext_cdx,
            _ext_cif,
            _ext_cmdf,
            _ext_cml,
            _ext_csml,
            _ext_xyz,
            _ext_bmp,
            _ext_cgm,
            _ext_g3,
            _ext_gif,
            _ext_ief,
            _ext_jpeg,
            _ext_jpg,
            _ext_jpe,
            _ext_ktx,
            _ext_png,
            _ext_btif,
            _ext_sgi,
            _ext_svg,
            _ext_svgz,
            _ext_tiff,
            _ext_tif,
            _ext_psd,
            _ext_uvi,
            _ext_uvvi,
            _ext_uvg,
            _ext_uvvg,
            _ext_djvu,
            _ext_djv,
            _ext_sub,
            _ext_dwg,
            _ext_dxf,
            _ext_fbs,
            _ext_fpx,
            _ext_fst,
            _ext_mmr,
            _ext_rlc,
            _ext_mdi,
            _ext_wdp,
            _ext_npx,
            _ext_wbmp,
            _ext_xif,
            _ext_webp,
            _ext_3ds,
            _ext_ras,
            _ext_cmx,
            _ext_fh,
            _ext_fhc,
            _ext_fh4,
            _ext_fh5,
            _ext_fh7,
            _ext_ico,
            _ext_sid,
            _ext_pcx,
            _ext_pic,
            _ext_pct,
            _ext_pnm,
            _ext_pbm,
            _ext_pgm,
            _ext_ppm,
            _ext_rgb,
            _ext_tga,
            _ext_xbm,
            _ext_xpm,
            _ext_xwd,
            _ext_eml,
            _ext_mime,
            _ext_igs,
            _ext_iges,
            _ext_msh,
            _ext_mesh,
            _ext_silo,
            _ext_dae,
            _ext_dwf,
            _ext_gdl,
            _ext_gtw,
            _ext_mts,
            _ext_vtu,
            _ext_wrl,
            _ext_vrml,
            _ext_x3db,
            _ext_x3dbz,
            _ext_x3dv,
            _ext_x3dvz,
            _ext_x3d,
            _ext_x3dz,
            _ext_appcache,
            _ext_ics,
            _ext_ifb,
            _ext_css,
            _ext_csv,
            _ext_html,
            _ext_htm,
            _ext_n3,
            _ext_txt,
            _ext_text,
            _ext_conf,
            _ext_def,
            _ext_list,
            _ext_log,
            _ext_in,
            _ext_dsc,
            _ext_rtx,
            _ext_sgml,
            _ext_sgm,
            _ext_tsv,
            _ext_t,
            _ext_tr,
            _ext_roff,
            _ext_man,
            _ext_me,
            _ext_ms,
            _ext_ttl,
            _ext_uri,
            _ext_uris,
            _ext_urls,
            _ext_vcard,
            _ext_curl,
            _ext_dcurl,
            _ext_mcurl,
            _ext_scurl,
            _ext_fly,
            _ext_flx,
            _ext_gv,
            _ext_3dml,
            _ext_spot,
            _ext_jad,
            _ext_wml,
            _ext_wmls,
            _ext_s,
            _ext_asm,
            _ext_c,
            _ext_cc,
            _ext_cxx,
            _ext_cpp,
            _ext_h,
            _ext_hh,
            _ext_dic,
            _ext_f,
            _ext_for,
            _ext_f77,
            _ext_f90,
            _ext_java,
            _ext_nfo,
            _ext_opml,
            _ext_p,
            _ext_pas,
            _ext_etx,
            _ext_sfv,
            _ext_uu,
            _ext_vcs,
            _ext_vcf,
            _ext_3gp,
            _ext_3g2,
            _ext_h261,
            _ext_h263,
            _ext_h264,
            _ext_jpgv,
            _ext_jpm,
            _ext_jpgm,
            _ext_mj2,
            _ext_mjp2,
            _ext_mp4,
            _ext_mp4v,
            _ext_mpg4,
            _ext_mpeg,
            _ext_mpg,
            _ext_mpe,
            _ext_m1v,
            _ext_m2v,
            _ext_ogv,
            _ext_qt,
            _ext_mov,
            _ext_uvh,
            _ext_uvvh,
            _ext_uvm,
            _ext_uvvm,
            _ext_uvp,
            _ext_uvvp,
            _ext_uvs,
            _ext_uvvs,
            _ext_uvv,
            _ext_uvvv,
            _ext_dvb,
            _ext_fvt,
            _ext_mxu,
            _ext_m4u,
            _ext_pyv,
            _ext_uvu,
            _ext_uvvu,
            _ext_viv,
            _ext_webm,
            _ext_f4v,
            _ext_fli,
            _ext_flv,
            _ext_m4v,
            _ext_mkv,
            _ext_mk3d,
            _ext_mks,
            _ext_mng,
            _ext_asf,
            _ext_asx,
            _ext_vob,
            _ext_wm,
            _ext_wmv,
            _ext_wmx,
            _ext_wvx,
            _ext_avi,
            _ext_movie,
            _ext_smv,
            _ext_ice,
            _ext_map,
            _ext_topojson,
            _ext_jsonld,
            _ext_geojson,
            _ext_webmanifest,
            _ext_webapp,
            _ext_f4a,
            _ext_f4b,
            _ext_opus,
            _ext_jxr,
            _ext_hdp,
            _ext_jng,
            _ext_3gpp,
            _ext_f4p,
            _ext_cur,
            _ext_woff2,
            _ext_ear,
            _ext_war,
            _ext_img,
            _ext_msm,
            _ext_msp,
            _ext_safariextz,
            _ext_bbaw,
            _ext_crx,
            _ext_cco,
            _ext_jardiff,
            _ext_run,
            _ext_oex,
            _ext_pl,
            _ext_pm,
            _ext_rpm,
            _ext_sea,
            _ext_tk,
            _ext_pem,
            _ext_shtml,
            _ext_md,
            _ext_mml,
            _ext_xloc,
            _ext_vtt,
            _ext_htc,
        });

        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        static internal string LookupType(string type)
        {
            switch (type)
            {

				case _ext_ez:
					return Ez;
				case _ext_aw:
					return Aw;
				case _ext_atom:
					return Atom;
				case _ext_atomcat:
					return Atomcat;
				case _ext_atomsvc:
					return Atomsvc;
				case _ext_ccxml:
					return Ccxml;
				case _ext_cdmia:
					return Cdmia;
				case _ext_cdmic:
					return Cdmic;
				case _ext_cdmid:
					return Cdmid;
				case _ext_cdmio:
					return Cdmio;
				case _ext_cdmiq:
					return Cdmiq;
				case _ext_cu:
					return Cu;
				case _ext_davmount:
					return Davmount;
				case _ext_dbk:
					return Dbk;
				case _ext_dssc:
					return Dssc;
				case _ext_xdssc:
					return Xdssc;
				case _ext_ecma:
					return Ecma;
				case _ext_emma:
					return Emma;
				case _ext_epub:
					return Epub;
				case _ext_exi:
					return Exi;
				case _ext_pfr:
					return Pfr;
				case _ext_woff:
					return Woff;
				case _ext_gml:
					return Gml;
				case _ext_gpx:
					return Gpx;
				case _ext_gxf:
					return Gxf;
				case _ext_stk:
					return Stk;
				case _ext_ink:
				case _ext_inkml:
					return Ink;
				case _ext_ipfix:
					return Ipfix;
				case _ext_jar:
				case _ext_ear:
				case _ext_war:
					return Jar;
				case _ext_ser:
					return Ser;
				case _ext_class:
					return Class;
				case _ext_js:
					return Js;
				case _ext_json:
				case _ext_map:
				case _ext_topojson:
					return Json;
				case _ext_jsonml:
					return Jsonml;
				case _ext_lostxml:
					return Lostxml;
				case _ext_hqx:
					return Hqx;
				case _ext_cpt:
					return Cpt;
				case _ext_mads:
					return Mads;
				case _ext_mrc:
					return Mrc;
				case _ext_mrcx:
					return Mrcx;
				case _ext_ma:
				case _ext_nb:
				case _ext_mb:
					return Ma;
				case _ext_mathml:
					return Mathml;
				case _ext_mbox:
					return Mbox;
				case _ext_mscml:
					return Mscml;
				case _ext_metalink:
					return Metalink;
				case _ext_meta4:
					return Meta4;
				case _ext_mets:
					return Mets;
				case _ext_mods:
					return Mods;
				case _ext_m21:
				case _ext_mp21:
					return M21;
				case _ext_mp4s:
					return Mp4s;
				case _ext_doc:
				case _ext_dot:
					return Doc;
				case _ext_mxf:
					return Mxf;
				case _ext_bin:
				case _ext_dms:
				case _ext_lrf:
				case _ext_mar:
				case _ext_so:
				case _ext_dist:
				case _ext_distz:
				case _ext_pkg:
				case _ext_bpk:
				case _ext_dump:
				case _ext_elc:
				case _ext_deploy:
				case _ext_img:
				case _ext_msm:
				case _ext_msp:
				case _ext_safariextz:
					return Bin;
				case _ext_oda:
					return Oda;
				case _ext_opf:
					return Opf;
				case _ext_ogx:
					return Ogx;
				case _ext_omdoc:
					return Omdoc;
				case _ext_onetoc:
				case _ext_onetoc2:
				case _ext_onetmp:
				case _ext_onepkg:
					return Onetoc;
				case _ext_oxps:
					return Oxps;
				case _ext_xer:
					return Xer;
				case _ext_pdf:
					return Pdf;
				case _ext_pgp:
					return Pgp;
				case _ext_asc:
				case _ext_sig:
					return Asc;
				case _ext_prf:
					return Prf;
				case _ext_p10:
					return P10;
				case _ext_p7m:
				case _ext_p7c:
					return P7m;
				case _ext_p7s:
					return P7s;
				case _ext_p8:
					return P8;
				case _ext_ac:
					return Ac;
				case _ext_cer:
					return Cer;
				case _ext_crl:
					return Crl;
				case _ext_pkipath:
					return Pkipath;
				case _ext_pki:
					return Pki;
				case _ext_pls:
					return Pls;
				case _ext_ai:
				case _ext_eps:
				case _ext_ps:
					return Ai;
				case _ext_cww:
					return Cww;
				case _ext_pskcxml:
					return Pskcxml;
				case _ext_rdf:
					return Rdf;
				case _ext_rif:
					return Rif;
				case _ext_rnc:
					return Rnc;
				case _ext_rl:
					return Rl;
				case _ext_rld:
					return Rld;
				case _ext_rs:
					return Rs;
				case _ext_gbr:
					return Gbr;
				case _ext_mft:
					return Mft;
				case _ext_roa:
					return Roa;
				case _ext_rsd:
					return Rsd;
				case _ext_rss:
					return Rss;
				case _ext_rtf:
					return Rtf;
				case _ext_sbml:
					return Sbml;
				case _ext_scq:
					return Scq;
				case _ext_scs:
					return Scs;
				case _ext_spq:
					return Spq;
				case _ext_spp:
					return Spp;
				case _ext_sdp:
					return Sdp;
				case _ext_setpay:
					return Setpay;
				case _ext_setreg:
					return Setreg;
				case _ext_shf:
					return Shf;
				case _ext_smi:
				case _ext_smil:
					return Smi;
				case _ext_rq:
					return Rq;
				case _ext_srx:
					return Srx;
				case _ext_gram:
					return Gram;
				case _ext_grxml:
					return Grxml;
				case _ext_sru:
					return Sru;
				case _ext_ssdl:
					return Ssdl;
				case _ext_ssml:
					return Ssml;
				case _ext_tei:
				case _ext_teicorpus:
					return Tei;
				case _ext_tfi:
					return Tfi;
				case _ext_tsd:
					return Tsd;
				case _ext_plb:
					return Plb;
				case _ext_psb:
					return Psb;
				case _ext_pvb:
					return Pvb;
				case _ext_tcap:
					return Tcap;
				case _ext_pwn:
					return Pwn;
				case _ext_aso:
					return Aso;
				case _ext_imp:
					return Imp;
				case _ext_acu:
					return Acu;
				case _ext_atc:
				case _ext_acutc:
					return Atc;
				case _ext_air:
					return Air;
				case _ext_fcdt:
					return Fcdt;
				case _ext_fxp:
				case _ext_fxpl:
					return Fxp;
				case _ext_xdp:
					return Xdp;
				case _ext_xfdf:
					return Xfdf;
				case _ext_ahead:
					return Ahead;
				case _ext_azf:
					return Azf;
				case _ext_azs:
					return Azs;
				case _ext_azw:
					return Azw;
				case _ext_acc:
					return Acc;
				case _ext_ami:
					return Ami;
				case _ext_apk:
					return Apk;
				case _ext_cii:
					return Cii;
				case _ext_fti:
					return Fti;
				case _ext_atx:
					return Atx;
				case _ext_mpkg:
					return Mpkg;
				case _ext_m3u8:
					return M3u8;
				case _ext_swi:
					return Swi;
				case _ext_iota:
					return Iota;
				case _ext_aep:
					return Aep;
				case _ext_mpm:
					return Mpm;
				case _ext_bmi:
					return Bmi;
				case _ext_rep:
					return Rep;
				case _ext_cdxml:
					return Cdxml;
				case _ext_mmd:
					return Mmd;
				case _ext_cdy:
					return Cdy;
				case _ext_cla:
					return Cla;
				case _ext_rp9:
					return Rp9;
				case _ext_c4g:
				case _ext_c4d:
				case _ext_c4f:
				case _ext_c4p:
				case _ext_c4u:
					return C4g;
				case _ext_c11amc:
					return C11amc;
				case _ext_c11amz:
					return C11amz;
				case _ext_csp:
					return Csp;
				case _ext_cdbcmsg:
					return Cdbcmsg;
				case _ext_cmc:
					return Cmc;
				case _ext_clkx:
					return Clkx;
				case _ext_clkk:
					return Clkk;
				case _ext_clkp:
					return Clkp;
				case _ext_clkt:
					return Clkt;
				case _ext_clkw:
					return Clkw;
				case _ext_wbs:
					return Wbs;
				case _ext_pml:
					return Pml;
				case _ext_ppd:
					return Ppd;
				case _ext_car:
					return Car;
				case _ext_pcurl:
					return Pcurl;
				case _ext_dart:
					return Dart;
				case _ext_rdz:
					return Rdz;
				case _ext_uvf:
				case _ext_uvvf:
				case _ext_uvd:
				case _ext_uvvd:
					return Uvf;
				case _ext_uvt:
				case _ext_uvvt:
					return Uvt;
				case _ext_uvx:
				case _ext_uvvx:
					return Uvx;
				case _ext_uvz:
				case _ext_uvvz:
					return Uvz;
				case _ext_fe_launch:
					return Felaunch;
				case _ext_dna:
					return Dna;
				case _ext_mlp:
					return Mlp;
				case _ext_dpg:
					return Dpg;
				case _ext_dfac:
					return Dfac;
				case _ext_kpxx:
					return Kpxx;
				case _ext_ait:
					return Ait;
				case _ext_svc:
					return Svc;
				case _ext_geo:
					return Geo;
				case _ext_mag:
					return Mag;
				case _ext_nml:
					return Nml;
				case _ext_esf:
					return Esf;
				case _ext_msf:
					return Msf;
				case _ext_qam:
					return Qam;
				case _ext_slt:
					return Slt;
				case _ext_ssf:
					return Ssf;
				case _ext_es3:
				case _ext_et3:
					return Es3;
				case _ext_ez2:
					return Ez2;
				case _ext_ez3:
					return Ez3;
				case _ext_fdf:
					return Fdf;
				case _ext_mseed:
					return Mseed;
				case _ext_seed:
				case _ext_dataless:
					return Seed;
				case _ext_gph:
					return Gph;
				case _ext_ftc:
					return Ftc;
				case _ext_fm:
				case _ext_frame:
				case _ext_maker:
				case _ext_book:
					return Fm;
				case _ext_fnc:
					return Fnc;
				case _ext_ltf:
					return Ltf;
				case _ext_fsc:
					return Fsc;
				case _ext_oas:
					return Oas;
				case _ext_oa2:
					return Oa2;
				case _ext_oa3:
					return Oa3;
				case _ext_fg5:
					return Fg5;
				case _ext_bh2:
					return Bh2;
				case _ext_ddd:
					return Ddd;
				case _ext_xdw:
					return Xdw;
				case _ext_xbd:
					return Xbd;
				case _ext_fzs:
					return Fzs;
				case _ext_txd:
					return Txd;
				case _ext_ggb:
					return Ggb;
				case _ext_ggt:
					return Ggt;
				case _ext_gex:
				case _ext_gre:
					return Gex;
				case _ext_gxt:
					return Gxt;
				case _ext_g2w:
					return G2w;
				case _ext_g3w:
					return G3w;
				case _ext_gmx:
					return Gmx;
				case _ext_kml:
					return Kml;
				case _ext_kmz:
					return Kmz;
				case _ext_gqf:
				case _ext_gqs:
					return Gqf;
				case _ext_gac:
					return Gac;
				case _ext_ghf:
					return Ghf;
				case _ext_gim:
					return Gim;
				case _ext_grv:
					return Grv;
				case _ext_gtm:
					return Gtm;
				case _ext_tpl:
					return Tpl;
				case _ext_vcg:
					return Vcg;
				case _ext_hal:
					return Hal;
				case _ext_zmm:
					return Zmm;
				case _ext_hbci:
					return Hbci;
				case _ext_les:
					return Les;
				case _ext_hpgl:
					return Hpgl;
				case _ext_hpid:
					return Hpid;
				case _ext_hps:
					return Hps;
				case _ext_jlt:
					return Jlt;
				case _ext_pcl:
					return Pcl;
				case _ext_pclxl:
					return Pclxl;
				case _ext_sfd_hdstx:
					return Sfdhdstx;
				case _ext_mpy:
					return Mpy;
				case _ext_afp:
				case _ext_listafp:
				case _ext_list3820:
					return Afp;
				case _ext_irm:
					return Irm;
				case _ext_sc:
					return Sc;
				case _ext_icc:
				case _ext_icm:
					return Icc;
				case _ext_igl:
					return Igl;
				case _ext_ivp:
					return Ivp;
				case _ext_ivu:
					return Ivu;
				case _ext_igm:
					return Igm;
				case _ext_xpw:
				case _ext_xpx:
					return Xpw;
				case _ext_i2g:
					return I2g;
				case _ext_qbo:
					return Qbo;
				case _ext_qfx:
					return Qfx;
				case _ext_rcprofile:
					return Rcprofile;
				case _ext_irp:
					return Irp;
				case _ext_xpr:
					return Xpr;
				case _ext_fcs:
					return Fcs;
				case _ext_jam:
					return Jam;
				case _ext_rms:
					return Rms;
				case _ext_jisp:
					return Jisp;
				case _ext_joda:
					return Joda;
				case _ext_ktz:
				case _ext_ktr:
					return Ktz;
				case _ext_karbon:
					return Karbon;
				case _ext_chrt:
					return Chrt;
				case _ext_kfo:
					return Kfo;
				case _ext_flw:
					return Flw;
				case _ext_kon:
					return Kon;
				case _ext_kpr:
				case _ext_kpt:
					return Kpr;
				case _ext_ksp:
					return Ksp;
				case _ext_kwd:
				case _ext_kwt:
					return Kwd;
				case _ext_htke:
					return Htke;
				case _ext_kia:
					return Kia;
				case _ext_kne:
				case _ext_knp:
					return Kne;
				case _ext_skp:
				case _ext_skd:
				case _ext_skt:
				case _ext_skm:
					return Skp;
				case _ext_sse:
					return Sse;
				case _ext_lasxml:
					return Lasxml;
				case _ext_lbd:
					return Lbd;
				case _ext_lbe:
					return Lbe;
				case _ext_123:
					return _123;
				case _ext_apr:
					return Apr;
				case _ext_pre:
					return Pre;
				case _ext_nsf:
					return Nsf;
				case _ext_org:
					return Org;
				case _ext_scm:
					return Scm;
				case _ext_lwp:
					return Lwp;
				case _ext_portpkg:
					return Portpkg;
				case _ext_mcd:
					return Mcd;
				case _ext_mc1:
					return Mc1;
				case _ext_cdkey:
					return Cdkey;
				case _ext_mwf:
					return Mwf;
				case _ext_mfm:
					return Mfm;
				case _ext_flo:
					return Flo;
				case _ext_igx:
					return Igx;
				case _ext_mif:
					return Mif;
				case _ext_daf:
					return Daf;
				case _ext_dis:
					return Dis;
				case _ext_mbk:
					return Mbk;
				case _ext_mqy:
					return Mqy;
				case _ext_msl:
					return Msl;
				case _ext_plc:
					return Plc;
				case _ext_txf:
					return Txf;
				case _ext_mpn:
					return Mpn;
				case _ext_mpc:
					return Mpc;
				case _ext_xul:
					return Xul;
				case _ext_cil:
					return Cil;
				case _ext_cab:
					return Cab;
				case _ext_xls:
				case _ext_xlm:
				case _ext_xla:
				case _ext_xlc:
				case _ext_xlt:
				case _ext_xlw:
					return Xls;
				case _ext_xlam:
					return Xlam;
				case _ext_xlsb:
					return Xlsb;
				case _ext_xlsm:
					return Xlsm;
				case _ext_xltm:
					return Xltm;
				case _ext_eot:
					return Eot;
				case _ext_chm:
					return Chm;
				case _ext_ims:
					return Ims;
				case _ext_lrm:
					return Lrm;
				case _ext_thmx:
					return Thmx;
				case _ext_cat:
					return Cat;
				case _ext_stl:
					return Stl;
				case _ext_ppt:
				case _ext_pps:
				case _ext_pot:
					return Ppt;
				case _ext_ppam:
					return Ppam;
				case _ext_pptm:
					return Pptm;
				case _ext_sldm:
					return Sldm;
				case _ext_ppsm:
					return Ppsm;
				case _ext_potm:
					return Potm;
				case _ext_mpp:
				case _ext_mpt:
					return Mpp;
				case _ext_docm:
					return Docm;
				case _ext_dotm:
					return Dotm;
				case _ext_wps:
				case _ext_wks:
				case _ext_wcm:
				case _ext_wdb:
					return Wps;
				case _ext_wpl:
					return Wpl;
				case _ext_xps:
					return Xps;
				case _ext_mseq:
					return Mseq;
				case _ext_mus:
					return Mus;
				case _ext_msty:
					return Msty;
				case _ext_taglet:
					return Taglet;
				case _ext_nlu:
					return Nlu;
				case _ext_ntf:
				case _ext_nitf:
					return Ntf;
				case _ext_nnd:
					return Nnd;
				case _ext_nns:
					return Nns;
				case _ext_nnw:
					return Nnw;
				case _ext_ngdat:
					return Ngdat;
				case _ext_n_gage:
					return Ngage;
				case _ext_rpst:
					return Rpst;
				case _ext_rpss:
					return Rpss;
				case _ext_edm:
					return Edm;
				case _ext_edx:
					return Edx;
				case _ext_ext:
					return Ext;
				case _ext_odc:
					return Odc;
				case _ext_otc:
					return Otc;
				case _ext_odb:
					return Odb;
				case _ext_odf:
					return Odf;
				case _ext_odft:
					return Odft;
				case _ext_odg:
					return Odg;
				case _ext_otg:
					return Otg;
				case _ext_odi:
					return Odi;
				case _ext_oti:
					return Oti;
				case _ext_odp:
					return Odp;
				case _ext_otp:
					return Otp;
				case _ext_ods:
					return Ods;
				case _ext_ots:
					return Ots;
				case _ext_odt:
					return Odt;
				case _ext_odm:
					return Odm;
				case _ext_ott:
					return Ott;
				case _ext_oth:
					return Oth;
				case _ext_xo:
					return Xo;
				case _ext_dd2:
					return Dd2;
				case _ext_oxt:
					return Oxt;
				case _ext_pptx:
					return Pptx;
				case _ext_sldx:
					return Sldx;
				case _ext_ppsx:
					return Ppsx;
				case _ext_potx:
					return Potx;
				case _ext_xlsx:
					return Xlsx;
				case _ext_xltx:
					return Xltx;
				case _ext_docx:
					return Docx;
				case _ext_dotx:
					return Dotx;
				case _ext_mgp:
					return Mgp;
				case _ext_dp:
					return Dp;
				case _ext_esa:
					return Esa;
				case _ext_pdb:
				case _ext_pqa:
				case _ext_oprc:
					return Pdb;
				case _ext_paw:
					return Paw;
				case _ext_str:
					return Str;
				case _ext_ei6:
					return Ei6;
				case _ext_efif:
					return Efif;
				case _ext_wg:
					return Wg;
				case _ext_plf:
					return Plf;
				case _ext_pbd:
					return Pbd;
				case _ext_box:
					return Box;
				case _ext_mgz:
					return Mgz;
				case _ext_qps:
					return Qps;
				case _ext_ptid:
					return Ptid;
				case _ext_qxd:
				case _ext_qxt:
				case _ext_qwd:
				case _ext_qwt:
				case _ext_qxl:
				case _ext_qxb:
					return Qxd;
				case _ext_bed:
					return Bed;
				case _ext_mxl:
					return Mxl;
				case _ext_musicxml:
					return Musicxml;
				case _ext_cryptonote:
					return Cryptonote;
				case _ext_cod:
					return Cod;
				case _ext_rm:
					return Rm;
				case _ext_rmvb:
					return Rmvb;
				case _ext_link66:
					return Link66;
				case _ext_st:
					return St;
				case _ext_see:
					return See;
				case _ext_sema:
					return Sema;
				case _ext_semd:
					return Semd;
				case _ext_semf:
					return Semf;
				case _ext_ifm:
					return Ifm;
				case _ext_itp:
					return Itp;
				case _ext_iif:
					return Iif;
				case _ext_ipk:
					return Ipk;
				case _ext_twd:
				case _ext_twds:
					return Twd;
				case _ext_mmf:
					return Mmf;
				case _ext_teacher:
					return Teacher;
				case _ext_sdkm:
				case _ext_sdkd:
					return Sdkm;
				case _ext_dxp:
					return Dxp;
				case _ext_sfs:
					return Sfs;
				case _ext_sdc:
					return Sdc;
				case _ext_sda:
					return Sda;
				case _ext_sdd:
					return Sdd;
				case _ext_smf:
					return Smf;
				case _ext_sdw:
				case _ext_vor:
					return Sdw;
				case _ext_sgl:
					return Sgl;
				case _ext_smzip:
					return Smzip;
				case _ext_sm:
					return Sm;
				case _ext_sxc:
					return Sxc;
				case _ext_stc:
					return Stc;
				case _ext_sxd:
					return Sxd;
				case _ext_std:
					return Std;
				case _ext_sxi:
					return Sxi;
				case _ext_sti:
					return Sti;
				case _ext_sxm:
					return Sxm;
				case _ext_sxw:
					return Sxw;
				case _ext_sxg:
					return Sxg;
				case _ext_stw:
					return Stw;
				case _ext_sus:
				case _ext_susp:
					return Sus;
				case _ext_svd:
					return Svd;
				case _ext_sis:
				case _ext_sisx:
					return Sis;
				case _ext_xsm:
					return Xsm;
				case _ext_bdm:
					return Bdm;
				case _ext_xdm:
					return Xdm;
				case _ext_tao:
					return Tao;
				case _ext_pcap:
				case _ext_cap:
				case _ext_dmp:
					return Pcap;
				case _ext_tmo:
					return Tmo;
				case _ext_tpt:
					return Tpt;
				case _ext_mxs:
					return Mxs;
				case _ext_tra:
					return Tra;
				case _ext_ufd:
				case _ext_ufdl:
					return Ufd;
				case _ext_utz:
					return Utz;
				case _ext_umj:
					return Umj;
				case _ext_unityweb:
					return Unityweb;
				case _ext_uoml:
					return Uoml;
				case _ext_vcx:
					return Vcx;
				case _ext_vsd:
				case _ext_vst:
				case _ext_vss:
				case _ext_vsw:
					return Vsd;
				case _ext_vis:
					return Vis;
				case _ext_vsf:
					return Vsf;
				case _ext_wbxml:
					return Wbxml;
				case _ext_wmlc:
					return Wmlc;
				case _ext_wmlsc:
					return Wmlsc;
				case _ext_wtb:
					return Wtb;
				case _ext_nbp:
					return Nbp;
				case _ext_wpd:
					return Wpd;
				case _ext_wqd:
					return Wqd;
				case _ext_stf:
					return Stf;
				case _ext_xar:
					return Xar;
				case _ext_xfdl:
					return Xfdl;
				case _ext_hvd:
					return Hvd;
				case _ext_hvs:
					return Hvs;
				case _ext_hvp:
					return Hvp;
				case _ext_osf:
					return Osf;
				case _ext_osfpvg:
					return Osfpvg;
				case _ext_saf:
					return Saf;
				case _ext_spf:
					return Spf;
				case _ext_cmp:
					return Cmp;
				case _ext_zir:
				case _ext_zirz:
					return Zir;
				case _ext_zaz:
					return Zaz;
				case _ext_vxml:
					return Vxml;
				case _ext_wgt:
					return Wgt;
				case _ext_hlp:
					return Hlp;
				case _ext_wsdl:
					return Wsdl;
				case _ext_wspolicy:
					return Wspolicy;
				case _ext_7z:
					return _7z;
				case _ext_abw:
					return Abw;
				case _ext_ace:
					return Ace;
				case _ext_dmg:
					return Dmg;
				case _ext_aab:
				case _ext_x32:
				case _ext_u32:
				case _ext_vox:
					return Aab;
				case _ext_aam:
					return Aam;
				case _ext_aas:
					return Aas;
				case _ext_bcpio:
					return Bcpio;
				case _ext_torrent:
					return Torrent;
				case _ext_blb:
				case _ext_blorb:
					return Blb;
				case _ext_bz:
					return Bz;
				case _ext_bz2:
				case _ext_boz:
					return Bz2;
				case _ext_cbr:
				case _ext_cba:
				case _ext_cbt:
				case _ext_cbz:
				case _ext_cb7:
					return Cbr;
				case _ext_vcd:
					return Vcd;
				case _ext_cfs:
					return Cfs;
				case _ext_chat:
					return Chat;
				case _ext_pgn:
					return Pgn;
				case _ext_nsc:
					return Nsc;
				case _ext_cpio:
					return Cpio;
				case _ext_csh:
					return Csh;
				case _ext_deb:
				case _ext_udeb:
					return Deb;
				case _ext_dgc:
					return Dgc;
				case _ext_dir:
				case _ext_dcr:
				case _ext_dxr:
				case _ext_cst:
				case _ext_cct:
				case _ext_cxt:
				case _ext_w3d:
				case _ext_fgd:
				case _ext_swa:
					return Dir;
				case _ext_wad:
					return Wad;
				case _ext_ncx:
					return Ncx;
				case _ext_dtb:
					return Dtb;
				case _ext_res:
					return Res;
				case _ext_dvi:
					return Dvi;
				case _ext_evy:
					return Evy;
				case _ext_eva:
					return Eva;
				case _ext_bdf:
					return Bdf;
				case _ext_gsf:
					return Gsf;
				case _ext_psf:
					return Psf;
				case _ext_otf:
					return Otf;
				case _ext_pcf:
					return Pcf;
				case _ext_snf:
					return Snf;
				case _ext_ttf:
				case _ext_ttc:
					return Ttf;
				case _ext_pfa:
				case _ext_pfb:
				case _ext_pfm:
				case _ext_afm:
					return Pfa;
				case _ext_arc:
					return Arc;
				case _ext_spl:
					return Spl;
				case _ext_gca:
					return Gca;
				case _ext_ulx:
					return Ulx;
				case _ext_gnumeric:
					return Gnumeric;
				case _ext_gramps:
					return Gramps;
				case _ext_gtar:
					return Gtar;
				case _ext_hdf:
					return Hdf;
				case _ext_install:
					return Install;
				case _ext_iso:
					return Iso;
				case _ext_jnlp:
					return Jnlp;
				case _ext_latex:
					return Latex;
				case _ext_lzh:
				case _ext_lha:
					return Lzh;
				case _ext_mie:
					return Mie;
				case _ext_prc:
				case _ext_mobi:
					return Prc;
				case _ext_application:
					return Application;
				case _ext_lnk:
					return Lnk;
				case _ext_wmd:
					return Wmd;
				case _ext_wmz:
					return Wmz;
				case _ext_xbap:
					return Xbap;
				case _ext_mdb:
					return Mdb;
				case _ext_obd:
					return Obd;
				case _ext_crd:
					return Crd;
				case _ext_clp:
					return Clp;
				case _ext_exe:
				case _ext_dll:
				case _ext_com:
				case _ext_bat:
				case _ext_msi:
					return Exe;
				case _ext_mvb:
				case _ext_m13:
				case _ext_m14:
					return Mvb;
				case _ext_wmf:
				case _ext_emf:
				case _ext_emz:
					return Wmf;
				case _ext_mny:
					return Mny;
				case _ext_pub:
					return Pub;
				case _ext_scd:
					return Scd;
				case _ext_trm:
					return Trm;
				case _ext_wri:
					return Wri;
				case _ext_nc:
				case _ext_cdf:
					return Nc;
				case _ext_nzb:
					return Nzb;
				case _ext_p12:
				case _ext_pfx:
					return P12;
				case _ext_p7b:
				case _ext_spc:
					return P7b;
				case _ext_p7r:
					return P7r;
				case _ext_rar:
					return Rar;
				case _ext_ris:
					return Ris;
				case _ext_sh:
					return Sh;
				case _ext_shar:
					return Shar;
				case _ext_swf:
					return Swf;
				case _ext_xap:
					return Xap;
				case _ext_sql:
					return Sql;
				case _ext_sit:
					return Sit;
				case _ext_sitx:
					return Sitx;
				case _ext_srt:
					return Srt;
				case _ext_sv4cpio:
					return Sv4cpio;
				case _ext_sv4crc:
					return Sv4crc;
				case _ext_t3:
					return T3;
				case _ext_gam:
					return Gam;
				case _ext_tar:
					return Tar;
				case _ext_tcl:
				case _ext_tk:
					return Tcl;
				case _ext_tex:
					return Tex;
				case _ext_tfm:
					return Tfm;
				case _ext_texinfo:
				case _ext_texi:
					return Texinfo;
				case _ext_obj:
					return Obj;
				case _ext_ustar:
					return Ustar;
				case _ext_src:
					return Src;
				case _ext_der:
				case _ext_crt:
				case _ext_pem:
					return Der;
				case _ext_fig:
					return Fig;
				case _ext_xlf:
					return Xlf;
				case _ext_xpi:
					return Xpi;
				case _ext_xz:
					return Xz;
				case _ext_z1:
				case _ext_z2:
				case _ext_z3:
				case _ext_z4:
				case _ext_z5:
				case _ext_z6:
				case _ext_z7:
				case _ext_z8:
					return Z1;
				case _ext_xaml:
					return Xaml;
				case _ext_xdf:
					return Xdf;
				case _ext_xenc:
					return Xenc;
				case _ext_xhtml:
				case _ext_xht:
					return Xhtml;
				case _ext_xml:
				case _ext_xsl:
					return Xml;
				case _ext_dtd:
					return Dtd;
				case _ext_xop:
					return Xop;
				case _ext_xpl:
					return Xpl;
				case _ext_xslt:
					return Xslt;
				case _ext_xspf:
					return Xspf;
				case _ext_mxml:
				case _ext_xhvml:
				case _ext_xvml:
				case _ext_xvm:
					return Mxml;
				case _ext_yang:
					return Yang;
				case _ext_yin:
					return Yin;
				case _ext_zip:
					return Zip;
				case _ext_adp:
					return Adp;
				case _ext_au:
				case _ext_snd:
					return Au;
				case _ext_mid:
				case _ext_midi:
				case _ext_kar:
				case _ext_rmi:
					return Mid;
				case _ext_m4a:
				case _ext_mp4a:
				case _ext_f4a:
				case _ext_f4b:
					return M4a;
				case _ext_mpga:
				case _ext_mp2:
				case _ext_mp2a:
				case _ext_mp3:
				case _ext_m2a:
				case _ext_m3a:
					return Mpga;
				case _ext_oga:
				case _ext_ogg:
				case _ext_spx:
				case _ext_opus:
					return Oga;
				case _ext_s3m:
					return S3m;
				case _ext_sil:
					return Sil;
				case _ext_uva:
				case _ext_uvva:
					return Uva;
				case _ext_eol:
					return Eol;
				case _ext_dra:
					return Dra;
				case _ext_dts:
					return Dts;
				case _ext_dtshd:
					return Dtshd;
				case _ext_lvp:
					return Lvp;
				case _ext_pya:
					return Pya;
				case _ext_ecelp4800:
					return Ecelp4800;
				case _ext_ecelp7470:
					return Ecelp7470;
				case _ext_ecelp9600:
					return Ecelp9600;
				case _ext_rip:
					return Rip;
				case _ext_weba:
					return Weba;
				case _ext_aac:
					return Aac;
				case _ext_aif:
				case _ext_aiff:
				case _ext_aifc:
					return Aif;
				case _ext_caf:
					return Caf;
				case _ext_flac:
					return Flac;
				case _ext_mka:
					return Mka;
				case _ext_m3u:
					return M3u;
				case _ext_wax:
					return Wax;
				case _ext_wma:
					return Wma;
				case _ext_ram:
				case _ext_ra:
					return Ram;
				case _ext_rmp:
					return Rmp;
				case _ext_wav:
					return Wav;
				case _ext_xm:
					return Xm;
				case _ext_cdx:
					return Cdx;
				case _ext_cif:
					return Cif;
				case _ext_cmdf:
					return Cmdf;
				case _ext_cml:
					return Cml;
				case _ext_csml:
					return Csml;
				case _ext_xyz:
					return Xyz;
				case _ext_bmp:
					return Bmp;
				case _ext_cgm:
					return Cgm;
				case _ext_g3:
					return G3;
				case _ext_gif:
					return Gif;
				case _ext_ief:
					return Ief;
				case _ext_jpeg:
				case _ext_jpg:
				case _ext_jpe:
					return Jpeg;
				case _ext_ktx:
					return Ktx;
				case _ext_png:
					return Png;
				case _ext_btif:
					return Btif;
				case _ext_sgi:
					return Sgi;
				case _ext_svg:
				case _ext_svgz:
					return Svg;
				case _ext_tiff:
				case _ext_tif:
					return Tiff;
				case _ext_psd:
					return Psd;
				case _ext_uvi:
				case _ext_uvvi:
				case _ext_uvg:
				case _ext_uvvg:
					return Uvi;
				case _ext_djvu:
				case _ext_djv:
					return Djvu;
				case _ext_sub:
					return Sub;
				case _ext_dwg:
					return Dwg;
				case _ext_dxf:
					return Dxf;
				case _ext_fbs:
					return Fbs;
				case _ext_fpx:
					return Fpx;
				case _ext_fst:
					return Fst;
				case _ext_mmr:
					return Mmr;
				case _ext_rlc:
					return Rlc;
				case _ext_mdi:
					return Mdi;
				case _ext_wdp:
					return Wdp;
				case _ext_npx:
					return Npx;
				case _ext_wbmp:
					return Wbmp;
				case _ext_xif:
					return Xif;
				case _ext_webp:
					return Webp;
				case _ext_3ds:
					return _3ds;
				case _ext_ras:
					return Ras;
				case _ext_cmx:
					return Cmx;
				case _ext_fh:
				case _ext_fhc:
				case _ext_fh4:
				case _ext_fh5:
				case _ext_fh7:
					return Fh;
				case _ext_ico:
				case _ext_cur:
					return Ico;
				case _ext_sid:
					return Sid;
				case _ext_pcx:
					return Pcx;
				case _ext_pic:
				case _ext_pct:
					return Pic;
				case _ext_pnm:
					return Pnm;
				case _ext_pbm:
					return Pbm;
				case _ext_pgm:
					return Pgm;
				case _ext_ppm:
					return Ppm;
				case _ext_rgb:
					return Rgb;
				case _ext_tga:
					return Tga;
				case _ext_xbm:
					return Xbm;
				case _ext_xpm:
					return Xpm;
				case _ext_xwd:
					return Xwd;
				case _ext_eml:
				case _ext_mime:
					return Eml;
				case _ext_igs:
				case _ext_iges:
					return Igs;
				case _ext_msh:
				case _ext_mesh:
				case _ext_silo:
					return Msh;
				case _ext_dae:
					return Dae;
				case _ext_dwf:
					return Dwf;
				case _ext_gdl:
					return Gdl;
				case _ext_gtw:
					return Gtw;
				case _ext_mts:
					return Mts;
				case _ext_vtu:
					return Vtu;
				case _ext_wrl:
				case _ext_vrml:
					return Wrl;
				case _ext_x3db:
				case _ext_x3dbz:
					return X3db;
				case _ext_x3dv:
				case _ext_x3dvz:
					return X3dv;
				case _ext_x3d:
				case _ext_x3dz:
					return X3d;
				case _ext_appcache:
					return Appcache;
				case _ext_ics:
				case _ext_ifb:
					return Ics;
				case _ext_css:
					return Css;
				case _ext_csv:
					return Csv;
				case _ext_html:
				case _ext_htm:
				case _ext_shtml:
					return Html;
				case _ext_n3:
					return N3;
				case _ext_txt:
				case _ext_text:
				case _ext_conf:
				case _ext_def:
				case _ext_list:
				case _ext_log:
				case _ext_in:
					return Txt;
				case _ext_dsc:
					return Dsc;
				case _ext_rtx:
					return Rtx;
				case _ext_sgml:
				case _ext_sgm:
					return Sgml;
				case _ext_tsv:
					return Tsv;
				case _ext_t:
				case _ext_tr:
				case _ext_roff:
				case _ext_man:
				case _ext_me:
				case _ext_ms:
					return T;
				case _ext_ttl:
					return Ttl;
				case _ext_uri:
				case _ext_uris:
				case _ext_urls:
					return Uri;
				case _ext_vcard:
					return Vcard;
				case _ext_curl:
					return Curl;
				case _ext_dcurl:
					return Dcurl;
				case _ext_mcurl:
					return Mcurl;
				case _ext_scurl:
					return Scurl;
				case _ext_fly:
					return Fly;
				case _ext_flx:
					return Flx;
				case _ext_gv:
					return Gv;
				case _ext_3dml:
					return _3dml;
				case _ext_spot:
					return Spot;
				case _ext_jad:
					return Jad;
				case _ext_wml:
					return Wml;
				case _ext_wmls:
					return Wmls;
				case _ext_s:
				case _ext_asm:
					return S;
				case _ext_c:
				case _ext_cc:
				case _ext_cxx:
				case _ext_cpp:
				case _ext_h:
				case _ext_hh:
				case _ext_dic:
					return C;
				case _ext_f:
				case _ext_for:
				case _ext_f77:
				case _ext_f90:
					return F;
				case _ext_java:
					return Java;
				case _ext_nfo:
					return Nfo;
				case _ext_opml:
					return Opml;
				case _ext_p:
				case _ext_pas:
					return P;
				case _ext_etx:
					return Etx;
				case _ext_sfv:
					return Sfv;
				case _ext_uu:
					return Uu;
				case _ext_vcs:
					return Vcs;
				case _ext_vcf:
					return Vcf;
				case _ext_3gp:
				case _ext_3gpp:
					return _3gp;
				case _ext_3g2:
					return _3g2;
				case _ext_h261:
					return H261;
				case _ext_h263:
					return H263;
				case _ext_h264:
					return H264;
				case _ext_jpgv:
					return Jpgv;
				case _ext_jpm:
				case _ext_jpgm:
					return Jpm;
				case _ext_mj2:
				case _ext_mjp2:
					return Mj2;
				case _ext_mp4:
				case _ext_mp4v:
				case _ext_mpg4:
				case _ext_f4p:
					return Mp4;
				case _ext_mpeg:
				case _ext_mpg:
				case _ext_mpe:
				case _ext_m1v:
				case _ext_m2v:
					return Mpeg;
				case _ext_ogv:
					return Ogv;
				case _ext_qt:
				case _ext_mov:
					return Qt;
				case _ext_uvh:
				case _ext_uvvh:
					return Uvh;
				case _ext_uvm:
				case _ext_uvvm:
					return Uvm;
				case _ext_uvp:
				case _ext_uvvp:
					return Uvp;
				case _ext_uvs:
				case _ext_uvvs:
					return Uvs;
				case _ext_uvv:
				case _ext_uvvv:
					return Uvv;
				case _ext_dvb:
					return Dvb;
				case _ext_fvt:
					return Fvt;
				case _ext_mxu:
				case _ext_m4u:
					return Mxu;
				case _ext_pyv:
					return Pyv;
				case _ext_uvu:
				case _ext_uvvu:
					return Uvu;
				case _ext_viv:
					return Viv;
				case _ext_webm:
					return Webm;
				case _ext_f4v:
					return F4v;
				case _ext_fli:
					return Fli;
				case _ext_flv:
					return Flv;
				case _ext_m4v:
					return M4v;
				case _ext_mkv:
				case _ext_mk3d:
				case _ext_mks:
					return Mkv;
				case _ext_mng:
					return Mng;
				case _ext_asf:
				case _ext_asx:
					return Asf;
				case _ext_vob:
					return Vob;
				case _ext_wm:
					return Wm;
				case _ext_wmv:
					return Wmv;
				case _ext_wmx:
					return Wmx;
				case _ext_wvx:
					return Wvx;
				case _ext_avi:
					return Avi;
				case _ext_movie:
					return Movie;
				case _ext_smv:
					return Smv;
				case _ext_ice:
					return Ice;
				case _ext_jsonld:
					return Jsonld;
				case _ext_geojson:
					return Geojson;
				case _ext_webmanifest:
					return Webmanifest;
				case _ext_webapp:
					return Webapp;
				case _ext_jxr:
				case _ext_hdp:
					return Jxr;
				case _ext_jng:
					return Jng;
				case _ext_woff2:
					return Woff2;
				case _ext_bbaw:
					return Bbaw;
				case _ext_crx:
					return Crx;
				case _ext_cco:
					return Cco;
				case _ext_jardiff:
					return Jardiff;
				case _ext_run:
					return Run;
				case _ext_oex:
					return Oex;
				case _ext_pl:
				case _ext_pm:
					return Pl;
				case _ext_rpm:
					return Rpm;
				case _ext_sea:
					return Sea;
				case _ext_md:
					return Md;
				case _ext_mml:
					return Mml;
				case _ext_xloc:
					return Xloc;
				case _ext_vtt:
					return Vtt;
				case _ext_htc:
					return Htc;                
				default: 
					return null;
            }
        }
    }
}
