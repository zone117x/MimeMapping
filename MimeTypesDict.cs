

using System;
using System.Collections.Generic;

namespace MimeMapping
{

	///<summary>
	/// MIME type constants with lookup by file extension. Last updated on 2017-08-03T20:44:54Z. 
	/// Generated from the <a href="http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types">apache</a> and <a href="https://raw.githubusercontent.com/h5bp/server-configs-nginx/master/mime.types">nginx</a> sources
	///</summary>
    public static partial class MimeTypes
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
        public const string MimeTypeEZ = "application/andrew-inset";

		///<summary>aw</summary>
        public const string MimeTypeAW = "application/applixware";

		///<summary>atom</summary>
        public const string MimeTypeATOM = "application/atom+xml";

		///<summary>atomcat</summary>
        public const string MimeTypeATOMCAT = "application/atomcat+xml";

		///<summary>atomsvc</summary>
        public const string MimeTypeATOMSVC = "application/atomsvc+xml";

		///<summary>ccxml</summary>
        public const string MimeTypeCCXML = "application/ccxml+xml";

		///<summary>cdmia</summary>
        public const string MimeTypeCDMIA = "application/cdmi-capability";

		///<summary>cdmic</summary>
        public const string MimeTypeCDMIC = "application/cdmi-container";

		///<summary>cdmid</summary>
        public const string MimeTypeCDMID = "application/cdmi-domain";

		///<summary>cdmio</summary>
        public const string MimeTypeCDMIO = "application/cdmi-object";

		///<summary>cdmiq</summary>
        public const string MimeTypeCDMIQ = "application/cdmi-queue";

		///<summary>cu</summary>
        public const string MimeTypeCU = "application/cu-seeme";

		///<summary>davmount</summary>
        public const string MimeTypeDAVMOUNT = "application/davmount+xml";

		///<summary>dbk</summary>
        public const string MimeTypeDBK = "application/docbook+xml";

		///<summary>dssc</summary>
        public const string MimeTypeDSSC = "application/dssc+der";

		///<summary>xdssc</summary>
        public const string MimeTypeXDSSC = "application/dssc+xml";

		///<summary>ecma</summary>
        public const string MimeTypeECMA = "application/ecmascript";

		///<summary>emma</summary>
        public const string MimeTypeEMMA = "application/emma+xml";

		///<summary>epub</summary>
        public const string MimeTypeEPUB = "application/epub+zip";

		///<summary>exi</summary>
        public const string MimeTypeEXI = "application/exi";

		///<summary>pfr</summary>
        public const string MimeTypePFR = "application/font-tdpfr";

		///<summary>woff</summary>
        public const string MimeTypeWOFF = "application/font-woff";

		///<summary>gml</summary>
        public const string MimeTypeGML = "application/gml+xml";

		///<summary>gpx</summary>
        public const string MimeTypeGPX = "application/gpx+xml";

		///<summary>gxf</summary>
        public const string MimeTypeGXF = "application/gxf";

		///<summary>stk</summary>
        public const string MimeTypeSTK = "application/hyperstudio";

		///<summary>ink</summary>
        public const string MimeTypeINK = "application/inkml+xml";

		///<summary>inkml</summary>
        public const string MimeTypeINKML = "application/inkml+xml";

		///<summary>ipfix</summary>
        public const string MimeTypeIPFIX = "application/ipfix";

		///<summary>jar</summary>
        public const string MimeTypeJAR = "application/java-archive";

		///<summary>ser</summary>
        public const string MimeTypeSER = "application/java-serialized-object";

		///<summary>class</summary>
        public const string MimeTypeCLASS = "application/java-vm";

		///<summary>js</summary>
        public const string MimeTypeJS = "application/javascript";

		///<summary>json</summary>
        public const string MimeTypeJSON = "application/json";

		///<summary>jsonml</summary>
        public const string MimeTypeJSONML = "application/jsonml+json";

		///<summary>lostxml</summary>
        public const string MimeTypeLOSTXML = "application/lost+xml";

		///<summary>hqx</summary>
        public const string MimeTypeHQX = "application/mac-binhex40";

		///<summary>cpt</summary>
        public const string MimeTypeCPT = "application/mac-compactpro";

		///<summary>mads</summary>
        public const string MimeTypeMADS = "application/mads+xml";

		///<summary>mrc</summary>
        public const string MimeTypeMRC = "application/marc";

		///<summary>mrcx</summary>
        public const string MimeTypeMRCX = "application/marcxml+xml";

		///<summary>ma</summary>
        public const string MimeTypeMA = "application/mathematica";

		///<summary>nb</summary>
        public const string MimeTypeNB = "application/mathematica";

		///<summary>mb</summary>
        public const string MimeTypeMB = "application/mathematica";

		///<summary>mathml</summary>
        public const string MimeTypeMATHML = "application/mathml+xml";

		///<summary>mbox</summary>
        public const string MimeTypeMBOX = "application/mbox";

		///<summary>mscml</summary>
        public const string MimeTypeMSCML = "application/mediaservercontrol+xml";

		///<summary>metalink</summary>
        public const string MimeTypeMETALINK = "application/metalink+xml";

		///<summary>meta4</summary>
        public const string MimeTypeMETA4 = "application/metalink4+xml";

		///<summary>mets</summary>
        public const string MimeTypeMETS = "application/mets+xml";

		///<summary>mods</summary>
        public const string MimeTypeMODS = "application/mods+xml";

		///<summary>m21</summary>
        public const string MimeTypeM21 = "application/mp21";

		///<summary>mp21</summary>
        public const string MimeTypeMP21 = "application/mp21";

		///<summary>mp4s</summary>
        public const string MimeTypeMP4S = "application/mp4";

		///<summary>doc</summary>
        public const string MimeTypeDOC = "application/msword";

		///<summary>dot</summary>
        public const string MimeTypeDOT = "application/msword";

		///<summary>mxf</summary>
        public const string MimeTypeMXF = "application/mxf";

		///<summary>bin</summary>
        public const string MimeTypeBIN = "application/octet-stream";

		///<summary>dms</summary>
        public const string MimeTypeDMS = "application/octet-stream";

		///<summary>lrf</summary>
        public const string MimeTypeLRF = "application/octet-stream";

		///<summary>mar</summary>
        public const string MimeTypeMAR = "application/octet-stream";

		///<summary>so</summary>
        public const string MimeTypeSO = "application/octet-stream";

		///<summary>dist</summary>
        public const string MimeTypeDIST = "application/octet-stream";

		///<summary>distz</summary>
        public const string MimeTypeDISTZ = "application/octet-stream";

		///<summary>pkg</summary>
        public const string MimeTypePKG = "application/octet-stream";

		///<summary>bpk</summary>
        public const string MimeTypeBPK = "application/octet-stream";

		///<summary>dump</summary>
        public const string MimeTypeDUMP = "application/octet-stream";

		///<summary>elc</summary>
        public const string MimeTypeELC = "application/octet-stream";

		///<summary>deploy</summary>
        public const string MimeTypeDEPLOY = "application/octet-stream";

		///<summary>oda</summary>
        public const string MimeTypeODA = "application/oda";

		///<summary>opf</summary>
        public const string MimeTypeOPF = "application/oebps-package+xml";

		///<summary>ogx</summary>
        public const string MimeTypeOGX = "application/ogg";

		///<summary>omdoc</summary>
        public const string MimeTypeOMDOC = "application/omdoc+xml";

		///<summary>onetoc</summary>
        public const string MimeTypeONETOC = "application/onenote";

		///<summary>onetoc2</summary>
        public const string MimeTypeONETOC2 = "application/onenote";

		///<summary>onetmp</summary>
        public const string MimeTypeONETMP = "application/onenote";

		///<summary>onepkg</summary>
        public const string MimeTypeONEPKG = "application/onenote";

		///<summary>oxps</summary>
        public const string MimeTypeOXPS = "application/oxps";

		///<summary>xer</summary>
        public const string MimeTypeXER = "application/patch-ops-error+xml";

		///<summary>pdf</summary>
        public const string MimeTypePDF = "application/pdf";

		///<summary>pgp</summary>
        public const string MimeTypePGP = "application/pgp-encrypted";

		///<summary>asc</summary>
        public const string MimeTypeASC = "application/pgp-signature";

		///<summary>sig</summary>
        public const string MimeTypeSIG = "application/pgp-signature";

		///<summary>prf</summary>
        public const string MimeTypePRF = "application/pics-rules";

		///<summary>p10</summary>
        public const string MimeTypeP10 = "application/pkcs10";

		///<summary>p7m</summary>
        public const string MimeTypeP7M = "application/pkcs7-mime";

		///<summary>p7c</summary>
        public const string MimeTypeP7C = "application/pkcs7-mime";

		///<summary>p7s</summary>
        public const string MimeTypeP7S = "application/pkcs7-signature";

		///<summary>p8</summary>
        public const string MimeTypeP8 = "application/pkcs8";

		///<summary>ac</summary>
        public const string MimeTypeAC = "application/pkix-attr-cert";

		///<summary>cer</summary>
        public const string MimeTypeCER = "application/pkix-cert";

		///<summary>crl</summary>
        public const string MimeTypeCRL = "application/pkix-crl";

		///<summary>pkipath</summary>
        public const string MimeTypePKIPATH = "application/pkix-pkipath";

		///<summary>pki</summary>
        public const string MimeTypePKI = "application/pkixcmp";

		///<summary>pls</summary>
        public const string MimeTypePLS = "application/pls+xml";

		///<summary>ai</summary>
        public const string MimeTypeAI = "application/postscript";

		///<summary>eps</summary>
        public const string MimeTypeEPS = "application/postscript";

		///<summary>ps</summary>
        public const string MimeTypePS = "application/postscript";

		///<summary>cww</summary>
        public const string MimeTypeCWW = "application/prs.cww";

		///<summary>pskcxml</summary>
        public const string MimeTypePSKCXML = "application/pskc+xml";

		///<summary>rdf</summary>
        public const string MimeTypeRDF = "application/rdf+xml";

		///<summary>rif</summary>
        public const string MimeTypeRIF = "application/reginfo+xml";

		///<summary>rnc</summary>
        public const string MimeTypeRNC = "application/relax-ng-compact-syntax";

		///<summary>rl</summary>
        public const string MimeTypeRL = "application/resource-lists+xml";

		///<summary>rld</summary>
        public const string MimeTypeRLD = "application/resource-lists-diff+xml";

		///<summary>rs</summary>
        public const string MimeTypeRS = "application/rls-services+xml";

		///<summary>gbr</summary>
        public const string MimeTypeGBR = "application/rpki-ghostbusters";

		///<summary>mft</summary>
        public const string MimeTypeMFT = "application/rpki-manifest";

		///<summary>roa</summary>
        public const string MimeTypeROA = "application/rpki-roa";

		///<summary>rsd</summary>
        public const string MimeTypeRSD = "application/rsd+xml";

		///<summary>rss</summary>
        public const string MimeTypeRSS = "application/rss+xml";

		///<summary>rtf</summary>
        public const string MimeTypeRTF = "application/rtf";

		///<summary>sbml</summary>
        public const string MimeTypeSBML = "application/sbml+xml";

		///<summary>scq</summary>
        public const string MimeTypeSCQ = "application/scvp-cv-request";

		///<summary>scs</summary>
        public const string MimeTypeSCS = "application/scvp-cv-response";

		///<summary>spq</summary>
        public const string MimeTypeSPQ = "application/scvp-vp-request";

		///<summary>spp</summary>
        public const string MimeTypeSPP = "application/scvp-vp-response";

		///<summary>sdp</summary>
        public const string MimeTypeSDP = "application/sdp";

		///<summary>setpay</summary>
        public const string MimeTypeSETPAY = "application/set-payment-initiation";

		///<summary>setreg</summary>
        public const string MimeTypeSETREG = "application/set-registration-initiation";

		///<summary>shf</summary>
        public const string MimeTypeSHF = "application/shf+xml";

		///<summary>smi</summary>
        public const string MimeTypeSMI = "application/smil+xml";

		///<summary>smil</summary>
        public const string MimeTypeSMIL = "application/smil+xml";

		///<summary>rq</summary>
        public const string MimeTypeRQ = "application/sparql-query";

		///<summary>srx</summary>
        public const string MimeTypeSRX = "application/sparql-results+xml";

		///<summary>gram</summary>
        public const string MimeTypeGRAM = "application/srgs";

		///<summary>grxml</summary>
        public const string MimeTypeGRXML = "application/srgs+xml";

		///<summary>sru</summary>
        public const string MimeTypeSRU = "application/sru+xml";

		///<summary>ssdl</summary>
        public const string MimeTypeSSDL = "application/ssdl+xml";

		///<summary>ssml</summary>
        public const string MimeTypeSSML = "application/ssml+xml";

		///<summary>tei</summary>
        public const string MimeTypeTEI = "application/tei+xml";

		///<summary>teicorpus</summary>
        public const string MimeTypeTEICORPUS = "application/tei+xml";

		///<summary>tfi</summary>
        public const string MimeTypeTFI = "application/thraud+xml";

		///<summary>tsd</summary>
        public const string MimeTypeTSD = "application/timestamped-data";

		///<summary>plb</summary>
        public const string MimeTypePLB = "application/vnd.3gpp.pic-bw-large";

		///<summary>psb</summary>
        public const string MimeTypePSB = "application/vnd.3gpp.pic-bw-small";

		///<summary>pvb</summary>
        public const string MimeTypePVB = "application/vnd.3gpp.pic-bw-var";

		///<summary>tcap</summary>
        public const string MimeTypeTCAP = "application/vnd.3gpp2.tcap";

		///<summary>pwn</summary>
        public const string MimeTypePWN = "application/vnd.3m.post-it-notes";

		///<summary>aso</summary>
        public const string MimeTypeASO = "application/vnd.accpac.simply.aso";

		///<summary>imp</summary>
        public const string MimeTypeIMP = "application/vnd.accpac.simply.imp";

		///<summary>acu</summary>
        public const string MimeTypeACU = "application/vnd.acucobol";

		///<summary>atc</summary>
        public const string MimeTypeATC = "application/vnd.acucorp";

		///<summary>acutc</summary>
        public const string MimeTypeACUTC = "application/vnd.acucorp";

		///<summary>air</summary>
        public const string MimeTypeAIR = "application/vnd.adobe.air-application-installer-package+zip";

		///<summary>fcdt</summary>
        public const string MimeTypeFCDT = "application/vnd.adobe.formscentral.fcdt";

		///<summary>fxp</summary>
        public const string MimeTypeFXP = "application/vnd.adobe.fxp";

		///<summary>fxpl</summary>
        public const string MimeTypeFXPL = "application/vnd.adobe.fxp";

		///<summary>xdp</summary>
        public const string MimeTypeXDP = "application/vnd.adobe.xdp+xml";

		///<summary>xfdf</summary>
        public const string MimeTypeXFDF = "application/vnd.adobe.xfdf";

		///<summary>ahead</summary>
        public const string MimeTypeAHEAD = "application/vnd.ahead.space";

		///<summary>azf</summary>
        public const string MimeTypeAZF = "application/vnd.airzip.filesecure.azf";

		///<summary>azs</summary>
        public const string MimeTypeAZS = "application/vnd.airzip.filesecure.azs";

		///<summary>azw</summary>
        public const string MimeTypeAZW = "application/vnd.amazon.ebook";

		///<summary>acc</summary>
        public const string MimeTypeACC = "application/vnd.americandynamics.acc";

		///<summary>ami</summary>
        public const string MimeTypeAMI = "application/vnd.amiga.ami";

		///<summary>apk</summary>
        public const string MimeTypeAPK = "application/vnd.android.package-archive";

		///<summary>cii</summary>
        public const string MimeTypeCII = "application/vnd.anser-web-certificate-issue-initiation";

		///<summary>fti</summary>
        public const string MimeTypeFTI = "application/vnd.anser-web-funds-transfer-initiation";

		///<summary>atx</summary>
        public const string MimeTypeATX = "application/vnd.antix.game-component";

		///<summary>mpkg</summary>
        public const string MimeTypeMPKG = "application/vnd.apple.installer+xml";

		///<summary>m3u8</summary>
        public const string MimeTypeM3U8 = "application/vnd.apple.mpegurl";

		///<summary>swi</summary>
        public const string MimeTypeSWI = "application/vnd.aristanetworks.swi";

		///<summary>iota</summary>
        public const string MimeTypeIOTA = "application/vnd.astraea-software.iota";

		///<summary>aep</summary>
        public const string MimeTypeAEP = "application/vnd.audiograph";

		///<summary>mpm</summary>
        public const string MimeTypeMPM = "application/vnd.blueice.multipass";

		///<summary>bmi</summary>
        public const string MimeTypeBMI = "application/vnd.bmi";

		///<summary>rep</summary>
        public const string MimeTypeREP = "application/vnd.businessobjects";

		///<summary>cdxml</summary>
        public const string MimeTypeCDXML = "application/vnd.chemdraw+xml";

		///<summary>mmd</summary>
        public const string MimeTypeMMD = "application/vnd.chipnuts.karaoke-mmd";

		///<summary>cdy</summary>
        public const string MimeTypeCDY = "application/vnd.cinderella";

		///<summary>cla</summary>
        public const string MimeTypeCLA = "application/vnd.claymore";

		///<summary>rp9</summary>
        public const string MimeTypeRP9 = "application/vnd.cloanto.rp9";

		///<summary>c4g</summary>
        public const string MimeTypeC4G = "application/vnd.clonk.c4group";

		///<summary>c4d</summary>
        public const string MimeTypeC4D = "application/vnd.clonk.c4group";

		///<summary>c4f</summary>
        public const string MimeTypeC4F = "application/vnd.clonk.c4group";

		///<summary>c4p</summary>
        public const string MimeTypeC4P = "application/vnd.clonk.c4group";

		///<summary>c4u</summary>
        public const string MimeTypeC4U = "application/vnd.clonk.c4group";

		///<summary>c11amc</summary>
        public const string MimeTypeC11AMC = "application/vnd.cluetrust.cartomobile-config";

		///<summary>c11amz</summary>
        public const string MimeTypeC11AMZ = "application/vnd.cluetrust.cartomobile-config-pkg";

		///<summary>csp</summary>
        public const string MimeTypeCSP = "application/vnd.commonspace";

		///<summary>cdbcmsg</summary>
        public const string MimeTypeCDBCMSG = "application/vnd.contact.cmsg";

		///<summary>cmc</summary>
        public const string MimeTypeCMC = "application/vnd.cosmocaller";

		///<summary>clkx</summary>
        public const string MimeTypeCLKX = "application/vnd.crick.clicker";

		///<summary>clkk</summary>
        public const string MimeTypeCLKK = "application/vnd.crick.clicker.keyboard";

		///<summary>clkp</summary>
        public const string MimeTypeCLKP = "application/vnd.crick.clicker.palette";

		///<summary>clkt</summary>
        public const string MimeTypeCLKT = "application/vnd.crick.clicker.template";

		///<summary>clkw</summary>
        public const string MimeTypeCLKW = "application/vnd.crick.clicker.wordbank";

		///<summary>wbs</summary>
        public const string MimeTypeWBS = "application/vnd.criticaltools.wbs+xml";

		///<summary>pml</summary>
        public const string MimeTypePML = "application/vnd.ctc-posml";

		///<summary>ppd</summary>
        public const string MimeTypePPD = "application/vnd.cups-ppd";

		///<summary>car</summary>
        public const string MimeTypeCAR = "application/vnd.curl.car";

		///<summary>pcurl</summary>
        public const string MimeTypePCURL = "application/vnd.curl.pcurl";

		///<summary>dart</summary>
        public const string MimeTypeDART = "application/vnd.dart";

		///<summary>rdz</summary>
        public const string MimeTypeRDZ = "application/vnd.data-vision.rdz";

		///<summary>uvf</summary>
        public const string MimeTypeUVF = "application/vnd.dece.data";

		///<summary>uvvf</summary>
        public const string MimeTypeUVVF = "application/vnd.dece.data";

		///<summary>uvd</summary>
        public const string MimeTypeUVD = "application/vnd.dece.data";

		///<summary>uvvd</summary>
        public const string MimeTypeUVVD = "application/vnd.dece.data";

		///<summary>uvt</summary>
        public const string MimeTypeUVT = "application/vnd.dece.ttml+xml";

		///<summary>uvvt</summary>
        public const string MimeTypeUVVT = "application/vnd.dece.ttml+xml";

		///<summary>uvx</summary>
        public const string MimeTypeUVX = "application/vnd.dece.unspecified";

		///<summary>uvvx</summary>
        public const string MimeTypeUVVX = "application/vnd.dece.unspecified";

		///<summary>uvz</summary>
        public const string MimeTypeUVZ = "application/vnd.dece.zip";

		///<summary>uvvz</summary>
        public const string MimeTypeUVVZ = "application/vnd.dece.zip";

		///<summary>fe_launch</summary>
        public const string MimeTypeFELAUNCH = "application/vnd.denovo.fcselayout-link";

		///<summary>dna</summary>
        public const string MimeTypeDNA = "application/vnd.dna";

		///<summary>mlp</summary>
        public const string MimeTypeMLP = "application/vnd.dolby.mlp";

		///<summary>dpg</summary>
        public const string MimeTypeDPG = "application/vnd.dpgraph";

		///<summary>dfac</summary>
        public const string MimeTypeDFAC = "application/vnd.dreamfactory";

		///<summary>kpxx</summary>
        public const string MimeTypeKPXX = "application/vnd.ds-keypoint";

		///<summary>ait</summary>
        public const string MimeTypeAIT = "application/vnd.dvb.ait";

		///<summary>svc</summary>
        public const string MimeTypeSVC = "application/vnd.dvb.service";

		///<summary>geo</summary>
        public const string MimeTypeGEO = "application/vnd.dynageo";

		///<summary>mag</summary>
        public const string MimeTypeMAG = "application/vnd.ecowin.chart";

		///<summary>nml</summary>
        public const string MimeTypeNML = "application/vnd.enliven";

		///<summary>esf</summary>
        public const string MimeTypeESF = "application/vnd.epson.esf";

		///<summary>msf</summary>
        public const string MimeTypeMSF = "application/vnd.epson.msf";

		///<summary>qam</summary>
        public const string MimeTypeQAM = "application/vnd.epson.quickanime";

		///<summary>slt</summary>
        public const string MimeTypeSLT = "application/vnd.epson.salt";

		///<summary>ssf</summary>
        public const string MimeTypeSSF = "application/vnd.epson.ssf";

		///<summary>es3</summary>
        public const string MimeTypeES3 = "application/vnd.eszigno3+xml";

		///<summary>et3</summary>
        public const string MimeTypeET3 = "application/vnd.eszigno3+xml";

		///<summary>ez2</summary>
        public const string MimeTypeEZ2 = "application/vnd.ezpix-album";

		///<summary>ez3</summary>
        public const string MimeTypeEZ3 = "application/vnd.ezpix-package";

		///<summary>fdf</summary>
        public const string MimeTypeFDF = "application/vnd.fdf";

		///<summary>mseed</summary>
        public const string MimeTypeMSEED = "application/vnd.fdsn.mseed";

		///<summary>seed</summary>
        public const string MimeTypeSEED = "application/vnd.fdsn.seed";

		///<summary>dataless</summary>
        public const string MimeTypeDATALESS = "application/vnd.fdsn.seed";

		///<summary>gph</summary>
        public const string MimeTypeGPH = "application/vnd.flographit";

		///<summary>ftc</summary>
        public const string MimeTypeFTC = "application/vnd.fluxtime.clip";

		///<summary>fm</summary>
        public const string MimeTypeFM = "application/vnd.framemaker";

		///<summary>frame</summary>
        public const string MimeTypeFRAME = "application/vnd.framemaker";

		///<summary>maker</summary>
        public const string MimeTypeMAKER = "application/vnd.framemaker";

		///<summary>book</summary>
        public const string MimeTypeBOOK = "application/vnd.framemaker";

		///<summary>fnc</summary>
        public const string MimeTypeFNC = "application/vnd.frogans.fnc";

		///<summary>ltf</summary>
        public const string MimeTypeLTF = "application/vnd.frogans.ltf";

		///<summary>fsc</summary>
        public const string MimeTypeFSC = "application/vnd.fsc.weblaunch";

		///<summary>oas</summary>
        public const string MimeTypeOAS = "application/vnd.fujitsu.oasys";

		///<summary>oa2</summary>
        public const string MimeTypeOA2 = "application/vnd.fujitsu.oasys2";

		///<summary>oa3</summary>
        public const string MimeTypeOA3 = "application/vnd.fujitsu.oasys3";

		///<summary>fg5</summary>
        public const string MimeTypeFG5 = "application/vnd.fujitsu.oasysgp";

		///<summary>bh2</summary>
        public const string MimeTypeBH2 = "application/vnd.fujitsu.oasysprs";

		///<summary>ddd</summary>
        public const string MimeTypeDDD = "application/vnd.fujixerox.ddd";

		///<summary>xdw</summary>
        public const string MimeTypeXDW = "application/vnd.fujixerox.docuworks";

		///<summary>xbd</summary>
        public const string MimeTypeXBD = "application/vnd.fujixerox.docuworks.binder";

		///<summary>fzs</summary>
        public const string MimeTypeFZS = "application/vnd.fuzzysheet";

		///<summary>txd</summary>
        public const string MimeTypeTXD = "application/vnd.genomatix.tuxedo";

		///<summary>ggb</summary>
        public const string MimeTypeGGB = "application/vnd.geogebra.file";

		///<summary>ggt</summary>
        public const string MimeTypeGGT = "application/vnd.geogebra.tool";

		///<summary>gex</summary>
        public const string MimeTypeGEX = "application/vnd.geometry-explorer";

		///<summary>gre</summary>
        public const string MimeTypeGRE = "application/vnd.geometry-explorer";

		///<summary>gxt</summary>
        public const string MimeTypeGXT = "application/vnd.geonext";

		///<summary>g2w</summary>
        public const string MimeTypeG2W = "application/vnd.geoplan";

		///<summary>g3w</summary>
        public const string MimeTypeG3W = "application/vnd.geospace";

		///<summary>gmx</summary>
        public const string MimeTypeGMX = "application/vnd.gmx";

		///<summary>kml</summary>
        public const string MimeTypeKML = "application/vnd.google-earth.kml+xml";

		///<summary>kmz</summary>
        public const string MimeTypeKMZ = "application/vnd.google-earth.kmz";

		///<summary>gqf</summary>
        public const string MimeTypeGQF = "application/vnd.grafeq";

		///<summary>gqs</summary>
        public const string MimeTypeGQS = "application/vnd.grafeq";

		///<summary>gac</summary>
        public const string MimeTypeGAC = "application/vnd.groove-account";

		///<summary>ghf</summary>
        public const string MimeTypeGHF = "application/vnd.groove-help";

		///<summary>gim</summary>
        public const string MimeTypeGIM = "application/vnd.groove-identity-message";

		///<summary>grv</summary>
        public const string MimeTypeGRV = "application/vnd.groove-injector";

		///<summary>gtm</summary>
        public const string MimeTypeGTM = "application/vnd.groove-tool-message";

		///<summary>tpl</summary>
        public const string MimeTypeTPL = "application/vnd.groove-tool-template";

		///<summary>vcg</summary>
        public const string MimeTypeVCG = "application/vnd.groove-vcard";

		///<summary>hal</summary>
        public const string MimeTypeHAL = "application/vnd.hal+xml";

		///<summary>zmm</summary>
        public const string MimeTypeZMM = "application/vnd.handheld-entertainment+xml";

		///<summary>hbci</summary>
        public const string MimeTypeHBCI = "application/vnd.hbci";

		///<summary>les</summary>
        public const string MimeTypeLES = "application/vnd.hhe.lesson-player";

		///<summary>hpgl</summary>
        public const string MimeTypeHPGL = "application/vnd.hp-hpgl";

		///<summary>hpid</summary>
        public const string MimeTypeHPID = "application/vnd.hp-hpid";

		///<summary>hps</summary>
        public const string MimeTypeHPS = "application/vnd.hp-hps";

		///<summary>jlt</summary>
        public const string MimeTypeJLT = "application/vnd.hp-jlyt";

		///<summary>pcl</summary>
        public const string MimeTypePCL = "application/vnd.hp-pcl";

		///<summary>pclxl</summary>
        public const string MimeTypePCLXL = "application/vnd.hp-pclxl";

		///<summary>sfd-hdstx</summary>
        public const string MimeTypeSFDHDSTX = "application/vnd.hydrostatix.sof-data";

		///<summary>mpy</summary>
        public const string MimeTypeMPY = "application/vnd.ibm.minipay";

		///<summary>afp</summary>
        public const string MimeTypeAFP = "application/vnd.ibm.modcap";

		///<summary>listafp</summary>
        public const string MimeTypeLISTAFP = "application/vnd.ibm.modcap";

		///<summary>list3820</summary>
        public const string MimeTypeLIST3820 = "application/vnd.ibm.modcap";

		///<summary>irm</summary>
        public const string MimeTypeIRM = "application/vnd.ibm.rights-management";

		///<summary>sc</summary>
        public const string MimeTypeSC = "application/vnd.ibm.secure-container";

		///<summary>icc</summary>
        public const string MimeTypeICC = "application/vnd.iccprofile";

		///<summary>icm</summary>
        public const string MimeTypeICM = "application/vnd.iccprofile";

		///<summary>igl</summary>
        public const string MimeTypeIGL = "application/vnd.igloader";

		///<summary>ivp</summary>
        public const string MimeTypeIVP = "application/vnd.immervision-ivp";

		///<summary>ivu</summary>
        public const string MimeTypeIVU = "application/vnd.immervision-ivu";

		///<summary>igm</summary>
        public const string MimeTypeIGM = "application/vnd.insors.igm";

		///<summary>xpw</summary>
        public const string MimeTypeXPW = "application/vnd.intercon.formnet";

		///<summary>xpx</summary>
        public const string MimeTypeXPX = "application/vnd.intercon.formnet";

		///<summary>i2g</summary>
        public const string MimeTypeI2G = "application/vnd.intergeo";

		///<summary>qbo</summary>
        public const string MimeTypeQBO = "application/vnd.intu.qbo";

		///<summary>qfx</summary>
        public const string MimeTypeQFX = "application/vnd.intu.qfx";

		///<summary>rcprofile</summary>
        public const string MimeTypeRCPROFILE = "application/vnd.ipunplugged.rcprofile";

		///<summary>irp</summary>
        public const string MimeTypeIRP = "application/vnd.irepository.package+xml";

		///<summary>xpr</summary>
        public const string MimeTypeXPR = "application/vnd.is-xpr";

		///<summary>fcs</summary>
        public const string MimeTypeFCS = "application/vnd.isac.fcs";

		///<summary>jam</summary>
        public const string MimeTypeJAM = "application/vnd.jam";

		///<summary>rms</summary>
        public const string MimeTypeRMS = "application/vnd.jcp.javame.midlet-rms";

		///<summary>jisp</summary>
        public const string MimeTypeJISP = "application/vnd.jisp";

		///<summary>joda</summary>
        public const string MimeTypeJODA = "application/vnd.joost.joda-archive";

		///<summary>ktz</summary>
        public const string MimeTypeKTZ = "application/vnd.kahootz";

		///<summary>ktr</summary>
        public const string MimeTypeKTR = "application/vnd.kahootz";

		///<summary>karbon</summary>
        public const string MimeTypeKARBON = "application/vnd.kde.karbon";

		///<summary>chrt</summary>
        public const string MimeTypeCHRT = "application/vnd.kde.kchart";

		///<summary>kfo</summary>
        public const string MimeTypeKFO = "application/vnd.kde.kformula";

		///<summary>flw</summary>
        public const string MimeTypeFLW = "application/vnd.kde.kivio";

		///<summary>kon</summary>
        public const string MimeTypeKON = "application/vnd.kde.kontour";

		///<summary>kpr</summary>
        public const string MimeTypeKPR = "application/vnd.kde.kpresenter";

		///<summary>kpt</summary>
        public const string MimeTypeKPT = "application/vnd.kde.kpresenter";

		///<summary>ksp</summary>
        public const string MimeTypeKSP = "application/vnd.kde.kspread";

		///<summary>kwd</summary>
        public const string MimeTypeKWD = "application/vnd.kde.kword";

		///<summary>kwt</summary>
        public const string MimeTypeKWT = "application/vnd.kde.kword";

		///<summary>htke</summary>
        public const string MimeTypeHTKE = "application/vnd.kenameaapp";

		///<summary>kia</summary>
        public const string MimeTypeKIA = "application/vnd.kidspiration";

		///<summary>kne</summary>
        public const string MimeTypeKNE = "application/vnd.kinar";

		///<summary>knp</summary>
        public const string MimeTypeKNP = "application/vnd.kinar";

		///<summary>skp</summary>
        public const string MimeTypeSKP = "application/vnd.koan";

		///<summary>skd</summary>
        public const string MimeTypeSKD = "application/vnd.koan";

		///<summary>skt</summary>
        public const string MimeTypeSKT = "application/vnd.koan";

		///<summary>skm</summary>
        public const string MimeTypeSKM = "application/vnd.koan";

		///<summary>sse</summary>
        public const string MimeTypeSSE = "application/vnd.kodak-descriptor";

		///<summary>lasxml</summary>
        public const string MimeTypeLASXML = "application/vnd.las.las+xml";

		///<summary>lbd</summary>
        public const string MimeTypeLBD = "application/vnd.llamagraphics.life-balance.desktop";

		///<summary>lbe</summary>
        public const string MimeTypeLBE = "application/vnd.llamagraphics.life-balance.exchange+xml";

		///<summary>123</summary>
        public const string MimeType123 = "application/vnd.lotus-1-2-3";

		///<summary>apr</summary>
        public const string MimeTypeAPR = "application/vnd.lotus-approach";

		///<summary>pre</summary>
        public const string MimeTypePRE = "application/vnd.lotus-freelance";

		///<summary>nsf</summary>
        public const string MimeTypeNSF = "application/vnd.lotus-notes";

		///<summary>org</summary>
        public const string MimeTypeORG = "application/vnd.lotus-organizer";

		///<summary>scm</summary>
        public const string MimeTypeSCM = "application/vnd.lotus-screencam";

		///<summary>lwp</summary>
        public const string MimeTypeLWP = "application/vnd.lotus-wordpro";

		///<summary>portpkg</summary>
        public const string MimeTypePORTPKG = "application/vnd.macports.portpkg";

		///<summary>mcd</summary>
        public const string MimeTypeMCD = "application/vnd.mcd";

		///<summary>mc1</summary>
        public const string MimeTypeMC1 = "application/vnd.medcalcdata";

		///<summary>cdkey</summary>
        public const string MimeTypeCDKEY = "application/vnd.mediastation.cdkey";

		///<summary>mwf</summary>
        public const string MimeTypeMWF = "application/vnd.mfer";

		///<summary>mfm</summary>
        public const string MimeTypeMFM = "application/vnd.mfmp";

		///<summary>flo</summary>
        public const string MimeTypeFLO = "application/vnd.micrografx.flo";

		///<summary>igx</summary>
        public const string MimeTypeIGX = "application/vnd.micrografx.igx";

		///<summary>mif</summary>
        public const string MimeTypeMIF = "application/vnd.mif";

		///<summary>daf</summary>
        public const string MimeTypeDAF = "application/vnd.mobius.daf";

		///<summary>dis</summary>
        public const string MimeTypeDIS = "application/vnd.mobius.dis";

		///<summary>mbk</summary>
        public const string MimeTypeMBK = "application/vnd.mobius.mbk";

		///<summary>mqy</summary>
        public const string MimeTypeMQY = "application/vnd.mobius.mqy";

		///<summary>msl</summary>
        public const string MimeTypeMSL = "application/vnd.mobius.msl";

		///<summary>plc</summary>
        public const string MimeTypePLC = "application/vnd.mobius.plc";

		///<summary>txf</summary>
        public const string MimeTypeTXF = "application/vnd.mobius.txf";

		///<summary>mpn</summary>
        public const string MimeTypeMPN = "application/vnd.mophun.application";

		///<summary>mpc</summary>
        public const string MimeTypeMPC = "application/vnd.mophun.certificate";

		///<summary>xul</summary>
        public const string MimeTypeXUL = "application/vnd.mozilla.xul+xml";

		///<summary>cil</summary>
        public const string MimeTypeCIL = "application/vnd.ms-artgalry";

		///<summary>cab</summary>
        public const string MimeTypeCAB = "application/vnd.ms-cab-compressed";

		///<summary>xls</summary>
        public const string MimeTypeXLS = "application/vnd.ms-excel";

		///<summary>xlm</summary>
        public const string MimeTypeXLM = "application/vnd.ms-excel";

		///<summary>xla</summary>
        public const string MimeTypeXLA = "application/vnd.ms-excel";

		///<summary>xlc</summary>
        public const string MimeTypeXLC = "application/vnd.ms-excel";

		///<summary>xlt</summary>
        public const string MimeTypeXLT = "application/vnd.ms-excel";

		///<summary>xlw</summary>
        public const string MimeTypeXLW = "application/vnd.ms-excel";

		///<summary>xlam</summary>
        public const string MimeTypeXLAM = "application/vnd.ms-excel.addin.macroenabled.12";

		///<summary>xlsb</summary>
        public const string MimeTypeXLSB = "application/vnd.ms-excel.sheet.binary.macroenabled.12";

		///<summary>xlsm</summary>
        public const string MimeTypeXLSM = "application/vnd.ms-excel.sheet.macroenabled.12";

		///<summary>xltm</summary>
        public const string MimeTypeXLTM = "application/vnd.ms-excel.template.macroenabled.12";

		///<summary>eot</summary>
        public const string MimeTypeEOT = "application/vnd.ms-fontobject";

		///<summary>chm</summary>
        public const string MimeTypeCHM = "application/vnd.ms-htmlhelp";

		///<summary>ims</summary>
        public const string MimeTypeIMS = "application/vnd.ms-ims";

		///<summary>lrm</summary>
        public const string MimeTypeLRM = "application/vnd.ms-lrm";

		///<summary>thmx</summary>
        public const string MimeTypeTHMX = "application/vnd.ms-officetheme";

		///<summary>cat</summary>
        public const string MimeTypeCAT = "application/vnd.ms-pki.seccat";

		///<summary>stl</summary>
        public const string MimeTypeSTL = "application/vnd.ms-pki.stl";

		///<summary>ppt</summary>
        public const string MimeTypePPT = "application/vnd.ms-powerpoint";

		///<summary>pps</summary>
        public const string MimeTypePPS = "application/vnd.ms-powerpoint";

		///<summary>pot</summary>
        public const string MimeTypePOT = "application/vnd.ms-powerpoint";

		///<summary>ppam</summary>
        public const string MimeTypePPAM = "application/vnd.ms-powerpoint.addin.macroenabled.12";

		///<summary>pptm</summary>
        public const string MimeTypePPTM = "application/vnd.ms-powerpoint.presentation.macroenabled.12";

		///<summary>sldm</summary>
        public const string MimeTypeSLDM = "application/vnd.ms-powerpoint.slide.macroenabled.12";

		///<summary>ppsm</summary>
        public const string MimeTypePPSM = "application/vnd.ms-powerpoint.slideshow.macroenabled.12";

		///<summary>potm</summary>
        public const string MimeTypePOTM = "application/vnd.ms-powerpoint.template.macroenabled.12";

		///<summary>mpp</summary>
        public const string MimeTypeMPP = "application/vnd.ms-project";

		///<summary>mpt</summary>
        public const string MimeTypeMPT = "application/vnd.ms-project";

		///<summary>docm</summary>
        public const string MimeTypeDOCM = "application/vnd.ms-word.document.macroenabled.12";

		///<summary>dotm</summary>
        public const string MimeTypeDOTM = "application/vnd.ms-word.template.macroenabled.12";

		///<summary>wps</summary>
        public const string MimeTypeWPS = "application/vnd.ms-works";

		///<summary>wks</summary>
        public const string MimeTypeWKS = "application/vnd.ms-works";

		///<summary>wcm</summary>
        public const string MimeTypeWCM = "application/vnd.ms-works";

		///<summary>wdb</summary>
        public const string MimeTypeWDB = "application/vnd.ms-works";

		///<summary>wpl</summary>
        public const string MimeTypeWPL = "application/vnd.ms-wpl";

		///<summary>xps</summary>
        public const string MimeTypeXPS = "application/vnd.ms-xpsdocument";

		///<summary>mseq</summary>
        public const string MimeTypeMSEQ = "application/vnd.mseq";

		///<summary>mus</summary>
        public const string MimeTypeMUS = "application/vnd.musician";

		///<summary>msty</summary>
        public const string MimeTypeMSTY = "application/vnd.muvee.style";

		///<summary>taglet</summary>
        public const string MimeTypeTAGLET = "application/vnd.mynfc";

		///<summary>nlu</summary>
        public const string MimeTypeNLU = "application/vnd.neurolanguage.nlu";

		///<summary>ntf</summary>
        public const string MimeTypeNTF = "application/vnd.nitf";

		///<summary>nitf</summary>
        public const string MimeTypeNITF = "application/vnd.nitf";

		///<summary>nnd</summary>
        public const string MimeTypeNND = "application/vnd.noblenet-directory";

		///<summary>nns</summary>
        public const string MimeTypeNNS = "application/vnd.noblenet-sealer";

		///<summary>nnw</summary>
        public const string MimeTypeNNW = "application/vnd.noblenet-web";

		///<summary>ngdat</summary>
        public const string MimeTypeNGDAT = "application/vnd.nokia.n-gage.data";

		///<summary>n-gage</summary>
        public const string MimeTypeNGAGE = "application/vnd.nokia.n-gage.symbian.install";

		///<summary>rpst</summary>
        public const string MimeTypeRPST = "application/vnd.nokia.radio-preset";

		///<summary>rpss</summary>
        public const string MimeTypeRPSS = "application/vnd.nokia.radio-presets";

		///<summary>edm</summary>
        public const string MimeTypeEDM = "application/vnd.novadigm.edm";

		///<summary>edx</summary>
        public const string MimeTypeEDX = "application/vnd.novadigm.edx";

		///<summary>ext</summary>
        public const string MimeTypeEXT = "application/vnd.novadigm.ext";

		///<summary>odc</summary>
        public const string MimeTypeODC = "application/vnd.oasis.opendocument.chart";

		///<summary>otc</summary>
        public const string MimeTypeOTC = "application/vnd.oasis.opendocument.chart-template";

		///<summary>odb</summary>
        public const string MimeTypeODB = "application/vnd.oasis.opendocument.database";

		///<summary>odf</summary>
        public const string MimeTypeODF = "application/vnd.oasis.opendocument.formula";

		///<summary>odft</summary>
        public const string MimeTypeODFT = "application/vnd.oasis.opendocument.formula-template";

		///<summary>odg</summary>
        public const string MimeTypeODG = "application/vnd.oasis.opendocument.graphics";

		///<summary>otg</summary>
        public const string MimeTypeOTG = "application/vnd.oasis.opendocument.graphics-template";

		///<summary>odi</summary>
        public const string MimeTypeODI = "application/vnd.oasis.opendocument.image";

		///<summary>oti</summary>
        public const string MimeTypeOTI = "application/vnd.oasis.opendocument.image-template";

		///<summary>odp</summary>
        public const string MimeTypeODP = "application/vnd.oasis.opendocument.presentation";

		///<summary>otp</summary>
        public const string MimeTypeOTP = "application/vnd.oasis.opendocument.presentation-template";

		///<summary>ods</summary>
        public const string MimeTypeODS = "application/vnd.oasis.opendocument.spreadsheet";

		///<summary>ots</summary>
        public const string MimeTypeOTS = "application/vnd.oasis.opendocument.spreadsheet-template";

		///<summary>odt</summary>
        public const string MimeTypeODT = "application/vnd.oasis.opendocument.text";

		///<summary>odm</summary>
        public const string MimeTypeODM = "application/vnd.oasis.opendocument.text-master";

		///<summary>ott</summary>
        public const string MimeTypeOTT = "application/vnd.oasis.opendocument.text-template";

		///<summary>oth</summary>
        public const string MimeTypeOTH = "application/vnd.oasis.opendocument.text-web";

		///<summary>xo</summary>
        public const string MimeTypeXO = "application/vnd.olpc-sugar";

		///<summary>dd2</summary>
        public const string MimeTypeDD2 = "application/vnd.oma.dd2+xml";

		///<summary>oxt</summary>
        public const string MimeTypeOXT = "application/vnd.openofficeorg.extension";

		///<summary>pptx</summary>
        public const string MimeTypePPTX = "application/vnd.openxmlformats-officedocument.presentationml.presentation";

		///<summary>sldx</summary>
        public const string MimeTypeSLDX = "application/vnd.openxmlformats-officedocument.presentationml.slide";

		///<summary>ppsx</summary>
        public const string MimeTypePPSX = "application/vnd.openxmlformats-officedocument.presentationml.slideshow";

		///<summary>potx</summary>
        public const string MimeTypePOTX = "application/vnd.openxmlformats-officedocument.presentationml.template";

		///<summary>xlsx</summary>
        public const string MimeTypeXLSX = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

		///<summary>xltx</summary>
        public const string MimeTypeXLTX = "application/vnd.openxmlformats-officedocument.spreadsheetml.template";

		///<summary>docx</summary>
        public const string MimeTypeDOCX = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

		///<summary>dotx</summary>
        public const string MimeTypeDOTX = "application/vnd.openxmlformats-officedocument.wordprocessingml.template";

		///<summary>mgp</summary>
        public const string MimeTypeMGP = "application/vnd.osgeo.mapguide.package";

		///<summary>dp</summary>
        public const string MimeTypeDP = "application/vnd.osgi.dp";

		///<summary>esa</summary>
        public const string MimeTypeESA = "application/vnd.osgi.subsystem";

		///<summary>pdb</summary>
        public const string MimeTypePDB = "application/vnd.palm";

		///<summary>pqa</summary>
        public const string MimeTypePQA = "application/vnd.palm";

		///<summary>oprc</summary>
        public const string MimeTypeOPRC = "application/vnd.palm";

		///<summary>paw</summary>
        public const string MimeTypePAW = "application/vnd.pawaafile";

		///<summary>str</summary>
        public const string MimeTypeSTR = "application/vnd.pg.format";

		///<summary>ei6</summary>
        public const string MimeTypeEI6 = "application/vnd.pg.osasli";

		///<summary>efif</summary>
        public const string MimeTypeEFIF = "application/vnd.picsel";

		///<summary>wg</summary>
        public const string MimeTypeWG = "application/vnd.pmi.widget";

		///<summary>plf</summary>
        public const string MimeTypePLF = "application/vnd.pocketlearn";

		///<summary>pbd</summary>
        public const string MimeTypePBD = "application/vnd.powerbuilder6";

		///<summary>box</summary>
        public const string MimeTypeBOX = "application/vnd.previewsystems.box";

		///<summary>mgz</summary>
        public const string MimeTypeMGZ = "application/vnd.proteus.magazine";

		///<summary>qps</summary>
        public const string MimeTypeQPS = "application/vnd.publishare-delta-tree";

		///<summary>ptid</summary>
        public const string MimeTypePTID = "application/vnd.pvi.ptid1";

		///<summary>qxd</summary>
        public const string MimeTypeQXD = "application/vnd.quark.quarkxpress";

		///<summary>qxt</summary>
        public const string MimeTypeQXT = "application/vnd.quark.quarkxpress";

		///<summary>qwd</summary>
        public const string MimeTypeQWD = "application/vnd.quark.quarkxpress";

		///<summary>qwt</summary>
        public const string MimeTypeQWT = "application/vnd.quark.quarkxpress";

		///<summary>qxl</summary>
        public const string MimeTypeQXL = "application/vnd.quark.quarkxpress";

		///<summary>qxb</summary>
        public const string MimeTypeQXB = "application/vnd.quark.quarkxpress";

		///<summary>bed</summary>
        public const string MimeTypeBED = "application/vnd.realvnc.bed";

		///<summary>mxl</summary>
        public const string MimeTypeMXL = "application/vnd.recordare.musicxml";

		///<summary>musicxml</summary>
        public const string MimeTypeMUSICXML = "application/vnd.recordare.musicxml+xml";

		///<summary>cryptonote</summary>
        public const string MimeTypeCRYPTONOTE = "application/vnd.rig.cryptonote";

		///<summary>cod</summary>
        public const string MimeTypeCOD = "application/vnd.rim.cod";

		///<summary>rm</summary>
        public const string MimeTypeRM = "application/vnd.rn-realmedia";

		///<summary>rmvb</summary>
        public const string MimeTypeRMVB = "application/vnd.rn-realmedia-vbr";

		///<summary>link66</summary>
        public const string MimeTypeLINK66 = "application/vnd.route66.link66+xml";

		///<summary>st</summary>
        public const string MimeTypeST = "application/vnd.sailingtracker.track";

		///<summary>see</summary>
        public const string MimeTypeSEE = "application/vnd.seemail";

		///<summary>sema</summary>
        public const string MimeTypeSEMA = "application/vnd.sema";

		///<summary>semd</summary>
        public const string MimeTypeSEMD = "application/vnd.semd";

		///<summary>semf</summary>
        public const string MimeTypeSEMF = "application/vnd.semf";

		///<summary>ifm</summary>
        public const string MimeTypeIFM = "application/vnd.shana.informed.formdata";

		///<summary>itp</summary>
        public const string MimeTypeITP = "application/vnd.shana.informed.formtemplate";

		///<summary>iif</summary>
        public const string MimeTypeIIF = "application/vnd.shana.informed.interchange";

		///<summary>ipk</summary>
        public const string MimeTypeIPK = "application/vnd.shana.informed.package";

		///<summary>twd</summary>
        public const string MimeTypeTWD = "application/vnd.simtech-mindmapper";

		///<summary>twds</summary>
        public const string MimeTypeTWDS = "application/vnd.simtech-mindmapper";

		///<summary>mmf</summary>
        public const string MimeTypeMMF = "application/vnd.smaf";

		///<summary>teacher</summary>
        public const string MimeTypeTEACHER = "application/vnd.smart.teacher";

		///<summary>sdkm</summary>
        public const string MimeTypeSDKM = "application/vnd.solent.sdkm+xml";

		///<summary>sdkd</summary>
        public const string MimeTypeSDKD = "application/vnd.solent.sdkm+xml";

		///<summary>dxp</summary>
        public const string MimeTypeDXP = "application/vnd.spotfire.dxp";

		///<summary>sfs</summary>
        public const string MimeTypeSFS = "application/vnd.spotfire.sfs";

		///<summary>sdc</summary>
        public const string MimeTypeSDC = "application/vnd.stardivision.calc";

		///<summary>sda</summary>
        public const string MimeTypeSDA = "application/vnd.stardivision.draw";

		///<summary>sdd</summary>
        public const string MimeTypeSDD = "application/vnd.stardivision.impress";

		///<summary>smf</summary>
        public const string MimeTypeSMF = "application/vnd.stardivision.math";

		///<summary>sdw</summary>
        public const string MimeTypeSDW = "application/vnd.stardivision.writer";

		///<summary>vor</summary>
        public const string MimeTypeVOR = "application/vnd.stardivision.writer";

		///<summary>sgl</summary>
        public const string MimeTypeSGL = "application/vnd.stardivision.writer-global";

		///<summary>smzip</summary>
        public const string MimeTypeSMZIP = "application/vnd.stepmania.package";

		///<summary>sm</summary>
        public const string MimeTypeSM = "application/vnd.stepmania.stepchart";

		///<summary>sxc</summary>
        public const string MimeTypeSXC = "application/vnd.sun.xml.calc";

		///<summary>stc</summary>
        public const string MimeTypeSTC = "application/vnd.sun.xml.calc.template";

		///<summary>sxd</summary>
        public const string MimeTypeSXD = "application/vnd.sun.xml.draw";

		///<summary>std</summary>
        public const string MimeTypeSTD = "application/vnd.sun.xml.draw.template";

		///<summary>sxi</summary>
        public const string MimeTypeSXI = "application/vnd.sun.xml.impress";

		///<summary>sti</summary>
        public const string MimeTypeSTI = "application/vnd.sun.xml.impress.template";

		///<summary>sxm</summary>
        public const string MimeTypeSXM = "application/vnd.sun.xml.math";

		///<summary>sxw</summary>
        public const string MimeTypeSXW = "application/vnd.sun.xml.writer";

		///<summary>sxg</summary>
        public const string MimeTypeSXG = "application/vnd.sun.xml.writer.global";

		///<summary>stw</summary>
        public const string MimeTypeSTW = "application/vnd.sun.xml.writer.template";

		///<summary>sus</summary>
        public const string MimeTypeSUS = "application/vnd.sus-calendar";

		///<summary>susp</summary>
        public const string MimeTypeSUSP = "application/vnd.sus-calendar";

		///<summary>svd</summary>
        public const string MimeTypeSVD = "application/vnd.svd";

		///<summary>sis</summary>
        public const string MimeTypeSIS = "application/vnd.symbian.install";

		///<summary>sisx</summary>
        public const string MimeTypeSISX = "application/vnd.symbian.install";

		///<summary>xsm</summary>
        public const string MimeTypeXSM = "application/vnd.syncml+xml";

		///<summary>bdm</summary>
        public const string MimeTypeBDM = "application/vnd.syncml.dm+wbxml";

		///<summary>xdm</summary>
        public const string MimeTypeXDM = "application/vnd.syncml.dm+xml";

		///<summary>tao</summary>
        public const string MimeTypeTAO = "application/vnd.tao.intent-module-archive";

		///<summary>pcap</summary>
        public const string MimeTypePCAP = "application/vnd.tcpdump.pcap";

		///<summary>cap</summary>
        public const string MimeTypeCAP = "application/vnd.tcpdump.pcap";

		///<summary>dmp</summary>
        public const string MimeTypeDMP = "application/vnd.tcpdump.pcap";

		///<summary>tmo</summary>
        public const string MimeTypeTMO = "application/vnd.tmobile-livetv";

		///<summary>tpt</summary>
        public const string MimeTypeTPT = "application/vnd.trid.tpt";

		///<summary>mxs</summary>
        public const string MimeTypeMXS = "application/vnd.triscape.mxs";

		///<summary>tra</summary>
        public const string MimeTypeTRA = "application/vnd.trueapp";

		///<summary>ufd</summary>
        public const string MimeTypeUFD = "application/vnd.ufdl";

		///<summary>ufdl</summary>
        public const string MimeTypeUFDL = "application/vnd.ufdl";

		///<summary>utz</summary>
        public const string MimeTypeUTZ = "application/vnd.uiq.theme";

		///<summary>umj</summary>
        public const string MimeTypeUMJ = "application/vnd.umajin";

		///<summary>unityweb</summary>
        public const string MimeTypeUNITYWEB = "application/vnd.unity";

		///<summary>uoml</summary>
        public const string MimeTypeUOML = "application/vnd.uoml+xml";

		///<summary>vcx</summary>
        public const string MimeTypeVCX = "application/vnd.vcx";

		///<summary>vsd</summary>
        public const string MimeTypeVSD = "application/vnd.visio";

		///<summary>vst</summary>
        public const string MimeTypeVST = "application/vnd.visio";

		///<summary>vss</summary>
        public const string MimeTypeVSS = "application/vnd.visio";

		///<summary>vsw</summary>
        public const string MimeTypeVSW = "application/vnd.visio";

		///<summary>vis</summary>
        public const string MimeTypeVIS = "application/vnd.visionary";

		///<summary>vsf</summary>
        public const string MimeTypeVSF = "application/vnd.vsf";

		///<summary>wbxml</summary>
        public const string MimeTypeWBXML = "application/vnd.wap.wbxml";

		///<summary>wmlc</summary>
        public const string MimeTypeWMLC = "application/vnd.wap.wmlc";

		///<summary>wmlsc</summary>
        public const string MimeTypeWMLSC = "application/vnd.wap.wmlscriptc";

		///<summary>wtb</summary>
        public const string MimeTypeWTB = "application/vnd.webturbo";

		///<summary>nbp</summary>
        public const string MimeTypeNBP = "application/vnd.wolfram.player";

		///<summary>wpd</summary>
        public const string MimeTypeWPD = "application/vnd.wordperfect";

		///<summary>wqd</summary>
        public const string MimeTypeWQD = "application/vnd.wqd";

		///<summary>stf</summary>
        public const string MimeTypeSTF = "application/vnd.wt.stf";

		///<summary>xar</summary>
        public const string MimeTypeXAR = "application/vnd.xara";

		///<summary>xfdl</summary>
        public const string MimeTypeXFDL = "application/vnd.xfdl";

		///<summary>hvd</summary>
        public const string MimeTypeHVD = "application/vnd.yamaha.hv-dic";

		///<summary>hvs</summary>
        public const string MimeTypeHVS = "application/vnd.yamaha.hv-script";

		///<summary>hvp</summary>
        public const string MimeTypeHVP = "application/vnd.yamaha.hv-voice";

		///<summary>osf</summary>
        public const string MimeTypeOSF = "application/vnd.yamaha.openscoreformat";

		///<summary>osfpvg</summary>
        public const string MimeTypeOSFPVG = "application/vnd.yamaha.openscoreformat.osfpvg+xml";

		///<summary>saf</summary>
        public const string MimeTypeSAF = "application/vnd.yamaha.smaf-audio";

		///<summary>spf</summary>
        public const string MimeTypeSPF = "application/vnd.yamaha.smaf-phrase";

		///<summary>cmp</summary>
        public const string MimeTypeCMP = "application/vnd.yellowriver-custom-menu";

		///<summary>zir</summary>
        public const string MimeTypeZIR = "application/vnd.zul";

		///<summary>zirz</summary>
        public const string MimeTypeZIRZ = "application/vnd.zul";

		///<summary>zaz</summary>
        public const string MimeTypeZAZ = "application/vnd.zzazz.deck+xml";

		///<summary>vxml</summary>
        public const string MimeTypeVXML = "application/voicexml+xml";

		///<summary>wgt</summary>
        public const string MimeTypeWGT = "application/widget";

		///<summary>hlp</summary>
        public const string MimeTypeHLP = "application/winhlp";

		///<summary>wsdl</summary>
        public const string MimeTypeWSDL = "application/wsdl+xml";

		///<summary>wspolicy</summary>
        public const string MimeTypeWSPOLICY = "application/wspolicy+xml";

		///<summary>7z</summary>
        public const string MimeType7Z = "application/x-7z-compressed";

		///<summary>abw</summary>
        public const string MimeTypeABW = "application/x-abiword";

		///<summary>ace</summary>
        public const string MimeTypeACE = "application/x-ace-compressed";

		///<summary>dmg</summary>
        public const string MimeTypeDMG = "application/x-apple-diskimage";

		///<summary>aab</summary>
        public const string MimeTypeAAB = "application/x-authorware-bin";

		///<summary>x32</summary>
        public const string MimeTypeX32 = "application/x-authorware-bin";

		///<summary>u32</summary>
        public const string MimeTypeU32 = "application/x-authorware-bin";

		///<summary>vox</summary>
        public const string MimeTypeVOX = "application/x-authorware-bin";

		///<summary>aam</summary>
        public const string MimeTypeAAM = "application/x-authorware-map";

		///<summary>aas</summary>
        public const string MimeTypeAAS = "application/x-authorware-seg";

		///<summary>bcpio</summary>
        public const string MimeTypeBCPIO = "application/x-bcpio";

		///<summary>torrent</summary>
        public const string MimeTypeTORRENT = "application/x-bittorrent";

		///<summary>blb</summary>
        public const string MimeTypeBLB = "application/x-blorb";

		///<summary>blorb</summary>
        public const string MimeTypeBLORB = "application/x-blorb";

		///<summary>bz</summary>
        public const string MimeTypeBZ = "application/x-bzip";

		///<summary>bz2</summary>
        public const string MimeTypeBZ2 = "application/x-bzip2";

		///<summary>boz</summary>
        public const string MimeTypeBOZ = "application/x-bzip2";

		///<summary>cbr</summary>
        public const string MimeTypeCBR = "application/x-cbr";

		///<summary>cba</summary>
        public const string MimeTypeCBA = "application/x-cbr";

		///<summary>cbt</summary>
        public const string MimeTypeCBT = "application/x-cbr";

		///<summary>cbz</summary>
        public const string MimeTypeCBZ = "application/x-cbr";

		///<summary>cb7</summary>
        public const string MimeTypeCB7 = "application/x-cbr";

		///<summary>vcd</summary>
        public const string MimeTypeVCD = "application/x-cdlink";

		///<summary>cfs</summary>
        public const string MimeTypeCFS = "application/x-cfs-compressed";

		///<summary>chat</summary>
        public const string MimeTypeCHAT = "application/x-chat";

		///<summary>pgn</summary>
        public const string MimeTypePGN = "application/x-chess-pgn";

		///<summary>nsc</summary>
        public const string MimeTypeNSC = "application/x-conference";

		///<summary>cpio</summary>
        public const string MimeTypeCPIO = "application/x-cpio";

		///<summary>csh</summary>
        public const string MimeTypeCSH = "application/x-csh";

		///<summary>deb</summary>
        public const string MimeTypeDEB = "application/x-debian-package";

		///<summary>udeb</summary>
        public const string MimeTypeUDEB = "application/x-debian-package";

		///<summary>dgc</summary>
        public const string MimeTypeDGC = "application/x-dgc-compressed";

		///<summary>dir</summary>
        public const string MimeTypeDIR = "application/x-director";

		///<summary>dcr</summary>
        public const string MimeTypeDCR = "application/x-director";

		///<summary>dxr</summary>
        public const string MimeTypeDXR = "application/x-director";

		///<summary>cst</summary>
        public const string MimeTypeCST = "application/x-director";

		///<summary>cct</summary>
        public const string MimeTypeCCT = "application/x-director";

		///<summary>cxt</summary>
        public const string MimeTypeCXT = "application/x-director";

		///<summary>w3d</summary>
        public const string MimeTypeW3D = "application/x-director";

		///<summary>fgd</summary>
        public const string MimeTypeFGD = "application/x-director";

		///<summary>swa</summary>
        public const string MimeTypeSWA = "application/x-director";

		///<summary>wad</summary>
        public const string MimeTypeWAD = "application/x-doom";

		///<summary>ncx</summary>
        public const string MimeTypeNCX = "application/x-dtbncx+xml";

		///<summary>dtb</summary>
        public const string MimeTypeDTB = "application/x-dtbook+xml";

		///<summary>res</summary>
        public const string MimeTypeRES = "application/x-dtbresource+xml";

		///<summary>dvi</summary>
        public const string MimeTypeDVI = "application/x-dvi";

		///<summary>evy</summary>
        public const string MimeTypeEVY = "application/x-envoy";

		///<summary>eva</summary>
        public const string MimeTypeEVA = "application/x-eva";

		///<summary>bdf</summary>
        public const string MimeTypeBDF = "application/x-font-bdf";

		///<summary>gsf</summary>
        public const string MimeTypeGSF = "application/x-font-ghostscript";

		///<summary>psf</summary>
        public const string MimeTypePSF = "application/x-font-linux-psf";

		///<summary>otf</summary>
        public const string MimeTypeOTF = "application/x-font-otf";

		///<summary>pcf</summary>
        public const string MimeTypePCF = "application/x-font-pcf";

		///<summary>snf</summary>
        public const string MimeTypeSNF = "application/x-font-snf";

		///<summary>ttf</summary>
        public const string MimeTypeTTF = "application/x-font-ttf";

		///<summary>ttc</summary>
        public const string MimeTypeTTC = "application/x-font-ttf";

		///<summary>pfa</summary>
        public const string MimeTypePFA = "application/x-font-type1";

		///<summary>pfb</summary>
        public const string MimeTypePFB = "application/x-font-type1";

		///<summary>pfm</summary>
        public const string MimeTypePFM = "application/x-font-type1";

		///<summary>afm</summary>
        public const string MimeTypeAFM = "application/x-font-type1";

		///<summary>arc</summary>
        public const string MimeTypeARC = "application/x-freearc";

		///<summary>spl</summary>
        public const string MimeTypeSPL = "application/x-futuresplash";

		///<summary>gca</summary>
        public const string MimeTypeGCA = "application/x-gca-compressed";

		///<summary>ulx</summary>
        public const string MimeTypeULX = "application/x-glulx";

		///<summary>gnumeric</summary>
        public const string MimeTypeGNUMERIC = "application/x-gnumeric";

		///<summary>gramps</summary>
        public const string MimeTypeGRAMPS = "application/x-gramps-xml";

		///<summary>gtar</summary>
        public const string MimeTypeGTAR = "application/x-gtar";

		///<summary>hdf</summary>
        public const string MimeTypeHDF = "application/x-hdf";

		///<summary>install</summary>
        public const string MimeTypeINSTALL = "application/x-install-instructions";

		///<summary>iso</summary>
        public const string MimeTypeISO = "application/x-iso9660-image";

		///<summary>jnlp</summary>
        public const string MimeTypeJNLP = "application/x-java-jnlp-file";

		///<summary>latex</summary>
        public const string MimeTypeLATEX = "application/x-latex";

		///<summary>lzh</summary>
        public const string MimeTypeLZH = "application/x-lzh-compressed";

		///<summary>lha</summary>
        public const string MimeTypeLHA = "application/x-lzh-compressed";

		///<summary>mie</summary>
        public const string MimeTypeMIE = "application/x-mie";

		///<summary>prc</summary>
        public const string MimeTypePRC = "application/x-mobipocket-ebook";

		///<summary>mobi</summary>
        public const string MimeTypeMOBI = "application/x-mobipocket-ebook";

		///<summary>application</summary>
        public const string MimeTypeAPPLICATION = "application/x-ms-application";

		///<summary>lnk</summary>
        public const string MimeTypeLNK = "application/x-ms-shortcut";

		///<summary>wmd</summary>
        public const string MimeTypeWMD = "application/x-ms-wmd";

		///<summary>wmz</summary>
        public const string MimeTypeWMZ = "application/x-ms-wmz";

		///<summary>xbap</summary>
        public const string MimeTypeXBAP = "application/x-ms-xbap";

		///<summary>mdb</summary>
        public const string MimeTypeMDB = "application/x-msaccess";

		///<summary>obd</summary>
        public const string MimeTypeOBD = "application/x-msbinder";

		///<summary>crd</summary>
        public const string MimeTypeCRD = "application/x-mscardfile";

		///<summary>clp</summary>
        public const string MimeTypeCLP = "application/x-msclip";

		///<summary>exe</summary>
        public const string MimeTypeEXE = "application/x-msdownload";

		///<summary>dll</summary>
        public const string MimeTypeDLL = "application/x-msdownload";

		///<summary>com</summary>
        public const string MimeTypeCOM = "application/x-msdownload";

		///<summary>bat</summary>
        public const string MimeTypeBAT = "application/x-msdownload";

		///<summary>msi</summary>
        public const string MimeTypeMSI = "application/x-msdownload";

		///<summary>mvb</summary>
        public const string MimeTypeMVB = "application/x-msmediaview";

		///<summary>m13</summary>
        public const string MimeTypeM13 = "application/x-msmediaview";

		///<summary>m14</summary>
        public const string MimeTypeM14 = "application/x-msmediaview";

		///<summary>wmf</summary>
        public const string MimeTypeWMF = "application/x-msmetafile";

		///<summary>emf</summary>
        public const string MimeTypeEMF = "application/x-msmetafile";

		///<summary>emz</summary>
        public const string MimeTypeEMZ = "application/x-msmetafile";

		///<summary>mny</summary>
        public const string MimeTypeMNY = "application/x-msmoney";

		///<summary>pub</summary>
        public const string MimeTypePUB = "application/x-mspublisher";

		///<summary>scd</summary>
        public const string MimeTypeSCD = "application/x-msschedule";

		///<summary>trm</summary>
        public const string MimeTypeTRM = "application/x-msterminal";

		///<summary>wri</summary>
        public const string MimeTypeWRI = "application/x-mswrite";

		///<summary>nc</summary>
        public const string MimeTypeNC = "application/x-netcdf";

		///<summary>cdf</summary>
        public const string MimeTypeCDF = "application/x-netcdf";

		///<summary>nzb</summary>
        public const string MimeTypeNZB = "application/x-nzb";

		///<summary>p12</summary>
        public const string MimeTypeP12 = "application/x-pkcs12";

		///<summary>pfx</summary>
        public const string MimeTypePFX = "application/x-pkcs12";

		///<summary>p7b</summary>
        public const string MimeTypeP7B = "application/x-pkcs7-certificates";

		///<summary>spc</summary>
        public const string MimeTypeSPC = "application/x-pkcs7-certificates";

		///<summary>p7r</summary>
        public const string MimeTypeP7R = "application/x-pkcs7-certreqresp";

		///<summary>rar</summary>
        public const string MimeTypeRAR = "application/x-rar-compressed";

		///<summary>ris</summary>
        public const string MimeTypeRIS = "application/x-research-info-systems";

		///<summary>sh</summary>
        public const string MimeTypeSH = "application/x-sh";

		///<summary>shar</summary>
        public const string MimeTypeSHAR = "application/x-shar";

		///<summary>swf</summary>
        public const string MimeTypeSWF = "application/x-shockwave-flash";

		///<summary>xap</summary>
        public const string MimeTypeXAP = "application/x-silverlight-app";

		///<summary>sql</summary>
        public const string MimeTypeSQL = "application/x-sql";

		///<summary>sit</summary>
        public const string MimeTypeSIT = "application/x-stuffit";

		///<summary>sitx</summary>
        public const string MimeTypeSITX = "application/x-stuffitx";

		///<summary>srt</summary>
        public const string MimeTypeSRT = "application/x-subrip";

		///<summary>sv4cpio</summary>
        public const string MimeTypeSV4CPIO = "application/x-sv4cpio";

		///<summary>sv4crc</summary>
        public const string MimeTypeSV4CRC = "application/x-sv4crc";

		///<summary>t3</summary>
        public const string MimeTypeT3 = "application/x-t3vm-image";

		///<summary>gam</summary>
        public const string MimeTypeGAM = "application/x-tads";

		///<summary>tar</summary>
        public const string MimeTypeTAR = "application/x-tar";

		///<summary>tcl</summary>
        public const string MimeTypeTCL = "application/x-tcl";

		///<summary>tex</summary>
        public const string MimeTypeTEX = "application/x-tex";

		///<summary>tfm</summary>
        public const string MimeTypeTFM = "application/x-tex-tfm";

		///<summary>texinfo</summary>
        public const string MimeTypeTEXINFO = "application/x-texinfo";

		///<summary>texi</summary>
        public const string MimeTypeTEXI = "application/x-texinfo";

		///<summary>obj</summary>
        public const string MimeTypeOBJ = "application/x-tgif";

		///<summary>ustar</summary>
        public const string MimeTypeUSTAR = "application/x-ustar";

		///<summary>src</summary>
        public const string MimeTypeSRC = "application/x-wais-source";

		///<summary>der</summary>
        public const string MimeTypeDER = "application/x-x509-ca-cert";

		///<summary>crt</summary>
        public const string MimeTypeCRT = "application/x-x509-ca-cert";

		///<summary>fig</summary>
        public const string MimeTypeFIG = "application/x-xfig";

		///<summary>xlf</summary>
        public const string MimeTypeXLF = "application/x-xliff+xml";

		///<summary>xpi</summary>
        public const string MimeTypeXPI = "application/x-xpinstall";

		///<summary>xz</summary>
        public const string MimeTypeXZ = "application/x-xz";

		///<summary>z1</summary>
        public const string MimeTypeZ1 = "application/x-zmachine";

		///<summary>z2</summary>
        public const string MimeTypeZ2 = "application/x-zmachine";

		///<summary>z3</summary>
        public const string MimeTypeZ3 = "application/x-zmachine";

		///<summary>z4</summary>
        public const string MimeTypeZ4 = "application/x-zmachine";

		///<summary>z5</summary>
        public const string MimeTypeZ5 = "application/x-zmachine";

		///<summary>z6</summary>
        public const string MimeTypeZ6 = "application/x-zmachine";

		///<summary>z7</summary>
        public const string MimeTypeZ7 = "application/x-zmachine";

		///<summary>z8</summary>
        public const string MimeTypeZ8 = "application/x-zmachine";

		///<summary>xaml</summary>
        public const string MimeTypeXAML = "application/xaml+xml";

		///<summary>xdf</summary>
        public const string MimeTypeXDF = "application/xcap-diff+xml";

		///<summary>xenc</summary>
        public const string MimeTypeXENC = "application/xenc+xml";

		///<summary>xhtml</summary>
        public const string MimeTypeXHTML = "application/xhtml+xml";

		///<summary>xht</summary>
        public const string MimeTypeXHT = "application/xhtml+xml";

		///<summary>xml</summary>
        public const string MimeTypeXML = "application/xml";

		///<summary>xsl</summary>
        public const string MimeTypeXSL = "application/xml";

		///<summary>dtd</summary>
        public const string MimeTypeDTD = "application/xml-dtd";

		///<summary>xop</summary>
        public const string MimeTypeXOP = "application/xop+xml";

		///<summary>xpl</summary>
        public const string MimeTypeXPL = "application/xproc+xml";

		///<summary>xslt</summary>
        public const string MimeTypeXSLT = "application/xslt+xml";

		///<summary>xspf</summary>
        public const string MimeTypeXSPF = "application/xspf+xml";

		///<summary>mxml</summary>
        public const string MimeTypeMXML = "application/xv+xml";

		///<summary>xhvml</summary>
        public const string MimeTypeXHVML = "application/xv+xml";

		///<summary>xvml</summary>
        public const string MimeTypeXVML = "application/xv+xml";

		///<summary>xvm</summary>
        public const string MimeTypeXVM = "application/xv+xml";

		///<summary>yang</summary>
        public const string MimeTypeYANG = "application/yang";

		///<summary>yin</summary>
        public const string MimeTypeYIN = "application/yin+xml";

		///<summary>zip</summary>
        public const string MimeTypeZIP = "application/zip";

		///<summary>adp</summary>
        public const string MimeTypeADP = "audio/adpcm";

		///<summary>au</summary>
        public const string MimeTypeAU = "audio/basic";

		///<summary>snd</summary>
        public const string MimeTypeSND = "audio/basic";

		///<summary>mid</summary>
        public const string MimeTypeMID = "audio/midi";

		///<summary>midi</summary>
        public const string MimeTypeMIDI = "audio/midi";

		///<summary>kar</summary>
        public const string MimeTypeKAR = "audio/midi";

		///<summary>rmi</summary>
        public const string MimeTypeRMI = "audio/midi";

		///<summary>m4a</summary>
        public const string MimeTypeM4A = "audio/mp4";

		///<summary>mp4a</summary>
        public const string MimeTypeMP4A = "audio/mp4";

		///<summary>mpga</summary>
        public const string MimeTypeMPGA = "audio/mpeg";

		///<summary>mp2</summary>
        public const string MimeTypeMP2 = "audio/mpeg";

		///<summary>mp2a</summary>
        public const string MimeTypeMP2A = "audio/mpeg";

		///<summary>mp3</summary>
        public const string MimeTypeMP3 = "audio/mpeg";

		///<summary>m2a</summary>
        public const string MimeTypeM2A = "audio/mpeg";

		///<summary>m3a</summary>
        public const string MimeTypeM3A = "audio/mpeg";

		///<summary>oga</summary>
        public const string MimeTypeOGA = "audio/ogg";

		///<summary>ogg</summary>
        public const string MimeTypeOGG = "audio/ogg";

		///<summary>spx</summary>
        public const string MimeTypeSPX = "audio/ogg";

		///<summary>s3m</summary>
        public const string MimeTypeS3M = "audio/s3m";

		///<summary>sil</summary>
        public const string MimeTypeSIL = "audio/silk";

		///<summary>uva</summary>
        public const string MimeTypeUVA = "audio/vnd.dece.audio";

		///<summary>uvva</summary>
        public const string MimeTypeUVVA = "audio/vnd.dece.audio";

		///<summary>eol</summary>
        public const string MimeTypeEOL = "audio/vnd.digital-winds";

		///<summary>dra</summary>
        public const string MimeTypeDRA = "audio/vnd.dra";

		///<summary>dts</summary>
        public const string MimeTypeDTS = "audio/vnd.dts";

		///<summary>dtshd</summary>
        public const string MimeTypeDTSHD = "audio/vnd.dts.hd";

		///<summary>lvp</summary>
        public const string MimeTypeLVP = "audio/vnd.lucent.voice";

		///<summary>pya</summary>
        public const string MimeTypePYA = "audio/vnd.ms-playready.media.pya";

		///<summary>ecelp4800</summary>
        public const string MimeTypeECELP4800 = "audio/vnd.nuera.ecelp4800";

		///<summary>ecelp7470</summary>
        public const string MimeTypeECELP7470 = "audio/vnd.nuera.ecelp7470";

		///<summary>ecelp9600</summary>
        public const string MimeTypeECELP9600 = "audio/vnd.nuera.ecelp9600";

		///<summary>rip</summary>
        public const string MimeTypeRIP = "audio/vnd.rip";

		///<summary>weba</summary>
        public const string MimeTypeWEBA = "audio/webm";

		///<summary>aac</summary>
        public const string MimeTypeAAC = "audio/x-aac";

		///<summary>aif</summary>
        public const string MimeTypeAIF = "audio/x-aiff";

		///<summary>aiff</summary>
        public const string MimeTypeAIFF = "audio/x-aiff";

		///<summary>aifc</summary>
        public const string MimeTypeAIFC = "audio/x-aiff";

		///<summary>caf</summary>
        public const string MimeTypeCAF = "audio/x-caf";

		///<summary>flac</summary>
        public const string MimeTypeFLAC = "audio/x-flac";

		///<summary>mka</summary>
        public const string MimeTypeMKA = "audio/x-matroska";

		///<summary>m3u</summary>
        public const string MimeTypeM3U = "audio/x-mpegurl";

		///<summary>wax</summary>
        public const string MimeTypeWAX = "audio/x-ms-wax";

		///<summary>wma</summary>
        public const string MimeTypeWMA = "audio/x-ms-wma";

		///<summary>ram</summary>
        public const string MimeTypeRAM = "audio/x-pn-realaudio";

		///<summary>ra</summary>
        public const string MimeTypeRA = "audio/x-pn-realaudio";

		///<summary>rmp</summary>
        public const string MimeTypeRMP = "audio/x-pn-realaudio-plugin";

		///<summary>wav</summary>
        public const string MimeTypeWAV = "audio/x-wav";

		///<summary>xm</summary>
        public const string MimeTypeXM = "audio/xm";

		///<summary>cdx</summary>
        public const string MimeTypeCDX = "chemical/x-cdx";

		///<summary>cif</summary>
        public const string MimeTypeCIF = "chemical/x-cif";

		///<summary>cmdf</summary>
        public const string MimeTypeCMDF = "chemical/x-cmdf";

		///<summary>cml</summary>
        public const string MimeTypeCML = "chemical/x-cml";

		///<summary>csml</summary>
        public const string MimeTypeCSML = "chemical/x-csml";

		///<summary>xyz</summary>
        public const string MimeTypeXYZ = "chemical/x-xyz";

		///<summary>bmp</summary>
        public const string MimeTypeBMP = "image/bmp";

		///<summary>cgm</summary>
        public const string MimeTypeCGM = "image/cgm";

		///<summary>g3</summary>
        public const string MimeTypeG3 = "image/g3fax";

		///<summary>gif</summary>
        public const string MimeTypeGIF = "image/gif";

		///<summary>ief</summary>
        public const string MimeTypeIEF = "image/ief";

		///<summary>jpeg</summary>
        public const string MimeTypeJPEG = "image/jpeg";

		///<summary>jpg</summary>
        public const string MimeTypeJPG = "image/jpeg";

		///<summary>jpe</summary>
        public const string MimeTypeJPE = "image/jpeg";

		///<summary>ktx</summary>
        public const string MimeTypeKTX = "image/ktx";

		///<summary>png</summary>
        public const string MimeTypePNG = "image/png";

		///<summary>btif</summary>
        public const string MimeTypeBTIF = "image/prs.btif";

		///<summary>sgi</summary>
        public const string MimeTypeSGI = "image/sgi";

		///<summary>svg</summary>
        public const string MimeTypeSVG = "image/svg+xml";

		///<summary>svgz</summary>
        public const string MimeTypeSVGZ = "image/svg+xml";

		///<summary>tiff</summary>
        public const string MimeTypeTIFF = "image/tiff";

		///<summary>tif</summary>
        public const string MimeTypeTIF = "image/tiff";

		///<summary>psd</summary>
        public const string MimeTypePSD = "image/vnd.adobe.photoshop";

		///<summary>uvi</summary>
        public const string MimeTypeUVI = "image/vnd.dece.graphic";

		///<summary>uvvi</summary>
        public const string MimeTypeUVVI = "image/vnd.dece.graphic";

		///<summary>uvg</summary>
        public const string MimeTypeUVG = "image/vnd.dece.graphic";

		///<summary>uvvg</summary>
        public const string MimeTypeUVVG = "image/vnd.dece.graphic";

		///<summary>djvu</summary>
        public const string MimeTypeDJVU = "image/vnd.djvu";

		///<summary>djv</summary>
        public const string MimeTypeDJV = "image/vnd.djvu";

		///<summary>sub</summary>
        public const string MimeTypeSUB = "image/vnd.dvb.subtitle";

		///<summary>dwg</summary>
        public const string MimeTypeDWG = "image/vnd.dwg";

		///<summary>dxf</summary>
        public const string MimeTypeDXF = "image/vnd.dxf";

		///<summary>fbs</summary>
        public const string MimeTypeFBS = "image/vnd.fastbidsheet";

		///<summary>fpx</summary>
        public const string MimeTypeFPX = "image/vnd.fpx";

		///<summary>fst</summary>
        public const string MimeTypeFST = "image/vnd.fst";

		///<summary>mmr</summary>
        public const string MimeTypeMMR = "image/vnd.fujixerox.edmics-mmr";

		///<summary>rlc</summary>
        public const string MimeTypeRLC = "image/vnd.fujixerox.edmics-rlc";

		///<summary>mdi</summary>
        public const string MimeTypeMDI = "image/vnd.ms-modi";

		///<summary>wdp</summary>
        public const string MimeTypeWDP = "image/vnd.ms-photo";

		///<summary>npx</summary>
        public const string MimeTypeNPX = "image/vnd.net-fpx";

		///<summary>wbmp</summary>
        public const string MimeTypeWBMP = "image/vnd.wap.wbmp";

		///<summary>xif</summary>
        public const string MimeTypeXIF = "image/vnd.xiff";

		///<summary>webp</summary>
        public const string MimeTypeWEBP = "image/webp";

		///<summary>3ds</summary>
        public const string MimeType3DS = "image/x-3ds";

		///<summary>ras</summary>
        public const string MimeTypeRAS = "image/x-cmu-raster";

		///<summary>cmx</summary>
        public const string MimeTypeCMX = "image/x-cmx";

		///<summary>fh</summary>
        public const string MimeTypeFH = "image/x-freehand";

		///<summary>fhc</summary>
        public const string MimeTypeFHC = "image/x-freehand";

		///<summary>fh4</summary>
        public const string MimeTypeFH4 = "image/x-freehand";

		///<summary>fh5</summary>
        public const string MimeTypeFH5 = "image/x-freehand";

		///<summary>fh7</summary>
        public const string MimeTypeFH7 = "image/x-freehand";

		///<summary>ico</summary>
        public const string MimeTypeICO = "image/x-icon";

		///<summary>sid</summary>
        public const string MimeTypeSID = "image/x-mrsid-image";

		///<summary>pcx</summary>
        public const string MimeTypePCX = "image/x-pcx";

		///<summary>pic</summary>
        public const string MimeTypePIC = "image/x-pict";

		///<summary>pct</summary>
        public const string MimeTypePCT = "image/x-pict";

		///<summary>pnm</summary>
        public const string MimeTypePNM = "image/x-portable-anymap";

		///<summary>pbm</summary>
        public const string MimeTypePBM = "image/x-portable-bitmap";

		///<summary>pgm</summary>
        public const string MimeTypePGM = "image/x-portable-graymap";

		///<summary>ppm</summary>
        public const string MimeTypePPM = "image/x-portable-pixmap";

		///<summary>rgb</summary>
        public const string MimeTypeRGB = "image/x-rgb";

		///<summary>tga</summary>
        public const string MimeTypeTGA = "image/x-tga";

		///<summary>xbm</summary>
        public const string MimeTypeXBM = "image/x-xbitmap";

		///<summary>xpm</summary>
        public const string MimeTypeXPM = "image/x-xpixmap";

		///<summary>xwd</summary>
        public const string MimeTypeXWD = "image/x-xwindowdump";

		///<summary>eml</summary>
        public const string MimeTypeEML = "message/rfc822";

		///<summary>mime</summary>
        public const string MimeTypeMIME = "message/rfc822";

		///<summary>igs</summary>
        public const string MimeTypeIGS = "model/iges";

		///<summary>iges</summary>
        public const string MimeTypeIGES = "model/iges";

		///<summary>msh</summary>
        public const string MimeTypeMSH = "model/mesh";

		///<summary>mesh</summary>
        public const string MimeTypeMESH = "model/mesh";

		///<summary>silo</summary>
        public const string MimeTypeSILO = "model/mesh";

		///<summary>dae</summary>
        public const string MimeTypeDAE = "model/vnd.collada+xml";

		///<summary>dwf</summary>
        public const string MimeTypeDWF = "model/vnd.dwf";

		///<summary>gdl</summary>
        public const string MimeTypeGDL = "model/vnd.gdl";

		///<summary>gtw</summary>
        public const string MimeTypeGTW = "model/vnd.gtw";

		///<summary>mts</summary>
        public const string MimeTypeMTS = "model/vnd.mts";

		///<summary>vtu</summary>
        public const string MimeTypeVTU = "model/vnd.vtu";

		///<summary>wrl</summary>
        public const string MimeTypeWRL = "model/vrml";

		///<summary>vrml</summary>
        public const string MimeTypeVRML = "model/vrml";

		///<summary>x3db</summary>
        public const string MimeTypeX3DB = "model/x3d+binary";

		///<summary>x3dbz</summary>
        public const string MimeTypeX3DBZ = "model/x3d+binary";

		///<summary>x3dv</summary>
        public const string MimeTypeX3DV = "model/x3d+vrml";

		///<summary>x3dvz</summary>
        public const string MimeTypeX3DVZ = "model/x3d+vrml";

		///<summary>x3d</summary>
        public const string MimeTypeX3D = "model/x3d+xml";

		///<summary>x3dz</summary>
        public const string MimeTypeX3DZ = "model/x3d+xml";

		///<summary>appcache</summary>
        public const string MimeTypeAPPCACHE = "text/cache-manifest";

		///<summary>ics</summary>
        public const string MimeTypeICS = "text/calendar";

		///<summary>ifb</summary>
        public const string MimeTypeIFB = "text/calendar";

		///<summary>css</summary>
        public const string MimeTypeCSS = "text/css";

		///<summary>csv</summary>
        public const string MimeTypeCSV = "text/csv";

		///<summary>html</summary>
        public const string MimeTypeHTML = "text/html";

		///<summary>htm</summary>
        public const string MimeTypeHTM = "text/html";

		///<summary>n3</summary>
        public const string MimeTypeN3 = "text/n3";

		///<summary>txt</summary>
        public const string MimeTypeTXT = "text/plain";

		///<summary>text</summary>
        public const string MimeTypeTEXT = "text/plain";

		///<summary>conf</summary>
        public const string MimeTypeCONF = "text/plain";

		///<summary>def</summary>
        public const string MimeTypeDEF = "text/plain";

		///<summary>list</summary>
        public const string MimeTypeLIST = "text/plain";

		///<summary>log</summary>
        public const string MimeTypeLOG = "text/plain";

		///<summary>in</summary>
        public const string MimeTypeIN = "text/plain";

		///<summary>dsc</summary>
        public const string MimeTypeDSC = "text/prs.lines.tag";

		///<summary>rtx</summary>
        public const string MimeTypeRTX = "text/richtext";

		///<summary>sgml</summary>
        public const string MimeTypeSGML = "text/sgml";

		///<summary>sgm</summary>
        public const string MimeTypeSGM = "text/sgml";

		///<summary>tsv</summary>
        public const string MimeTypeTSV = "text/tab-separated-values";

		///<summary>t</summary>
        public const string MimeTypeT = "text/troff";

		///<summary>tr</summary>
        public const string MimeTypeTR = "text/troff";

		///<summary>roff</summary>
        public const string MimeTypeROFF = "text/troff";

		///<summary>man</summary>
        public const string MimeTypeMAN = "text/troff";

		///<summary>me</summary>
        public const string MimeTypeME = "text/troff";

		///<summary>ms</summary>
        public const string MimeTypeMS = "text/troff";

		///<summary>ttl</summary>
        public const string MimeTypeTTL = "text/turtle";

		///<summary>uri</summary>
        public const string MimeTypeURI = "text/uri-list";

		///<summary>uris</summary>
        public const string MimeTypeURIS = "text/uri-list";

		///<summary>urls</summary>
        public const string MimeTypeURLS = "text/uri-list";

		///<summary>vcard</summary>
        public const string MimeTypeVCARD = "text/vcard";

		///<summary>curl</summary>
        public const string MimeTypeCURL = "text/vnd.curl";

		///<summary>dcurl</summary>
        public const string MimeTypeDCURL = "text/vnd.curl.dcurl";

		///<summary>mcurl</summary>
        public const string MimeTypeMCURL = "text/vnd.curl.mcurl";

		///<summary>scurl</summary>
        public const string MimeTypeSCURL = "text/vnd.curl.scurl";

		///<summary>fly</summary>
        public const string MimeTypeFLY = "text/vnd.fly";

		///<summary>flx</summary>
        public const string MimeTypeFLX = "text/vnd.fmi.flexstor";

		///<summary>gv</summary>
        public const string MimeTypeGV = "text/vnd.graphviz";

		///<summary>3dml</summary>
        public const string MimeType3DML = "text/vnd.in3d.3dml";

		///<summary>spot</summary>
        public const string MimeTypeSPOT = "text/vnd.in3d.spot";

		///<summary>jad</summary>
        public const string MimeTypeJAD = "text/vnd.sun.j2me.app-descriptor";

		///<summary>wml</summary>
        public const string MimeTypeWML = "text/vnd.wap.wml";

		///<summary>wmls</summary>
        public const string MimeTypeWMLS = "text/vnd.wap.wmlscript";

		///<summary>s</summary>
        public const string MimeTypeS = "text/x-asm";

		///<summary>asm</summary>
        public const string MimeTypeASM = "text/x-asm";

		///<summary>c</summary>
        public const string MimeTypeC = "text/x-c";

		///<summary>cc</summary>
        public const string MimeTypeCC = "text/x-c";

		///<summary>cxx</summary>
        public const string MimeTypeCXX = "text/x-c";

		///<summary>cpp</summary>
        public const string MimeTypeCPP = "text/x-c";

		///<summary>h</summary>
        public const string MimeTypeH = "text/x-c";

		///<summary>hh</summary>
        public const string MimeTypeHH = "text/x-c";

		///<summary>dic</summary>
        public const string MimeTypeDIC = "text/x-c";

		///<summary>f</summary>
        public const string MimeTypeF = "text/x-fortran";

		///<summary>for</summary>
        public const string MimeTypeFOR = "text/x-fortran";

		///<summary>f77</summary>
        public const string MimeTypeF77 = "text/x-fortran";

		///<summary>f90</summary>
        public const string MimeTypeF90 = "text/x-fortran";

		///<summary>java</summary>
        public const string MimeTypeJAVA = "text/x-java-source";

		///<summary>nfo</summary>
        public const string MimeTypeNFO = "text/x-nfo";

		///<summary>opml</summary>
        public const string MimeTypeOPML = "text/x-opml";

		///<summary>p</summary>
        public const string MimeTypeP = "text/x-pascal";

		///<summary>pas</summary>
        public const string MimeTypePAS = "text/x-pascal";

		///<summary>etx</summary>
        public const string MimeTypeETX = "text/x-setext";

		///<summary>sfv</summary>
        public const string MimeTypeSFV = "text/x-sfv";

		///<summary>uu</summary>
        public const string MimeTypeUU = "text/x-uuencode";

		///<summary>vcs</summary>
        public const string MimeTypeVCS = "text/x-vcalendar";

		///<summary>vcf</summary>
        public const string MimeTypeVCF = "text/x-vcard";

		///<summary>3gp</summary>
        public const string MimeType3GP = "video/3gpp";

		///<summary>3g2</summary>
        public const string MimeType3G2 = "video/3gpp2";

		///<summary>h261</summary>
        public const string MimeTypeH261 = "video/h261";

		///<summary>h263</summary>
        public const string MimeTypeH263 = "video/h263";

		///<summary>h264</summary>
        public const string MimeTypeH264 = "video/h264";

		///<summary>jpgv</summary>
        public const string MimeTypeJPGV = "video/jpeg";

		///<summary>jpm</summary>
        public const string MimeTypeJPM = "video/jpm";

		///<summary>jpgm</summary>
        public const string MimeTypeJPGM = "video/jpm";

		///<summary>mj2</summary>
        public const string MimeTypeMJ2 = "video/mj2";

		///<summary>mjp2</summary>
        public const string MimeTypeMJP2 = "video/mj2";

		///<summary>mp4</summary>
        public const string MimeTypeMP4 = "video/mp4";

		///<summary>mp4v</summary>
        public const string MimeTypeMP4V = "video/mp4";

		///<summary>mpg4</summary>
        public const string MimeTypeMPG4 = "video/mp4";

		///<summary>mpeg</summary>
        public const string MimeTypeMPEG = "video/mpeg";

		///<summary>mpg</summary>
        public const string MimeTypeMPG = "video/mpeg";

		///<summary>mpe</summary>
        public const string MimeTypeMPE = "video/mpeg";

		///<summary>m1v</summary>
        public const string MimeTypeM1V = "video/mpeg";

		///<summary>m2v</summary>
        public const string MimeTypeM2V = "video/mpeg";

		///<summary>ogv</summary>
        public const string MimeTypeOGV = "video/ogg";

		///<summary>qt</summary>
        public const string MimeTypeQT = "video/quicktime";

		///<summary>mov</summary>
        public const string MimeTypeMOV = "video/quicktime";

		///<summary>uvh</summary>
        public const string MimeTypeUVH = "video/vnd.dece.hd";

		///<summary>uvvh</summary>
        public const string MimeTypeUVVH = "video/vnd.dece.hd";

		///<summary>uvm</summary>
        public const string MimeTypeUVM = "video/vnd.dece.mobile";

		///<summary>uvvm</summary>
        public const string MimeTypeUVVM = "video/vnd.dece.mobile";

		///<summary>uvp</summary>
        public const string MimeTypeUVP = "video/vnd.dece.pd";

		///<summary>uvvp</summary>
        public const string MimeTypeUVVP = "video/vnd.dece.pd";

		///<summary>uvs</summary>
        public const string MimeTypeUVS = "video/vnd.dece.sd";

		///<summary>uvvs</summary>
        public const string MimeTypeUVVS = "video/vnd.dece.sd";

		///<summary>uvv</summary>
        public const string MimeTypeUVV = "video/vnd.dece.video";

		///<summary>uvvv</summary>
        public const string MimeTypeUVVV = "video/vnd.dece.video";

		///<summary>dvb</summary>
        public const string MimeTypeDVB = "video/vnd.dvb.file";

		///<summary>fvt</summary>
        public const string MimeTypeFVT = "video/vnd.fvt";

		///<summary>mxu</summary>
        public const string MimeTypeMXU = "video/vnd.mpegurl";

		///<summary>m4u</summary>
        public const string MimeTypeM4U = "video/vnd.mpegurl";

		///<summary>pyv</summary>
        public const string MimeTypePYV = "video/vnd.ms-playready.media.pyv";

		///<summary>uvu</summary>
        public const string MimeTypeUVU = "video/vnd.uvvu.mp4";

		///<summary>uvvu</summary>
        public const string MimeTypeUVVU = "video/vnd.uvvu.mp4";

		///<summary>viv</summary>
        public const string MimeTypeVIV = "video/vnd.vivo";

		///<summary>webm</summary>
        public const string MimeTypeWEBM = "video/webm";

		///<summary>f4v</summary>
        public const string MimeTypeF4V = "video/x-f4v";

		///<summary>fli</summary>
        public const string MimeTypeFLI = "video/x-fli";

		///<summary>flv</summary>
        public const string MimeTypeFLV = "video/x-flv";

		///<summary>m4v</summary>
        public const string MimeTypeM4V = "video/x-m4v";

		///<summary>mkv</summary>
        public const string MimeTypeMKV = "video/x-matroska";

		///<summary>mk3d</summary>
        public const string MimeTypeMK3D = "video/x-matroska";

		///<summary>mks</summary>
        public const string MimeTypeMKS = "video/x-matroska";

		///<summary>mng</summary>
        public const string MimeTypeMNG = "video/x-mng";

		///<summary>asf</summary>
        public const string MimeTypeASF = "video/x-ms-asf";

		///<summary>asx</summary>
        public const string MimeTypeASX = "video/x-ms-asf";

		///<summary>vob</summary>
        public const string MimeTypeVOB = "video/x-ms-vob";

		///<summary>wm</summary>
        public const string MimeTypeWM = "video/x-ms-wm";

		///<summary>wmv</summary>
        public const string MimeTypeWMV = "video/x-ms-wmv";

		///<summary>wmx</summary>
        public const string MimeTypeWMX = "video/x-ms-wmx";

		///<summary>wvx</summary>
        public const string MimeTypeWVX = "video/x-ms-wvx";

		///<summary>avi</summary>
        public const string MimeTypeAVI = "video/x-msvideo";

		///<summary>movie</summary>
        public const string MimeTypeMOVIE = "video/x-sgi-movie";

		///<summary>smv</summary>
        public const string MimeTypeSMV = "video/x-smv";

		///<summary>ice</summary>
        public const string MimeTypeICE = "x-conference/x-cooltalk";

		///<summary>map</summary>
        public const string MimeTypeMAP = "application/json";

		///<summary>topojson</summary>
        public const string MimeTypeTOPOJSON = "application/json";

		///<summary>jsonld</summary>
        public const string MimeTypeJSONLD = "application/ld+json";

		///<summary>geojson</summary>
        public const string MimeTypeGEOJSON = "application/vnd.geo+json";

		///<summary>webmanifest</summary>
        public const string MimeTypeWEBMANIFEST = "application/manifest+json";

		///<summary>webapp</summary>
        public const string MimeTypeWEBAPP = "application/x-web-app-manifest+json";

		///<summary>f4a</summary>
        public const string MimeTypeF4A = "audio/mp4";

		///<summary>f4b</summary>
        public const string MimeTypeF4B = "audio/mp4";

		///<summary>opus</summary>
        public const string MimeTypeOPUS = "audio/ogg";

		///<summary>jxr</summary>
        public const string MimeTypeJXR = "image/jxr";

		///<summary>hdp</summary>
        public const string MimeTypeHDP = "image/jxr";

		///<summary>jng</summary>
        public const string MimeTypeJNG = "image/x-jng";

		///<summary>3gpp</summary>
        public const string MimeType3GPP = "video/3gpp";

		///<summary>f4p</summary>
        public const string MimeTypeF4P = "video/mp4";

		///<summary>cur</summary>
        public const string MimeTypeCUR = "image/x-icon";

		///<summary>woff2</summary>
        public const string MimeTypeWOFF2 = "application/font-woff2";

		///<summary>ear</summary>
        public const string MimeTypeEAR = "application/java-archive";

		///<summary>war</summary>
        public const string MimeTypeWAR = "application/java-archive";

		///<summary>img</summary>
        public const string MimeTypeIMG = "application/octet-stream";

		///<summary>msm</summary>
        public const string MimeTypeMSM = "application/octet-stream";

		///<summary>msp</summary>
        public const string MimeTypeMSP = "application/octet-stream";

		///<summary>safariextz</summary>
        public const string MimeTypeSAFARIEXTZ = "application/octet-stream";

		///<summary>bbaw</summary>
        public const string MimeTypeBBAW = "application/x-bb-appworld";

		///<summary>crx</summary>
        public const string MimeTypeCRX = "application/x-chrome-extension";

		///<summary>cco</summary>
        public const string MimeTypeCCO = "application/x-cocoa";

		///<summary>jardiff</summary>
        public const string MimeTypeJARDIFF = "application/x-java-archive-diff";

		///<summary>run</summary>
        public const string MimeTypeRUN = "application/x-makeself";

		///<summary>oex</summary>
        public const string MimeTypeOEX = "application/x-opera-extension";

		///<summary>pl</summary>
        public const string MimeTypePL = "application/x-perl";

		///<summary>pm</summary>
        public const string MimeTypePM = "application/x-perl";

		///<summary>rpm</summary>
        public const string MimeTypeRPM = "application/x-redhat-package-manager";

		///<summary>sea</summary>
        public const string MimeTypeSEA = "application/x-sea";

		///<summary>tk</summary>
        public const string MimeTypeTK = "application/x-tcl";

		///<summary>pem</summary>
        public const string MimeTypePEM = "application/x-x509-ca-cert";

		///<summary>shtml</summary>
        public const string MimeTypeSHTML = "text/html";

		///<summary>md</summary>
        public const string MimeTypeMD = "text/markdown";

		///<summary>mml</summary>
        public const string MimeTypeMML = "text/mathml";

		///<summary>xloc</summary>
        public const string MimeTypeXLOC = "text/vnd.rim.location.xloc";

		///<summary>vtt</summary>
        public const string MimeTypeVTT = "text/vtt";

		///<summary>htc</summary>
        public const string MimeTypeHTC = "text/x-component";


        // List of all available extensions, used to build the dictionary
        static readonly Lazy<string[]> ALL_EXTS = new Lazy<string[]>(() => new [] {
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
            "jxr",
            "hdp",
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
            "md",
            "mml",
            "xloc",
            "vtt",
            "htc",
        });

        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        static string LookupType(string type)
        {
            switch (type)
            {

				case "ez":
					return MimeTypeEZ;
				case "aw":
					return MimeTypeAW;
				case "atom":
					return MimeTypeATOM;
				case "atomcat":
					return MimeTypeATOMCAT;
				case "atomsvc":
					return MimeTypeATOMSVC;
				case "ccxml":
					return MimeTypeCCXML;
				case "cdmia":
					return MimeTypeCDMIA;
				case "cdmic":
					return MimeTypeCDMIC;
				case "cdmid":
					return MimeTypeCDMID;
				case "cdmio":
					return MimeTypeCDMIO;
				case "cdmiq":
					return MimeTypeCDMIQ;
				case "cu":
					return MimeTypeCU;
				case "davmount":
					return MimeTypeDAVMOUNT;
				case "dbk":
					return MimeTypeDBK;
				case "dssc":
					return MimeTypeDSSC;
				case "xdssc":
					return MimeTypeXDSSC;
				case "ecma":
					return MimeTypeECMA;
				case "emma":
					return MimeTypeEMMA;
				case "epub":
					return MimeTypeEPUB;
				case "exi":
					return MimeTypeEXI;
				case "pfr":
					return MimeTypePFR;
				case "woff":
					return MimeTypeWOFF;
				case "gml":
					return MimeTypeGML;
				case "gpx":
					return MimeTypeGPX;
				case "gxf":
					return MimeTypeGXF;
				case "stk":
					return MimeTypeSTK;
				case "ink":
				case "inkml":
					return MimeTypeINK;
				case "ipfix":
					return MimeTypeIPFIX;
				case "jar":
				case "ear":
				case "war":
					return MimeTypeJAR;
				case "ser":
					return MimeTypeSER;
				case "class":
					return MimeTypeCLASS;
				case "js":
					return MimeTypeJS;
				case "json":
				case "map":
				case "topojson":
					return MimeTypeJSON;
				case "jsonml":
					return MimeTypeJSONML;
				case "lostxml":
					return MimeTypeLOSTXML;
				case "hqx":
					return MimeTypeHQX;
				case "cpt":
					return MimeTypeCPT;
				case "mads":
					return MimeTypeMADS;
				case "mrc":
					return MimeTypeMRC;
				case "mrcx":
					return MimeTypeMRCX;
				case "ma":
				case "nb":
				case "mb":
					return MimeTypeMA;
				case "mathml":
					return MimeTypeMATHML;
				case "mbox":
					return MimeTypeMBOX;
				case "mscml":
					return MimeTypeMSCML;
				case "metalink":
					return MimeTypeMETALINK;
				case "meta4":
					return MimeTypeMETA4;
				case "mets":
					return MimeTypeMETS;
				case "mods":
					return MimeTypeMODS;
				case "m21":
				case "mp21":
					return MimeTypeM21;
				case "mp4s":
					return MimeTypeMP4S;
				case "doc":
				case "dot":
					return MimeTypeDOC;
				case "mxf":
					return MimeTypeMXF;
				case "bin":
				case "dms":
				case "lrf":
				case "mar":
				case "so":
				case "dist":
				case "distz":
				case "pkg":
				case "bpk":
				case "dump":
				case "elc":
				case "deploy":
				case "img":
				case "msm":
				case "msp":
				case "safariextz":
					return MimeTypeBIN;
				case "oda":
					return MimeTypeODA;
				case "opf":
					return MimeTypeOPF;
				case "ogx":
					return MimeTypeOGX;
				case "omdoc":
					return MimeTypeOMDOC;
				case "onetoc":
				case "onetoc2":
				case "onetmp":
				case "onepkg":
					return MimeTypeONETOC;
				case "oxps":
					return MimeTypeOXPS;
				case "xer":
					return MimeTypeXER;
				case "pdf":
					return MimeTypePDF;
				case "pgp":
					return MimeTypePGP;
				case "asc":
				case "sig":
					return MimeTypeASC;
				case "prf":
					return MimeTypePRF;
				case "p10":
					return MimeTypeP10;
				case "p7m":
				case "p7c":
					return MimeTypeP7M;
				case "p7s":
					return MimeTypeP7S;
				case "p8":
					return MimeTypeP8;
				case "ac":
					return MimeTypeAC;
				case "cer":
					return MimeTypeCER;
				case "crl":
					return MimeTypeCRL;
				case "pkipath":
					return MimeTypePKIPATH;
				case "pki":
					return MimeTypePKI;
				case "pls":
					return MimeTypePLS;
				case "ai":
				case "eps":
				case "ps":
					return MimeTypeAI;
				case "cww":
					return MimeTypeCWW;
				case "pskcxml":
					return MimeTypePSKCXML;
				case "rdf":
					return MimeTypeRDF;
				case "rif":
					return MimeTypeRIF;
				case "rnc":
					return MimeTypeRNC;
				case "rl":
					return MimeTypeRL;
				case "rld":
					return MimeTypeRLD;
				case "rs":
					return MimeTypeRS;
				case "gbr":
					return MimeTypeGBR;
				case "mft":
					return MimeTypeMFT;
				case "roa":
					return MimeTypeROA;
				case "rsd":
					return MimeTypeRSD;
				case "rss":
					return MimeTypeRSS;
				case "rtf":
					return MimeTypeRTF;
				case "sbml":
					return MimeTypeSBML;
				case "scq":
					return MimeTypeSCQ;
				case "scs":
					return MimeTypeSCS;
				case "spq":
					return MimeTypeSPQ;
				case "spp":
					return MimeTypeSPP;
				case "sdp":
					return MimeTypeSDP;
				case "setpay":
					return MimeTypeSETPAY;
				case "setreg":
					return MimeTypeSETREG;
				case "shf":
					return MimeTypeSHF;
				case "smi":
				case "smil":
					return MimeTypeSMI;
				case "rq":
					return MimeTypeRQ;
				case "srx":
					return MimeTypeSRX;
				case "gram":
					return MimeTypeGRAM;
				case "grxml":
					return MimeTypeGRXML;
				case "sru":
					return MimeTypeSRU;
				case "ssdl":
					return MimeTypeSSDL;
				case "ssml":
					return MimeTypeSSML;
				case "tei":
				case "teicorpus":
					return MimeTypeTEI;
				case "tfi":
					return MimeTypeTFI;
				case "tsd":
					return MimeTypeTSD;
				case "plb":
					return MimeTypePLB;
				case "psb":
					return MimeTypePSB;
				case "pvb":
					return MimeTypePVB;
				case "tcap":
					return MimeTypeTCAP;
				case "pwn":
					return MimeTypePWN;
				case "aso":
					return MimeTypeASO;
				case "imp":
					return MimeTypeIMP;
				case "acu":
					return MimeTypeACU;
				case "atc":
				case "acutc":
					return MimeTypeATC;
				case "air":
					return MimeTypeAIR;
				case "fcdt":
					return MimeTypeFCDT;
				case "fxp":
				case "fxpl":
					return MimeTypeFXP;
				case "xdp":
					return MimeTypeXDP;
				case "xfdf":
					return MimeTypeXFDF;
				case "ahead":
					return MimeTypeAHEAD;
				case "azf":
					return MimeTypeAZF;
				case "azs":
					return MimeTypeAZS;
				case "azw":
					return MimeTypeAZW;
				case "acc":
					return MimeTypeACC;
				case "ami":
					return MimeTypeAMI;
				case "apk":
					return MimeTypeAPK;
				case "cii":
					return MimeTypeCII;
				case "fti":
					return MimeTypeFTI;
				case "atx":
					return MimeTypeATX;
				case "mpkg":
					return MimeTypeMPKG;
				case "m3u8":
					return MimeTypeM3U8;
				case "swi":
					return MimeTypeSWI;
				case "iota":
					return MimeTypeIOTA;
				case "aep":
					return MimeTypeAEP;
				case "mpm":
					return MimeTypeMPM;
				case "bmi":
					return MimeTypeBMI;
				case "rep":
					return MimeTypeREP;
				case "cdxml":
					return MimeTypeCDXML;
				case "mmd":
					return MimeTypeMMD;
				case "cdy":
					return MimeTypeCDY;
				case "cla":
					return MimeTypeCLA;
				case "rp9":
					return MimeTypeRP9;
				case "c4g":
				case "c4d":
				case "c4f":
				case "c4p":
				case "c4u":
					return MimeTypeC4G;
				case "c11amc":
					return MimeTypeC11AMC;
				case "c11amz":
					return MimeTypeC11AMZ;
				case "csp":
					return MimeTypeCSP;
				case "cdbcmsg":
					return MimeTypeCDBCMSG;
				case "cmc":
					return MimeTypeCMC;
				case "clkx":
					return MimeTypeCLKX;
				case "clkk":
					return MimeTypeCLKK;
				case "clkp":
					return MimeTypeCLKP;
				case "clkt":
					return MimeTypeCLKT;
				case "clkw":
					return MimeTypeCLKW;
				case "wbs":
					return MimeTypeWBS;
				case "pml":
					return MimeTypePML;
				case "ppd":
					return MimeTypePPD;
				case "car":
					return MimeTypeCAR;
				case "pcurl":
					return MimeTypePCURL;
				case "dart":
					return MimeTypeDART;
				case "rdz":
					return MimeTypeRDZ;
				case "uvf":
				case "uvvf":
				case "uvd":
				case "uvvd":
					return MimeTypeUVF;
				case "uvt":
				case "uvvt":
					return MimeTypeUVT;
				case "uvx":
				case "uvvx":
					return MimeTypeUVX;
				case "uvz":
				case "uvvz":
					return MimeTypeUVZ;
				case "fe_launch":
					return MimeTypeFELAUNCH;
				case "dna":
					return MimeTypeDNA;
				case "mlp":
					return MimeTypeMLP;
				case "dpg":
					return MimeTypeDPG;
				case "dfac":
					return MimeTypeDFAC;
				case "kpxx":
					return MimeTypeKPXX;
				case "ait":
					return MimeTypeAIT;
				case "svc":
					return MimeTypeSVC;
				case "geo":
					return MimeTypeGEO;
				case "mag":
					return MimeTypeMAG;
				case "nml":
					return MimeTypeNML;
				case "esf":
					return MimeTypeESF;
				case "msf":
					return MimeTypeMSF;
				case "qam":
					return MimeTypeQAM;
				case "slt":
					return MimeTypeSLT;
				case "ssf":
					return MimeTypeSSF;
				case "es3":
				case "et3":
					return MimeTypeES3;
				case "ez2":
					return MimeTypeEZ2;
				case "ez3":
					return MimeTypeEZ3;
				case "fdf":
					return MimeTypeFDF;
				case "mseed":
					return MimeTypeMSEED;
				case "seed":
				case "dataless":
					return MimeTypeSEED;
				case "gph":
					return MimeTypeGPH;
				case "ftc":
					return MimeTypeFTC;
				case "fm":
				case "frame":
				case "maker":
				case "book":
					return MimeTypeFM;
				case "fnc":
					return MimeTypeFNC;
				case "ltf":
					return MimeTypeLTF;
				case "fsc":
					return MimeTypeFSC;
				case "oas":
					return MimeTypeOAS;
				case "oa2":
					return MimeTypeOA2;
				case "oa3":
					return MimeTypeOA3;
				case "fg5":
					return MimeTypeFG5;
				case "bh2":
					return MimeTypeBH2;
				case "ddd":
					return MimeTypeDDD;
				case "xdw":
					return MimeTypeXDW;
				case "xbd":
					return MimeTypeXBD;
				case "fzs":
					return MimeTypeFZS;
				case "txd":
					return MimeTypeTXD;
				case "ggb":
					return MimeTypeGGB;
				case "ggt":
					return MimeTypeGGT;
				case "gex":
				case "gre":
					return MimeTypeGEX;
				case "gxt":
					return MimeTypeGXT;
				case "g2w":
					return MimeTypeG2W;
				case "g3w":
					return MimeTypeG3W;
				case "gmx":
					return MimeTypeGMX;
				case "kml":
					return MimeTypeKML;
				case "kmz":
					return MimeTypeKMZ;
				case "gqf":
				case "gqs":
					return MimeTypeGQF;
				case "gac":
					return MimeTypeGAC;
				case "ghf":
					return MimeTypeGHF;
				case "gim":
					return MimeTypeGIM;
				case "grv":
					return MimeTypeGRV;
				case "gtm":
					return MimeTypeGTM;
				case "tpl":
					return MimeTypeTPL;
				case "vcg":
					return MimeTypeVCG;
				case "hal":
					return MimeTypeHAL;
				case "zmm":
					return MimeTypeZMM;
				case "hbci":
					return MimeTypeHBCI;
				case "les":
					return MimeTypeLES;
				case "hpgl":
					return MimeTypeHPGL;
				case "hpid":
					return MimeTypeHPID;
				case "hps":
					return MimeTypeHPS;
				case "jlt":
					return MimeTypeJLT;
				case "pcl":
					return MimeTypePCL;
				case "pclxl":
					return MimeTypePCLXL;
				case "sfd-hdstx":
					return MimeTypeSFDHDSTX;
				case "mpy":
					return MimeTypeMPY;
				case "afp":
				case "listafp":
				case "list3820":
					return MimeTypeAFP;
				case "irm":
					return MimeTypeIRM;
				case "sc":
					return MimeTypeSC;
				case "icc":
				case "icm":
					return MimeTypeICC;
				case "igl":
					return MimeTypeIGL;
				case "ivp":
					return MimeTypeIVP;
				case "ivu":
					return MimeTypeIVU;
				case "igm":
					return MimeTypeIGM;
				case "xpw":
				case "xpx":
					return MimeTypeXPW;
				case "i2g":
					return MimeTypeI2G;
				case "qbo":
					return MimeTypeQBO;
				case "qfx":
					return MimeTypeQFX;
				case "rcprofile":
					return MimeTypeRCPROFILE;
				case "irp":
					return MimeTypeIRP;
				case "xpr":
					return MimeTypeXPR;
				case "fcs":
					return MimeTypeFCS;
				case "jam":
					return MimeTypeJAM;
				case "rms":
					return MimeTypeRMS;
				case "jisp":
					return MimeTypeJISP;
				case "joda":
					return MimeTypeJODA;
				case "ktz":
				case "ktr":
					return MimeTypeKTZ;
				case "karbon":
					return MimeTypeKARBON;
				case "chrt":
					return MimeTypeCHRT;
				case "kfo":
					return MimeTypeKFO;
				case "flw":
					return MimeTypeFLW;
				case "kon":
					return MimeTypeKON;
				case "kpr":
				case "kpt":
					return MimeTypeKPR;
				case "ksp":
					return MimeTypeKSP;
				case "kwd":
				case "kwt":
					return MimeTypeKWD;
				case "htke":
					return MimeTypeHTKE;
				case "kia":
					return MimeTypeKIA;
				case "kne":
				case "knp":
					return MimeTypeKNE;
				case "skp":
				case "skd":
				case "skt":
				case "skm":
					return MimeTypeSKP;
				case "sse":
					return MimeTypeSSE;
				case "lasxml":
					return MimeTypeLASXML;
				case "lbd":
					return MimeTypeLBD;
				case "lbe":
					return MimeTypeLBE;
				case "123":
					return MimeType123;
				case "apr":
					return MimeTypeAPR;
				case "pre":
					return MimeTypePRE;
				case "nsf":
					return MimeTypeNSF;
				case "org":
					return MimeTypeORG;
				case "scm":
					return MimeTypeSCM;
				case "lwp":
					return MimeTypeLWP;
				case "portpkg":
					return MimeTypePORTPKG;
				case "mcd":
					return MimeTypeMCD;
				case "mc1":
					return MimeTypeMC1;
				case "cdkey":
					return MimeTypeCDKEY;
				case "mwf":
					return MimeTypeMWF;
				case "mfm":
					return MimeTypeMFM;
				case "flo":
					return MimeTypeFLO;
				case "igx":
					return MimeTypeIGX;
				case "mif":
					return MimeTypeMIF;
				case "daf":
					return MimeTypeDAF;
				case "dis":
					return MimeTypeDIS;
				case "mbk":
					return MimeTypeMBK;
				case "mqy":
					return MimeTypeMQY;
				case "msl":
					return MimeTypeMSL;
				case "plc":
					return MimeTypePLC;
				case "txf":
					return MimeTypeTXF;
				case "mpn":
					return MimeTypeMPN;
				case "mpc":
					return MimeTypeMPC;
				case "xul":
					return MimeTypeXUL;
				case "cil":
					return MimeTypeCIL;
				case "cab":
					return MimeTypeCAB;
				case "xls":
				case "xlm":
				case "xla":
				case "xlc":
				case "xlt":
				case "xlw":
					return MimeTypeXLS;
				case "xlam":
					return MimeTypeXLAM;
				case "xlsb":
					return MimeTypeXLSB;
				case "xlsm":
					return MimeTypeXLSM;
				case "xltm":
					return MimeTypeXLTM;
				case "eot":
					return MimeTypeEOT;
				case "chm":
					return MimeTypeCHM;
				case "ims":
					return MimeTypeIMS;
				case "lrm":
					return MimeTypeLRM;
				case "thmx":
					return MimeTypeTHMX;
				case "cat":
					return MimeTypeCAT;
				case "stl":
					return MimeTypeSTL;
				case "ppt":
				case "pps":
				case "pot":
					return MimeTypePPT;
				case "ppam":
					return MimeTypePPAM;
				case "pptm":
					return MimeTypePPTM;
				case "sldm":
					return MimeTypeSLDM;
				case "ppsm":
					return MimeTypePPSM;
				case "potm":
					return MimeTypePOTM;
				case "mpp":
				case "mpt":
					return MimeTypeMPP;
				case "docm":
					return MimeTypeDOCM;
				case "dotm":
					return MimeTypeDOTM;
				case "wps":
				case "wks":
				case "wcm":
				case "wdb":
					return MimeTypeWPS;
				case "wpl":
					return MimeTypeWPL;
				case "xps":
					return MimeTypeXPS;
				case "mseq":
					return MimeTypeMSEQ;
				case "mus":
					return MimeTypeMUS;
				case "msty":
					return MimeTypeMSTY;
				case "taglet":
					return MimeTypeTAGLET;
				case "nlu":
					return MimeTypeNLU;
				case "ntf":
				case "nitf":
					return MimeTypeNTF;
				case "nnd":
					return MimeTypeNND;
				case "nns":
					return MimeTypeNNS;
				case "nnw":
					return MimeTypeNNW;
				case "ngdat":
					return MimeTypeNGDAT;
				case "n-gage":
					return MimeTypeNGAGE;
				case "rpst":
					return MimeTypeRPST;
				case "rpss":
					return MimeTypeRPSS;
				case "edm":
					return MimeTypeEDM;
				case "edx":
					return MimeTypeEDX;
				case "ext":
					return MimeTypeEXT;
				case "odc":
					return MimeTypeODC;
				case "otc":
					return MimeTypeOTC;
				case "odb":
					return MimeTypeODB;
				case "odf":
					return MimeTypeODF;
				case "odft":
					return MimeTypeODFT;
				case "odg":
					return MimeTypeODG;
				case "otg":
					return MimeTypeOTG;
				case "odi":
					return MimeTypeODI;
				case "oti":
					return MimeTypeOTI;
				case "odp":
					return MimeTypeODP;
				case "otp":
					return MimeTypeOTP;
				case "ods":
					return MimeTypeODS;
				case "ots":
					return MimeTypeOTS;
				case "odt":
					return MimeTypeODT;
				case "odm":
					return MimeTypeODM;
				case "ott":
					return MimeTypeOTT;
				case "oth":
					return MimeTypeOTH;
				case "xo":
					return MimeTypeXO;
				case "dd2":
					return MimeTypeDD2;
				case "oxt":
					return MimeTypeOXT;
				case "pptx":
					return MimeTypePPTX;
				case "sldx":
					return MimeTypeSLDX;
				case "ppsx":
					return MimeTypePPSX;
				case "potx":
					return MimeTypePOTX;
				case "xlsx":
					return MimeTypeXLSX;
				case "xltx":
					return MimeTypeXLTX;
				case "docx":
					return MimeTypeDOCX;
				case "dotx":
					return MimeTypeDOTX;
				case "mgp":
					return MimeTypeMGP;
				case "dp":
					return MimeTypeDP;
				case "esa":
					return MimeTypeESA;
				case "pdb":
				case "pqa":
				case "oprc":
					return MimeTypePDB;
				case "paw":
					return MimeTypePAW;
				case "str":
					return MimeTypeSTR;
				case "ei6":
					return MimeTypeEI6;
				case "efif":
					return MimeTypeEFIF;
				case "wg":
					return MimeTypeWG;
				case "plf":
					return MimeTypePLF;
				case "pbd":
					return MimeTypePBD;
				case "box":
					return MimeTypeBOX;
				case "mgz":
					return MimeTypeMGZ;
				case "qps":
					return MimeTypeQPS;
				case "ptid":
					return MimeTypePTID;
				case "qxd":
				case "qxt":
				case "qwd":
				case "qwt":
				case "qxl":
				case "qxb":
					return MimeTypeQXD;
				case "bed":
					return MimeTypeBED;
				case "mxl":
					return MimeTypeMXL;
				case "musicxml":
					return MimeTypeMUSICXML;
				case "cryptonote":
					return MimeTypeCRYPTONOTE;
				case "cod":
					return MimeTypeCOD;
				case "rm":
					return MimeTypeRM;
				case "rmvb":
					return MimeTypeRMVB;
				case "link66":
					return MimeTypeLINK66;
				case "st":
					return MimeTypeST;
				case "see":
					return MimeTypeSEE;
				case "sema":
					return MimeTypeSEMA;
				case "semd":
					return MimeTypeSEMD;
				case "semf":
					return MimeTypeSEMF;
				case "ifm":
					return MimeTypeIFM;
				case "itp":
					return MimeTypeITP;
				case "iif":
					return MimeTypeIIF;
				case "ipk":
					return MimeTypeIPK;
				case "twd":
				case "twds":
					return MimeTypeTWD;
				case "mmf":
					return MimeTypeMMF;
				case "teacher":
					return MimeTypeTEACHER;
				case "sdkm":
				case "sdkd":
					return MimeTypeSDKM;
				case "dxp":
					return MimeTypeDXP;
				case "sfs":
					return MimeTypeSFS;
				case "sdc":
					return MimeTypeSDC;
				case "sda":
					return MimeTypeSDA;
				case "sdd":
					return MimeTypeSDD;
				case "smf":
					return MimeTypeSMF;
				case "sdw":
				case "vor":
					return MimeTypeSDW;
				case "sgl":
					return MimeTypeSGL;
				case "smzip":
					return MimeTypeSMZIP;
				case "sm":
					return MimeTypeSM;
				case "sxc":
					return MimeTypeSXC;
				case "stc":
					return MimeTypeSTC;
				case "sxd":
					return MimeTypeSXD;
				case "std":
					return MimeTypeSTD;
				case "sxi":
					return MimeTypeSXI;
				case "sti":
					return MimeTypeSTI;
				case "sxm":
					return MimeTypeSXM;
				case "sxw":
					return MimeTypeSXW;
				case "sxg":
					return MimeTypeSXG;
				case "stw":
					return MimeTypeSTW;
				case "sus":
				case "susp":
					return MimeTypeSUS;
				case "svd":
					return MimeTypeSVD;
				case "sis":
				case "sisx":
					return MimeTypeSIS;
				case "xsm":
					return MimeTypeXSM;
				case "bdm":
					return MimeTypeBDM;
				case "xdm":
					return MimeTypeXDM;
				case "tao":
					return MimeTypeTAO;
				case "pcap":
				case "cap":
				case "dmp":
					return MimeTypePCAP;
				case "tmo":
					return MimeTypeTMO;
				case "tpt":
					return MimeTypeTPT;
				case "mxs":
					return MimeTypeMXS;
				case "tra":
					return MimeTypeTRA;
				case "ufd":
				case "ufdl":
					return MimeTypeUFD;
				case "utz":
					return MimeTypeUTZ;
				case "umj":
					return MimeTypeUMJ;
				case "unityweb":
					return MimeTypeUNITYWEB;
				case "uoml":
					return MimeTypeUOML;
				case "vcx":
					return MimeTypeVCX;
				case "vsd":
				case "vst":
				case "vss":
				case "vsw":
					return MimeTypeVSD;
				case "vis":
					return MimeTypeVIS;
				case "vsf":
					return MimeTypeVSF;
				case "wbxml":
					return MimeTypeWBXML;
				case "wmlc":
					return MimeTypeWMLC;
				case "wmlsc":
					return MimeTypeWMLSC;
				case "wtb":
					return MimeTypeWTB;
				case "nbp":
					return MimeTypeNBP;
				case "wpd":
					return MimeTypeWPD;
				case "wqd":
					return MimeTypeWQD;
				case "stf":
					return MimeTypeSTF;
				case "xar":
					return MimeTypeXAR;
				case "xfdl":
					return MimeTypeXFDL;
				case "hvd":
					return MimeTypeHVD;
				case "hvs":
					return MimeTypeHVS;
				case "hvp":
					return MimeTypeHVP;
				case "osf":
					return MimeTypeOSF;
				case "osfpvg":
					return MimeTypeOSFPVG;
				case "saf":
					return MimeTypeSAF;
				case "spf":
					return MimeTypeSPF;
				case "cmp":
					return MimeTypeCMP;
				case "zir":
				case "zirz":
					return MimeTypeZIR;
				case "zaz":
					return MimeTypeZAZ;
				case "vxml":
					return MimeTypeVXML;
				case "wgt":
					return MimeTypeWGT;
				case "hlp":
					return MimeTypeHLP;
				case "wsdl":
					return MimeTypeWSDL;
				case "wspolicy":
					return MimeTypeWSPOLICY;
				case "7z":
					return MimeType7Z;
				case "abw":
					return MimeTypeABW;
				case "ace":
					return MimeTypeACE;
				case "dmg":
					return MimeTypeDMG;
				case "aab":
				case "x32":
				case "u32":
				case "vox":
					return MimeTypeAAB;
				case "aam":
					return MimeTypeAAM;
				case "aas":
					return MimeTypeAAS;
				case "bcpio":
					return MimeTypeBCPIO;
				case "torrent":
					return MimeTypeTORRENT;
				case "blb":
				case "blorb":
					return MimeTypeBLB;
				case "bz":
					return MimeTypeBZ;
				case "bz2":
				case "boz":
					return MimeTypeBZ2;
				case "cbr":
				case "cba":
				case "cbt":
				case "cbz":
				case "cb7":
					return MimeTypeCBR;
				case "vcd":
					return MimeTypeVCD;
				case "cfs":
					return MimeTypeCFS;
				case "chat":
					return MimeTypeCHAT;
				case "pgn":
					return MimeTypePGN;
				case "nsc":
					return MimeTypeNSC;
				case "cpio":
					return MimeTypeCPIO;
				case "csh":
					return MimeTypeCSH;
				case "deb":
				case "udeb":
					return MimeTypeDEB;
				case "dgc":
					return MimeTypeDGC;
				case "dir":
				case "dcr":
				case "dxr":
				case "cst":
				case "cct":
				case "cxt":
				case "w3d":
				case "fgd":
				case "swa":
					return MimeTypeDIR;
				case "wad":
					return MimeTypeWAD;
				case "ncx":
					return MimeTypeNCX;
				case "dtb":
					return MimeTypeDTB;
				case "res":
					return MimeTypeRES;
				case "dvi":
					return MimeTypeDVI;
				case "evy":
					return MimeTypeEVY;
				case "eva":
					return MimeTypeEVA;
				case "bdf":
					return MimeTypeBDF;
				case "gsf":
					return MimeTypeGSF;
				case "psf":
					return MimeTypePSF;
				case "otf":
					return MimeTypeOTF;
				case "pcf":
					return MimeTypePCF;
				case "snf":
					return MimeTypeSNF;
				case "ttf":
				case "ttc":
					return MimeTypeTTF;
				case "pfa":
				case "pfb":
				case "pfm":
				case "afm":
					return MimeTypePFA;
				case "arc":
					return MimeTypeARC;
				case "spl":
					return MimeTypeSPL;
				case "gca":
					return MimeTypeGCA;
				case "ulx":
					return MimeTypeULX;
				case "gnumeric":
					return MimeTypeGNUMERIC;
				case "gramps":
					return MimeTypeGRAMPS;
				case "gtar":
					return MimeTypeGTAR;
				case "hdf":
					return MimeTypeHDF;
				case "install":
					return MimeTypeINSTALL;
				case "iso":
					return MimeTypeISO;
				case "jnlp":
					return MimeTypeJNLP;
				case "latex":
					return MimeTypeLATEX;
				case "lzh":
				case "lha":
					return MimeTypeLZH;
				case "mie":
					return MimeTypeMIE;
				case "prc":
				case "mobi":
					return MimeTypePRC;
				case "application":
					return MimeTypeAPPLICATION;
				case "lnk":
					return MimeTypeLNK;
				case "wmd":
					return MimeTypeWMD;
				case "wmz":
					return MimeTypeWMZ;
				case "xbap":
					return MimeTypeXBAP;
				case "mdb":
					return MimeTypeMDB;
				case "obd":
					return MimeTypeOBD;
				case "crd":
					return MimeTypeCRD;
				case "clp":
					return MimeTypeCLP;
				case "exe":
				case "dll":
				case "com":
				case "bat":
				case "msi":
					return MimeTypeEXE;
				case "mvb":
				case "m13":
				case "m14":
					return MimeTypeMVB;
				case "wmf":
				case "emf":
				case "emz":
					return MimeTypeWMF;
				case "mny":
					return MimeTypeMNY;
				case "pub":
					return MimeTypePUB;
				case "scd":
					return MimeTypeSCD;
				case "trm":
					return MimeTypeTRM;
				case "wri":
					return MimeTypeWRI;
				case "nc":
				case "cdf":
					return MimeTypeNC;
				case "nzb":
					return MimeTypeNZB;
				case "p12":
				case "pfx":
					return MimeTypeP12;
				case "p7b":
				case "spc":
					return MimeTypeP7B;
				case "p7r":
					return MimeTypeP7R;
				case "rar":
					return MimeTypeRAR;
				case "ris":
					return MimeTypeRIS;
				case "sh":
					return MimeTypeSH;
				case "shar":
					return MimeTypeSHAR;
				case "swf":
					return MimeTypeSWF;
				case "xap":
					return MimeTypeXAP;
				case "sql":
					return MimeTypeSQL;
				case "sit":
					return MimeTypeSIT;
				case "sitx":
					return MimeTypeSITX;
				case "srt":
					return MimeTypeSRT;
				case "sv4cpio":
					return MimeTypeSV4CPIO;
				case "sv4crc":
					return MimeTypeSV4CRC;
				case "t3":
					return MimeTypeT3;
				case "gam":
					return MimeTypeGAM;
				case "tar":
					return MimeTypeTAR;
				case "tcl":
				case "tk":
					return MimeTypeTCL;
				case "tex":
					return MimeTypeTEX;
				case "tfm":
					return MimeTypeTFM;
				case "texinfo":
				case "texi":
					return MimeTypeTEXINFO;
				case "obj":
					return MimeTypeOBJ;
				case "ustar":
					return MimeTypeUSTAR;
				case "src":
					return MimeTypeSRC;
				case "der":
				case "crt":
				case "pem":
					return MimeTypeDER;
				case "fig":
					return MimeTypeFIG;
				case "xlf":
					return MimeTypeXLF;
				case "xpi":
					return MimeTypeXPI;
				case "xz":
					return MimeTypeXZ;
				case "z1":
				case "z2":
				case "z3":
				case "z4":
				case "z5":
				case "z6":
				case "z7":
				case "z8":
					return MimeTypeZ1;
				case "xaml":
					return MimeTypeXAML;
				case "xdf":
					return MimeTypeXDF;
				case "xenc":
					return MimeTypeXENC;
				case "xhtml":
				case "xht":
					return MimeTypeXHTML;
				case "xml":
				case "xsl":
					return MimeTypeXML;
				case "dtd":
					return MimeTypeDTD;
				case "xop":
					return MimeTypeXOP;
				case "xpl":
					return MimeTypeXPL;
				case "xslt":
					return MimeTypeXSLT;
				case "xspf":
					return MimeTypeXSPF;
				case "mxml":
				case "xhvml":
				case "xvml":
				case "xvm":
					return MimeTypeMXML;
				case "yang":
					return MimeTypeYANG;
				case "yin":
					return MimeTypeYIN;
				case "zip":
					return MimeTypeZIP;
				case "adp":
					return MimeTypeADP;
				case "au":
				case "snd":
					return MimeTypeAU;
				case "mid":
				case "midi":
				case "kar":
				case "rmi":
					return MimeTypeMID;
				case "m4a":
				case "mp4a":
				case "f4a":
				case "f4b":
					return MimeTypeM4A;
				case "mpga":
				case "mp2":
				case "mp2a":
				case "mp3":
				case "m2a":
				case "m3a":
					return MimeTypeMPGA;
				case "oga":
				case "ogg":
				case "spx":
				case "opus":
					return MimeTypeOGA;
				case "s3m":
					return MimeTypeS3M;
				case "sil":
					return MimeTypeSIL;
				case "uva":
				case "uvva":
					return MimeTypeUVA;
				case "eol":
					return MimeTypeEOL;
				case "dra":
					return MimeTypeDRA;
				case "dts":
					return MimeTypeDTS;
				case "dtshd":
					return MimeTypeDTSHD;
				case "lvp":
					return MimeTypeLVP;
				case "pya":
					return MimeTypePYA;
				case "ecelp4800":
					return MimeTypeECELP4800;
				case "ecelp7470":
					return MimeTypeECELP7470;
				case "ecelp9600":
					return MimeTypeECELP9600;
				case "rip":
					return MimeTypeRIP;
				case "weba":
					return MimeTypeWEBA;
				case "aac":
					return MimeTypeAAC;
				case "aif":
				case "aiff":
				case "aifc":
					return MimeTypeAIF;
				case "caf":
					return MimeTypeCAF;
				case "flac":
					return MimeTypeFLAC;
				case "mka":
					return MimeTypeMKA;
				case "m3u":
					return MimeTypeM3U;
				case "wax":
					return MimeTypeWAX;
				case "wma":
					return MimeTypeWMA;
				case "ram":
				case "ra":
					return MimeTypeRAM;
				case "rmp":
					return MimeTypeRMP;
				case "wav":
					return MimeTypeWAV;
				case "xm":
					return MimeTypeXM;
				case "cdx":
					return MimeTypeCDX;
				case "cif":
					return MimeTypeCIF;
				case "cmdf":
					return MimeTypeCMDF;
				case "cml":
					return MimeTypeCML;
				case "csml":
					return MimeTypeCSML;
				case "xyz":
					return MimeTypeXYZ;
				case "bmp":
					return MimeTypeBMP;
				case "cgm":
					return MimeTypeCGM;
				case "g3":
					return MimeTypeG3;
				case "gif":
					return MimeTypeGIF;
				case "ief":
					return MimeTypeIEF;
				case "jpeg":
				case "jpg":
				case "jpe":
					return MimeTypeJPEG;
				case "ktx":
					return MimeTypeKTX;
				case "png":
					return MimeTypePNG;
				case "btif":
					return MimeTypeBTIF;
				case "sgi":
					return MimeTypeSGI;
				case "svg":
				case "svgz":
					return MimeTypeSVG;
				case "tiff":
				case "tif":
					return MimeTypeTIFF;
				case "psd":
					return MimeTypePSD;
				case "uvi":
				case "uvvi":
				case "uvg":
				case "uvvg":
					return MimeTypeUVI;
				case "djvu":
				case "djv":
					return MimeTypeDJVU;
				case "sub":
					return MimeTypeSUB;
				case "dwg":
					return MimeTypeDWG;
				case "dxf":
					return MimeTypeDXF;
				case "fbs":
					return MimeTypeFBS;
				case "fpx":
					return MimeTypeFPX;
				case "fst":
					return MimeTypeFST;
				case "mmr":
					return MimeTypeMMR;
				case "rlc":
					return MimeTypeRLC;
				case "mdi":
					return MimeTypeMDI;
				case "wdp":
					return MimeTypeWDP;
				case "npx":
					return MimeTypeNPX;
				case "wbmp":
					return MimeTypeWBMP;
				case "xif":
					return MimeTypeXIF;
				case "webp":
					return MimeTypeWEBP;
				case "3ds":
					return MimeType3DS;
				case "ras":
					return MimeTypeRAS;
				case "cmx":
					return MimeTypeCMX;
				case "fh":
				case "fhc":
				case "fh4":
				case "fh5":
				case "fh7":
					return MimeTypeFH;
				case "ico":
				case "cur":
					return MimeTypeICO;
				case "sid":
					return MimeTypeSID;
				case "pcx":
					return MimeTypePCX;
				case "pic":
				case "pct":
					return MimeTypePIC;
				case "pnm":
					return MimeTypePNM;
				case "pbm":
					return MimeTypePBM;
				case "pgm":
					return MimeTypePGM;
				case "ppm":
					return MimeTypePPM;
				case "rgb":
					return MimeTypeRGB;
				case "tga":
					return MimeTypeTGA;
				case "xbm":
					return MimeTypeXBM;
				case "xpm":
					return MimeTypeXPM;
				case "xwd":
					return MimeTypeXWD;
				case "eml":
				case "mime":
					return MimeTypeEML;
				case "igs":
				case "iges":
					return MimeTypeIGS;
				case "msh":
				case "mesh":
				case "silo":
					return MimeTypeMSH;
				case "dae":
					return MimeTypeDAE;
				case "dwf":
					return MimeTypeDWF;
				case "gdl":
					return MimeTypeGDL;
				case "gtw":
					return MimeTypeGTW;
				case "mts":
					return MimeTypeMTS;
				case "vtu":
					return MimeTypeVTU;
				case "wrl":
				case "vrml":
					return MimeTypeWRL;
				case "x3db":
				case "x3dbz":
					return MimeTypeX3DB;
				case "x3dv":
				case "x3dvz":
					return MimeTypeX3DV;
				case "x3d":
				case "x3dz":
					return MimeTypeX3D;
				case "appcache":
					return MimeTypeAPPCACHE;
				case "ics":
				case "ifb":
					return MimeTypeICS;
				case "css":
					return MimeTypeCSS;
				case "csv":
					return MimeTypeCSV;
				case "html":
				case "htm":
				case "shtml":
					return MimeTypeHTML;
				case "n3":
					return MimeTypeN3;
				case "txt":
				case "text":
				case "conf":
				case "def":
				case "list":
				case "log":
				case "in":
					return MimeTypeTXT;
				case "dsc":
					return MimeTypeDSC;
				case "rtx":
					return MimeTypeRTX;
				case "sgml":
				case "sgm":
					return MimeTypeSGML;
				case "tsv":
					return MimeTypeTSV;
				case "t":
				case "tr":
				case "roff":
				case "man":
				case "me":
				case "ms":
					return MimeTypeT;
				case "ttl":
					return MimeTypeTTL;
				case "uri":
				case "uris":
				case "urls":
					return MimeTypeURI;
				case "vcard":
					return MimeTypeVCARD;
				case "curl":
					return MimeTypeCURL;
				case "dcurl":
					return MimeTypeDCURL;
				case "mcurl":
					return MimeTypeMCURL;
				case "scurl":
					return MimeTypeSCURL;
				case "fly":
					return MimeTypeFLY;
				case "flx":
					return MimeTypeFLX;
				case "gv":
					return MimeTypeGV;
				case "3dml":
					return MimeType3DML;
				case "spot":
					return MimeTypeSPOT;
				case "jad":
					return MimeTypeJAD;
				case "wml":
					return MimeTypeWML;
				case "wmls":
					return MimeTypeWMLS;
				case "s":
				case "asm":
					return MimeTypeS;
				case "c":
				case "cc":
				case "cxx":
				case "cpp":
				case "h":
				case "hh":
				case "dic":
					return MimeTypeC;
				case "f":
				case "for":
				case "f77":
				case "f90":
					return MimeTypeF;
				case "java":
					return MimeTypeJAVA;
				case "nfo":
					return MimeTypeNFO;
				case "opml":
					return MimeTypeOPML;
				case "p":
				case "pas":
					return MimeTypeP;
				case "etx":
					return MimeTypeETX;
				case "sfv":
					return MimeTypeSFV;
				case "uu":
					return MimeTypeUU;
				case "vcs":
					return MimeTypeVCS;
				case "vcf":
					return MimeTypeVCF;
				case "3gp":
				case "3gpp":
					return MimeType3GP;
				case "3g2":
					return MimeType3G2;
				case "h261":
					return MimeTypeH261;
				case "h263":
					return MimeTypeH263;
				case "h264":
					return MimeTypeH264;
				case "jpgv":
					return MimeTypeJPGV;
				case "jpm":
				case "jpgm":
					return MimeTypeJPM;
				case "mj2":
				case "mjp2":
					return MimeTypeMJ2;
				case "mp4":
				case "mp4v":
				case "mpg4":
				case "f4p":
					return MimeTypeMP4;
				case "mpeg":
				case "mpg":
				case "mpe":
				case "m1v":
				case "m2v":
					return MimeTypeMPEG;
				case "ogv":
					return MimeTypeOGV;
				case "qt":
				case "mov":
					return MimeTypeQT;
				case "uvh":
				case "uvvh":
					return MimeTypeUVH;
				case "uvm":
				case "uvvm":
					return MimeTypeUVM;
				case "uvp":
				case "uvvp":
					return MimeTypeUVP;
				case "uvs":
				case "uvvs":
					return MimeTypeUVS;
				case "uvv":
				case "uvvv":
					return MimeTypeUVV;
				case "dvb":
					return MimeTypeDVB;
				case "fvt":
					return MimeTypeFVT;
				case "mxu":
				case "m4u":
					return MimeTypeMXU;
				case "pyv":
					return MimeTypePYV;
				case "uvu":
				case "uvvu":
					return MimeTypeUVU;
				case "viv":
					return MimeTypeVIV;
				case "webm":
					return MimeTypeWEBM;
				case "f4v":
					return MimeTypeF4V;
				case "fli":
					return MimeTypeFLI;
				case "flv":
					return MimeTypeFLV;
				case "m4v":
					return MimeTypeM4V;
				case "mkv":
				case "mk3d":
				case "mks":
					return MimeTypeMKV;
				case "mng":
					return MimeTypeMNG;
				case "asf":
				case "asx":
					return MimeTypeASF;
				case "vob":
					return MimeTypeVOB;
				case "wm":
					return MimeTypeWM;
				case "wmv":
					return MimeTypeWMV;
				case "wmx":
					return MimeTypeWMX;
				case "wvx":
					return MimeTypeWVX;
				case "avi":
					return MimeTypeAVI;
				case "movie":
					return MimeTypeMOVIE;
				case "smv":
					return MimeTypeSMV;
				case "ice":
					return MimeTypeICE;
				case "jsonld":
					return MimeTypeJSONLD;
				case "geojson":
					return MimeTypeGEOJSON;
				case "webmanifest":
					return MimeTypeWEBMANIFEST;
				case "webapp":
					return MimeTypeWEBAPP;
				case "jxr":
				case "hdp":
					return MimeTypeJXR;
				case "jng":
					return MimeTypeJNG;
				case "woff2":
					return MimeTypeWOFF2;
				case "bbaw":
					return MimeTypeBBAW;
				case "crx":
					return MimeTypeCRX;
				case "cco":
					return MimeTypeCCO;
				case "jardiff":
					return MimeTypeJARDIFF;
				case "run":
					return MimeTypeRUN;
				case "oex":
					return MimeTypeOEX;
				case "pl":
				case "pm":
					return MimeTypePL;
				case "rpm":
					return MimeTypeRPM;
				case "sea":
					return MimeTypeSEA;
				case "md":
					return MimeTypeMD;
				case "mml":
					return MimeTypeMML;
				case "xloc":
					return MimeTypeXLOC;
				case "vtt":
					return MimeTypeVTT;
				case "htc":
					return MimeTypeHTC;                
				default: 
					return null;
            }
        }
    }
}