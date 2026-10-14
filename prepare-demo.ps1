param(
    [string]$OutputDirectory = (Join-Path $PSScriptRoot 'san ji xiang mu\bin\Debug')
)

$ErrorActionPreference = 'Stop'
$destination = [System.IO.Path]::GetFullPath($OutputDirectory)
$utf8 = New-Object System.Text.UTF8Encoding($false)

function Add-DemoFile([string]$RelativePath, [string]$Content) {
    $target = Join-Path $destination $RelativePath
    [System.IO.Directory]::CreateDirectory([System.IO.Path]::GetDirectoryName($target)) | Out-Null
    if (-not (Test-Path -LiteralPath $target)) {
        [System.IO.File]::WriteAllText($target, $Content, $utf8)
    }
}

# Empty stores: no account, password, or personal result is distributed.
Add-DemoFile 'data\UserName.txt' ''
Add-DemoFile 'data\PassWord.txt' ''
$passage = 'Practice slowly, keep your eyes on the screen, and let accuracy come before speed.'
Add-DemoFile 'duanwen\wen.txt' $passage
Add-DemoFile 'duanwen\wen2.txt' $passage
1..9 | ForEach-Object {
    Add-DemoFile ("laoshouwenzhang\wen{0}.txt" -f $_) ("Lesson {0}. {1}" -f $_, $passage)
}
Write-Output "Demo files are ready in $destination. Existing files were preserved."
