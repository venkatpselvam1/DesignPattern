# Steps to generate the VenkatModel.cs from protopub
1. Create new file "VenkatModel.proto"
2. Define the model defination and namespace
3. Download the protoc generator executable  https://github.com/protocolbuffers/protobuf/releases/tag/v22.0
4. Run the following command to generate the model
```
protoc -I=$SRC_DIR --csharp_out=$DST_DIR $SRC_DIR/addressbook.proto
```

e.g:
```
C:\Users\VenkatP\Downloads\protoc-22.0-win64\bin\protoc.exe -I="C:\Venkat\Repos\DesignPattern\DesignPattern\002_PrototypeDesignPatternUsingProtobuf" --csharp_out="C:\Venkat\Repos\DesignPattern\DesignPattern\002_PrototypeDesignPatternUsingProtobuf" VenkatModel.proto
```

For more detials:
https://protobuf.dev/getting-started/csharptutorial/
