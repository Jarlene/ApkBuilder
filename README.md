## 执行打包有以下步骤：
  - 1、将所有的class文件和jar文件合并为classes.jar文件。
  - 2、classes.jar文件文件做混淆。根据mapping.txt文件。
  - 3、将混淆后的jar文件生成dex文件。
  - 4、将res目录下面的进行打包，生成resourcePackage
  - 5、将dex文件和resourcePackage生成apk文件。
