# FileDigester
a very simple console application to walk a directory tree and get the checksum of each file, might be helpful to incremental updates

**Command line specification:**</br>
`FileDigester.exe <input dir> <output json> <checksum algorithm := MD5 | SHA256 | SHA1>`</br>

**Output format:**</br>
there is a simple output json file, you can easily deserialize it to a `Dictionary<string, string>`
```json
{
  "AdaptiveCards.dll": "5afef7d2a1aa31415774780454a623fd007c45d5000d3d6835df9b1faa37ff05",
  "AdysTech.CredentialManager.dll": "b845c90c14b2468e93d89d0400772007752c625eaf2d638417f0fbc0bf69136b",
  "AngleSharp.dll": "c5770931fa4802197804a30795f9d895552a842d4b36f012f51a3f0dcc472020",
  "cef.pak": "9fe8016f44fc97cfe83eb8b0d6a2c6ea73fb330eb00c57fef19b937afbafdf8b",
  "CefSharp.BrowserSubprocess.Core.dll": "54164295fa41160cbd63304044ff45ed5b609dab67e624a53696df3fc5d712cf",
  "CefSharp.BrowserSubprocess.Core.pdb": "2b2781bb23d5273d8fd5ae4813b681d218085c2984c17f84b6055ea96c64dcb9",
  "CefSharp.BrowserSubprocess.exe": "5b5c30779f937debebbd14cf90e545f41acee5caeed44af8be9e9539b2d9b37d",
  "CefSharp.BrowserSubprocess.pdb": "f4e59e3a44fbf639eec760959e45719abffe6cc6d89cdeb238438d34a9b8ce07",
  "CefSharp.Core.dll": "39945899227c031ceef45702bd4b5ad64201e7a56dc430b358eb6b5f750c333a",
  "CefSharp.Core.pdb": "6e6c44155e2ffe7adfb7b771203a1a4cc1cc1d3b3c2a0f1a7fd9e070744b4dd7",
  "CefSharp.Core.xml": "653be7c65783dc5f2b11ea8a3f8c8c48f93bf69c8debf73af655de17abe4a589",
  "CefSharp.dll": "11473cd2828c015a03e774fbb0e10c96dc696f543bc89936bd1fed4259b52ab1",
  "CefSharp.pdb": "2b349f2ee6ad01e5d953a68770fb3a47cae050bc7aea85c575e7252989cc5792",
  "CefSharp.Wpf.dll": "6bd68051c600870b29260a43feece0dba7c53e6ce1739b6992906301485bd85c",
  "CefSharp.Wpf.pdb": "06d5c0d030457475e8ed9a358d2b195dfe9dd97e918fd9c1c5f821a0792681d0",
  "CefSharp.Wpf.XML": "aeffcbedbe790df1458029781045d7e70dbd5fc413a5e61cda806b2cad3f7d3a",
  "CefSharp.XML": "e18524671ce719f1e38817cc38988426804353f6692d957b6eb91ffc768594ac",
  "cef_100_percent.pak": "b2447896446ccaf7489b1206e65ee3a58372325c6fda39322f52dfb62de6337d",
  "cef_200_percent.pak": "2d3686fa910276a3cc0e65854370762435ca4f24b364bafd37db9f9d83bc7e58",
  "cef_extensions.pak": "ce0db41570a927a119ddbb29484f02bc1aa6151503f87d8441290daa0b9a3ff1",
  "chrome_elf.dll": "6bf2338e23114ed8c57cc783cbfaf2ed5cd79cc03ffd94c863989e5827594df7",
  "ControlzEx.dll": "55cae0af8517ac2d787b210ac6f79c9aac7f58035b69faaf620a90f33e2676fc",
  "d3dcompiler_47.dll": "4432bbd1a390874f3f0a503d45cc48d346abc3a8c0213c289f4b615bf0ee84f3",
  "debug.log": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
  "devtools_resources.pak": "ce9cec21f8c12b6511642fb22353970209524a27ad7d3c1d4324bc81cda4c92d",
  "Dragablz.dll": "922ad6b96d275619b41dff20904faf4abc953def2a18ebaf92c8673540f2d993",
  "EmbedIO.dll": "21392a5fa8d00f4fed9450f7fabd2c8e5dd30cba73525c35f37584e17c639e2b",
  "e_sqlite3.dll": "36007aa37e7f5ba90dbc3dc92f5a701d924dedde3778c12e68ed365d6551d7c9",
  "icudtl.dat": "5397afed264007bc725783f1e5b3605094b80f67e677f4679a5b655cf5141418",
  "libcef.dll": "9475c366e98decfa3a19dee8e35fa79e51a2f4ded324b0890c159d6a92dd3abb",
  "libEGL.dll": "e4d492e29668a781f1d5a918b8506d51890e18ff951a6698bdaa0076de38159c",
  "libGLESv2.dll": "45259f5df11c93272cc32e4670f6847ef4e5070f1e2c21c3c047d3446b0c0494",
  "Magick.Native-Q16-x64.dll": "20df6c69bd74e8a4f85a72c18eae0762d82826be782102a4cbab8995d9d7281a",
  "Magick.NET-Q16-AnyCPU.dll": "d80f9c5c9dc96dbc0e772d32a575675a2b348527d3534b12c492c505e77d00ae",
  "MahApps.Metro.dll": "0965978dc2ec59d071f20b8ee3806f9a9e24c0c44583a416b9e669401497122e",
  "MaterialDesignColors.dll": "630d80fb5772da230104f1d18b9e6cbee4713c7d33fd97e5d72333e8fdb9d51b",
  "MaterialDesignThemes.Wpf.dll": "536c7a03c53eaa957b6176da812b0612900e0f4bf57dc94d1dd00243c2e739fd",
  "Microsoft.Toolkit.Win32.UI.XamlHost.dll": "0dd2f9542103b80212e53d641bc1e99fb45eccdce3540c0adb13a1067759fe77",
  "Microsoft.Toolkit.Win32.UI.XamlHost.Managed.dll": "56526639a0662b7d90a64bd3d68a7f2833091b16e2f43b08437a25bc9c72777c",
  "Microsoft.Toolkit.Win32.UI.XamlHost.pri": "14f448af38b1188fd5001bd6e7021b042833aaa72d1c9bc807384ed75b95ea5a",
  "Microsoft.Toolkit.Win32.UI.XamlHost.winmd": "11f19b199b5acf77ff9e346e3713ae3cf23d0dc4f941a5674db362e271eeed7f",
  "Microsoft.Toolkit.Win32.UI.XamlHost.xml": "58d070ff956057074cd7651c2b83af15df758df8ec278bd6087a802f24f511f8",
  "Microsoft.Toolkit.Wpf.UI.Controls.dll": "2f22b2280ece79b4efae54d9a1229a4be9bd75fcb942a1f0e78295f8823d14fd",
  "Microsoft.Toolkit.Wpf.UI.XamlHost.dll": "25aaaba6ade314779025a1717a0fe3aa6498e672dc3bec153d32666e083dd3e6",
  "Microsoft.WindowsAPICodePack.dll": "418b5e7a96f9a6105cc6fe45896a9164e79c8849f40be23a411b5563a8e3a0d0",
  "Microsoft.WindowsAPICodePack.Shell.dll": "e6fa9d9e34ff3bf63ce782654b14e4b54a3abd1022c87bc099032c2948157672",
  "natives_blob.bin": "6e340b9cffb37a989ca544e6bb780a2c78901d3fb33738768511a30617afa01d",
  "Newtonsoft.Json.dll": "99177a4cbe03625768d64a3d73392310372888f74c3eb271cf775e93057a38e6",
  "Pixeval.deps.json": "bd375d9ee29a7e6b1930b0655dd906a6caafda52f3837dfed68dfddf4a54315c",
  "Pixeval.dll": "9494b8e6add74ef9e2769980c1f18b261e45a61b958fe9f9dc11b8b5a46bfc20",
  "Pixeval.exe": "a2a286527af4aaaa10f5883319b2363613bd44f9a1a031c4f9d8e9dd4face269",
  "Pixeval.pdb": "b5f8231404b8ec8512c7920c20e40e833201db8c48d025f4d3183de0cda8ee5d",
  "Pixeval.runtimeconfig.json": "24474cc0696d2a527f5635030a43d9b49b0e6993ab4bf01f3c33ec3413303fed",
  "Pixeval.RuntimeInstallation.exe": "108f08615eab2bd01a46a0ca31b8b8d47117b21ad0e641cdb0563811ac77649f",
  "PropertyChanged.dll": "85e24adfb2c65c29a80c337befd5027d12768847e3c44c90a16727bcfcae1e3b",
  "README.txt": "94540532206def1d553d081303009ceed96b4cc6e6fbf14c29d9944fa7123fff",
  "Refit.dll": "65657b26f900ec2321ff763daa370a5c3496c59bd095ac0da185907ca8f3f695",
  "SharpVectors.Converters.dll": "2a7e2729d922c06ad7bddf6d9fd0507d0abd4d4b730880cc1b7749cd917707be",
  "SharpVectors.Core.dll": "798e8294528aed5c44f5cbee28f86676b29b4a424003d0a0395d990b92464c20",
  "SharpVectors.Css.dll": "252390d9eeae1984b0de8489b58600e86c75bcdf69bc8fdc623190dde8455a58",
  "SharpVectors.Dom.dll": "7936f0cc2ba44630e0c204754bbd633577cb1bf9febc11d5359913b31aead23c",
  "SharpVectors.Model.dll": "54b9a15418fb13d199379b59ded4d295e756c576476b22703329565357e92b2e",
  "SharpVectors.Rendering.Gdi.dll": "5ba2a779b5baa419361eebcecc09e4606c944e883bfb6985f59a15c69e6a0d2b",
  "SharpVectors.Rendering.Wpf.dll": "8c27e92fe772a0c49abf6a895a97a2b4e52504f853c8d284ffbe0977a923679c",
  "SharpVectors.Runtime.dll": "9b5cc7bd5113d0bceec4951dec8075a65d30a3aa51354c490aabc576c0fe43a3",
  "snapshot_blob.bin": "7fcd6326f261d7e4dffa0645619b135a22b59385d0ac9e3147b64eb9f19a3926",
  "SQLite-net.dll": "e679bd9e238c081d9f8264581e0159d8110b4c0c3b80e79c769384a31169e731",
  "SQLitePCLRaw.batteries_green.dll": "687703ea2169234feaf71b8664b30894f833c5a8ba662fa72853d1130156b987",
  "SQLitePCLRaw.batteries_v2.dll": "3c6719de6fc4a4a4ef4b3b89a8b9fd72e82cc2e48a105f75c20cb8ad593cdb4e",
  "SQLitePCLRaw.core.dll": "4466b29fcaba8816a02cc78f2d6f325065bd5eb1a5e6b049fd1f556af17e0657",
  "SQLitePCLRaw.provider.e_sqlite3.dll": "7d9ab7ee25319b435f7ec341cd00392de17fcc44ccb5488dbcd81d03b4006bc1",
  "Swan.Lite.dll": "a887c320e94422a4ca37515be8c513636fc991a737762e17fa12d0eb81c70526",
  "System.Interactive.Async.dll": "e804cadbc27adcf229544ca41a99220eda474832e5eae10afec37dfa0a44bad1",
  "System.Linq.Async.dll": "c775959e18b8866380a22905ba3d1371e952ce95f5c1319931147d70d10af2c5",
  "System.Windows.Interactivity.dll": "93fbc59e4880afc9f136c3ac0976ada7f3faa7cacedce5c824b337cbca9d2ebf",
  "v8_context_snapshot.bin": "c5fdf3c2e663f5247c304aa28660f1ee6c99314500110650ed053cece2c17dae",
  "VirtualizingWrapPanel.dll": "c8d976aedfd4c4f7cf363112c43a3bc1430cc04ec892e17d51f852c347a2affd",
  "Xceed.Wpf.AvalonDock.dll": "9c043845d299c26e94997a78aaba42e75222698908637be2dd7063c59a865654",
  "Xceed.Wpf.AvalonDock.Themes.Aero.dll": "c4423d9da9120582c8c2ec40c6e64525a1e1e1a79f869d57f28c5f6b0f4b4bbd",
  "Xceed.Wpf.AvalonDock.Themes.Metro.dll": "d8b0a644a84d8d35483afc18b93acb1dc60c4f29369e8b075a775c1e04e9c8d8",
  "Xceed.Wpf.AvalonDock.Themes.VS2010.dll": "eada6fc3b22d999cd5c04976009574deb5c104f32bc8198554a36d67607d51da",
  "Xceed.Wpf.Toolkit.dll": "86a19eed2960222991500c729b92fcc1ad3ad4dc2f8693f8a81175685759c089",
  "zh-Hans\\Xceed.Wpf.AvalonDock.resources.dll": "9ae426f41daa1f0c623e87ead8488f328a818ae9795eb7e16350c3461322bb24",
  "updater\\MaterialDesignColors.dll": "58e03625fd026021d431e651409103756dc93534d1d637cef8be76c7139f11a6",
  "updater\\MaterialDesignThemes.Wpf.dll": "e68f7919c71abf21e0522637b18c16d5a11a299c41368fb7d62cdccf2793c677",
  "updater\\Pixeval.Updater.dll": "5f3b1b58b8367cbdb3da47f5872b9a55856d83ecc3dc9ed9f5f422b2a67080de",
  "updater\\Pixeval.Updater.exe": "f4f7644a0cd8dd53b6efc590e5b6bb98133ae5334729fdb73240279a9781a640",
  "updater\\Pixeval.Updater.runtimeconfig.json": "24474cc0696d2a527f5635030a43d9b49b0e6993ab4bf01f3c33ec3413303fed",
  "swiftshader\\libEGL.dll": "e016a69d0a7d78fe48e4046d1e7d3d898de3d819e4d037c04a6e4198524ab241",
  "swiftshader\\libGLESv2.dll": "0097cf11809e7a47857cbabf1cafccd0eb28781fd62838ebb4392dccc6b4f8b2",
  "sv\\Xceed.Wpf.AvalonDock.resources.dll": "5970750501c52759ef5f6c6bf88d6500838c25c8bdf440cda4fffd3e164e0753",
  "ru\\Xceed.Wpf.AvalonDock.resources.dll": "b645d5c5a4fd03052a0a5554610f1db393a93f99ceeba4e9690a256d1bf8aa8e",
  "ro\\Xceed.Wpf.AvalonDock.resources.dll": "0f038aa7201c72afdc4b2629b97ee572d4605ba14d62ca03dbf1da66fe1ff735",
  "Resource\\pixeval_pac.pac": "9d3aae383dc6e965dcd6a4cee5497b538e018f0f8153004c5b577f2f693c2d9b",
  "pt-BR\\Xceed.Wpf.AvalonDock.resources.dll": "8a2fa1f0cd7e3142a7bcbf55263051f895dd4e798b210bec67d6e512ea5d726f",
  "locales\\am.pak": "877a08761061b16629ef62bae2c3558a741bc259ac0286f480956df0c3bc05bb",
  "locales\\ar.pak": "9c2f9b8be80b726b656fb8e00499247b35abcb5b193cc94189d6fc4af2ff2d2b",
  "locales\\bg.pak": "da44483ec99738a2f164aafb5c66ed14c048a9cc5fdc3180672ff35fa97a0427",
  "locales\\bn.pak": "a715c3289816a66ef6db50dd5bd9b04e77f48425e2a3766db9d832b7857727d6",
  "locales\\ca.pak": "6014ce97600a479b913e60d8865d4d6f2704d937f1863f40c6d2102bcc26bdcd",
  "locales\\cs.pak": "9ebbfbbb602d488c7af4126c1f8b47ea7061250094dcdb121baf67464f9612f9",
  "locales\\da.pak": "f8947a3c80eb7668414da05810dcb26c51292d0e4bc7520ca9f6a6497f654374",
  "locales\\de.pak": "4186cef9156bd2e25518169ad775d0f7f9145a45f41e04d52581e1eeb80e9f38",
  "locales\\el.pak": "8f6337304b694f986cd9980335938a5b7d40fff92a9ee84324d1ffe2f123f574",
  "locales\\en-GB.pak": "a4642b190d0b6df6349b43a7610a9226f64ce0dacae48a469b929579d903707c",
  "locales\\en-US.pak": "a6e262c15236a50a7b49ee0ef25369223411edbac3efb665e11746237eb38355",
  "locales\\es-419.pak": "545c89cb15581b2f93c55f30eddc9a8a258bf18832870e78c8dae6c2e568ebd4",
  "locales\\es.pak": "2e32df0907f4041a275c72801fcc4ca038c0767716b797d25a538eab17586e0a",
  "locales\\et.pak": "1584dfcb760bbe5b23e33b9c0c2558627e6c1d276b34c3cc3d7c9b64a572ef72",
  "locales\\fa.pak": "c06a4f84d86e118b7d6b6ac256fa6f52e40bdfeff77ecdbe5d1eafa1ba951a10",
  "locales\\fi.pak": "67ce1a8340198c6ec649ac8262caf7c4994aaf7c11975e3f48427d432544347f",
  "locales\\fil.pak": "5a3c58f14ffa739e0fb253618467bbb648033823e9328c1d890b013d8a2d3f5f",
  "locales\\fr.pak": "3ae3eaefc398f9de0a5d5aeb01841eebd68a65c6aeec1d310ccb827ce30218ed",
  "locales\\gu.pak": "17a91e09679e1ca39aea026837534d3f17a6716c6546a587c4f9b7a000ec471f",
  "locales\\he.pak": "05ac4692c61c53e9f1141c4e11db75585c1ba0068b1f0d7a06e9001ef7fa9bac",
  "locales\\hi.pak": "c7c85ac7a3673b70bb633f4aed89079e4fa46638cd992b1f256abd4fc38aaf49",
  "locales\\hr.pak": "c83da522812027b5d959fddf11f136ec232bf5038b81ce98790f13f08810777e",
  "locales\\hu.pak": "c96a425ce07e861627906f2f2d1889858caef02742be500365637dbc5cd3daeb",
  "locales\\id.pak": "04e64396e027c1a552736193d288427113756d51d88f8e70d774982132eddbb4",
  "locales\\it.pak": "6b7298953ce9eb9fcb676355dffee867227c4795f2d05db0e4646718728548b5",
  "locales\\ja.pak": "296cb34f0f40bb898ada296674138c3818b8b6e4482ea8f3b5530eb6970d37fd",
  "locales\\kn.pak": "44d638ca6578ea64976f7cacd07689a7cdcdbd0ef99da617c5d3c272badc8035",
  "locales\\ko.pak": "83bc50971ba64a54a225a1c7c262466d3994d4eae6cbe5ce5f6e3cce0f142599",
  "locales\\lt.pak": "314e504ce3c3519f26274fa145bb5dc3372c14388c4aa6db0301fcef0b4c1555",
  "locales\\lv.pak": "d4fb48fc88984a20c6beeea5f802b30db6d071293c77aae118c5ca9cb6fce9f9",
  "locales\\ml.pak": "4f5a7a72d836d302b6d02bef9233e733344fed6ebea3d1ea2dd136e4a87a14cd",
  "locales\\mr.pak": "e234c507f2806203c1a7cea4b065d381b6a34414c732d0c46adc7ec4694c8676",
  "locales\\ms.pak": "d976fac600b076b22b2acbb55ee8a52b1b0ebf4b01cd933f96dcbd982e79a446",
  "locales\\nb.pak": "bdad3d60b880f926d1777294977d32871e234e6a38bedfdddbdf014e2adb6721",
  "locales\\nl.pak": "408da8fef47381b78501b6edd02d6529299d164018e6505fe41d8155afeac309",
  "locales\\pl.pak": "db29f2976390527b8329e4eec1401763c7de236918c68e9e2488619a83e7f0e3",
  "locales\\pt-BR.pak": "7380bb6dc709cd1f6e397dd6db890843e1dea72ca30a1c8feea37aee782da3ec",
  "locales\\pt-PT.pak": "d1ad99ba7422a2518ec53234df86a284881e2143df533afd05975077994b2316",
  "locales\\ro.pak": "dae60d0839351d7e8e3215568519807a9945496d136b3a99deea98a5bf8cadbc",
  "locales\\ru.pak": "59e631ee5e1a31ef3bb565973a51ddadc2dfd75015000953bae172db8527632d",
  "locales\\sk.pak": "64198080592e25c0f8f258d0279ae43f9de3bc1f0445fdc4a355d7874251307f",
  "locales\\sl.pak": "304664a57dd6c942c3dc02a783aefde58ecdca9eb80ad55e000eff4750116a56",
  "locales\\sr.pak": "4db96be9e860cd1750219a6ad2aeba1768bd802928e94959634e3ddfb5ab6ac5",
  "locales\\sv.pak": "246972fc0fd752a0aa7046aa344b82a5d2a55e9d67182d83528df38ccc0e1f52",
  "locales\\sw.pak": "58dd767e389d439c573a3f4d9d9b208d82ca01eb9cd7839b1dd75e754aade4aa",
  "locales\\ta.pak": "f0ede4f980d6525334cb66ae1ae8cde65e75869c2c45ecd80e9d583607641a82",
  "locales\\te.pak": "5287900df46822ac83d8f26d7e284a63da394dec18da7a6157c6da3844b49f4c",
  "locales\\th.pak": "f290fc8182ccbfbe137aa3271d338c9bbb21737a159b731508c3591abbcbf0dc",
  "locales\\tr.pak": "1ea43d778e45f02697ee024b7b2ad649993e40a77ecc1097b80514f02c406035",
  "locales\\uk.pak": "1b68793de59653298d173a0651cc9827ecea3e63f8862ba3aa3fc039359d50b0",
  "locales\\vi.pak": "2fd5b82464b4d618e0f2d54b3821ac8e181c086025ecc54f71339e4541ae061a",
  "locales\\zh-CN.pak": "ff6c93fe293cd3cfa9de693516f3fda8ed533d9e24ceb2e9064005cb9fbc5bcf",
  "locales\\zh-TW.pak": "31dd638218d16dc223a9faafd6167b0e0754c45be8687d8b54a0a64151352010",
  "it\\Xceed.Wpf.AvalonDock.resources.dll": "22a53c0025404055c2c9ba7f1f86608aacec4242768eda66fcf3235a086876bc",
  "hu\\Xceed.Wpf.AvalonDock.resources.dll": "4a62fe408427ae1365995e44f991963a181bd4f7dbee5d126402da6658fefe80",
  "fr\\Xceed.Wpf.AvalonDock.resources.dll": "149f1101c4f9d3131f4e42a5f4fb3f1901a3e5000cb0f6efe1078181fc72c3c8",
  "es\\Xceed.Wpf.AvalonDock.resources.dll": "3ed25caccfe921e94a20fffbb4ad7d5232fbe78761163fc73a3efc9fa5c1e55e",
  "de\\Xceed.Wpf.AvalonDock.resources.dll": "8a93166370c1d1c89c0c4a6bd2c762ae5532b505e36bbbdb2de8986a8b15f8c7"
}
```
