#
# Go_To_Hel.ps1
#

$copies = @(
    @{
        Source = "C:\Code\Orias_OSC\RNG\RNG (VS 2026)\SRC\RNG_N10\bin\Release\net10.0\RNG.dll"
        Destination = "C:\Code\Hel\RNG\NET_10\RNG.dll"
    },
    @{
        Source = "C:\Code\Orias_OSC\RNG\RNG (VS 2026)\SRC\RNG_NS21\bin\Release\netstandard2.1\RNG.dll"
        Destination = "C:\Code\Hel\RNG\NS_21\RNG.dll"
    }
)

foreach ($item in $copies)
{
    $destFolder = Split-Path $item.Destination -Parent

    if (!(Test-Path $destFolder))
    {
        New-Item -ItemType Directory -Path $destFolder -Force | Out-Null
    }

    Copy-Item -Path $item.Source -Destination $item.Destination -Force
}

Write-Host "All files copied successfully."