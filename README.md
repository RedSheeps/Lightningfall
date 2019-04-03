# Lightningfall

Lightningfallプロジェクトは、オープンソースのプロジェクト管理アプリケーションの開発プロジェクトです。

このプロジェクトでは次のような特徴をもったプロジェクト管理アプリケーションの開発を目指します。

* WBSによるプロジェクトのタスク管理
* ガントチャートによる全体スケジュール概要の可視化
* スプリントバックログ＆バーンダウンチャートによる短期スケジュール管理
* チャートを用いたダッシュボード
* Microsoft ProjectとのImport/Export

以下のようなドメインモデルを想定しています。

![](DomainModel.png)

また本プロジェクトでは、次のアーキテクチャを採用したサンプルアプリケーションを目指します。

* ドメイン駆動設計
* Clean Architecture

技術的なアーキテクチャとしては次の選択します。

* WPF
    * MaterialDesignInXamlToolkit
    * Syncfusion WPF Controls or Infragistics WPF or ...
* Web APIを用いたWeb3層モデル
* 複数のRDBサポート（SQL ServerとSQLiteくらいか？）
* Presentasion層以外の十分な自動テスト

ただし開発方針としては、当面は動くものを開発することを前提とし、主要な機能がそろった段階から全体をリファクタリングしてアーキテクチャサンプルとして成り立つ品質を目指します。
