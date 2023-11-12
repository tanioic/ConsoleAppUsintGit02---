﻿// コメントだけを使ったGitの演習

// 機能１の追加
// バグフィックス１の実施
// 機能２の追加
// バグフィックス２の実施

/*
 * シナリオ ※https://zenn.dev/no4_dev/articles/3360a6078d8e8c
 * 開発には作業Aと作業Bの2つの主な作業が合ったと仮定します。
 * 各作業の時間的な流れは下記となります。
 * 【機能開発】
 * 　A-１．メインブランチmasterを作る
 * 　A-２．メインブランチmasterからメインブランチdevelopを作る
 * 　A-３．メインブランチdevelopからサポートブランチfeatureを作る
 * 　A-４．サポートブランチfeatureに機能１を付け加え、コミットする
 * 【緊急修正】
 * 　B-１．メインブランチmasterからサポートブランチhotfixを作成
 * 　B-２．サポートブランチhotfixにおいてバグフィックス１を行い、コミットする
 * 　B-３．サポートブランチhotfixをメインブランチmasterへマージし、タグを作成する
 * 　　　　同時に、サポートブランチhotfixをメインブランチdevelopへマージする
 * 　　　　最後にサポートブランチhotfixを削除する
 * 【機能開発】
 * 　A-５．作業Bによるバグフィックス後、メインブランチdevelopへマージされた内容を
 * 　　　　サポートブランチfeatureにマージする
 * 　　　　この時、競合を解決してマージすること
 * 　A-６．サポートブランチfeatureに機能２を付け加え、コミットする
 * 　　　　新しい機能を開発したサポートブランチfeatureからメインブランチdevelopへマージする
 * 　　　　リリースのためにdevelopからサポートブランチreleaseを作成する
 * 【リリース作業】
 *　 B-４．サポートブランチreleaseでバグフィックス２を行い、コミットする
 * 　　　　サポートブランチreleaseをメインブランチmasterへマージし、タグを作成する
 *     　　同時に、サポートブランチreleaseをメインブランチdevelopへマージする
 *     　　そして、開発したシステムをリリースする
 *         最後にサポートブランチreleaseを削除する
 */

/*
 * git-flow
 * メインブランチ
 * 　master ブランチ：本番にリリースできる状態を保つ
 * 　develop ブランチ：開発中の最新状態を反映する
 * サポートブランチ
 * 　feature ブランチ：新機能の開発を行うのに用いる
 * 　hotfix ブランチ：緊急のバグフィックスを行うのに利用する
 * 　release ブランチ：リリースの準備作業を行うのに用いる
 */