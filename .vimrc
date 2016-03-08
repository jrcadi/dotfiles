syntax on
set number
set background=dark
set cursorline
set tabstop=4
set expandtab
set shiftwidth=4
set autoindent
set clipboard=unnamed,autoselect


" ノーマルモード時だけ ; と : を入れ替える
nnoremap ; :
nnoremap : ;
" insertモードから抜ける
inoremap <silent> jj <ESC>
"inoremap <silent> <C-j> j
"inoremap <silent> kk <ESC>
"inoremap <silent> <C-k> k

"" 行頭・行末移動方向をキーの相対位置にあわせる
"nnoremap 0 $ 
"nnoremap 1 0 

" 挿入モードでのカーソル移動
inoremap <C-j> <Down>
inoremap <C-k> <Up>
inoremap <C-h> <Left>
inoremap <C-l> <Right>

"" カーソル前の文字削除
"inoremap <silent> <C-h> <C-g>u<C-h>
"" カーソル後の文字削除
"inoremap <silent> <C-d> <Del>
"" カーソルから行頭まで削除
"inoremap <silent> <C-d>e <Esc>lc^
"" カーソルから行末まで削除
"inoremap <silent> <C-d>0 <Esc>lc$
"" カーソルから行頭までヤンク
"inoremap <silent> <C-y>e <Esc>ly0<Insert>
"" カーソルから行末までヤンク
"inoremap <silent> <C-y>0 <Esc>ly$<Insert>

" 引用符, 括弧の設定
"inoremap { {}<Left>
"inoremap [ []<Left>
"inoremap ( ()<Left>
"inoremap " ""<Left>
"inoremap ' ''<Left>
"inoremap <> <><Left>


""""""""""""""""""""""""""""""
" プラグインのセットアップ
""""""""""""""""""""""""""""""
if has('vim_starting')
  set nocompatible               " Be iMproved

  " Required:
  set runtimepath+=~/.vim/bundle/neobundle.vim/
endif

" Required:
call neobundle#begin(expand('~/.vim/bundle/'))

" Let NeoBundle manage NeoBundle
" Required:
"NeoBundleFetch 'Shougo/neobundle.vim'

" ファイルオープンを便利に
""NeoBundle 'Shougo/unite.vim'
" Unite.vimで最近使ったファイルを表示できるようにする
""NeoBundle 'Shougo/neomru.vim'
NeoBundle 'tpope/vim-commentary.vim'

call neobundle#end()

" Required:
filetype plugin indent on

" If there are uninstalled bundles found on startup,
" this will conveniently prompt you to install them.
"NeoBundleCheck
""""""""""""""""""""""""""""""
