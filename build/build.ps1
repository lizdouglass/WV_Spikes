
$base_dir = Resolve-Path ..
$configuration = "Debug"
$solutionPath = "$base_dir\microservices\WV_MicroServiceS1\WV_MicroServiceS1.sln"

task default -depends Clean, Compile

task Clean  {
  Invoke-Build -configuration $configuration -task "Clean" -projectOrSolution $solutionPath
}

task Compile -depends Clean {
  Invoke-Build -configuration $configuration -task "Build" -projectOrSolution $solutionPath
}

function Invoke-Build {
  param ([string]$task, $outputFolder=$false, $projectOrSolution=$solutionPath, $configuration)
  $env:path += ";C:\Windows\Microsoft.NET\Framework\v4.0.30319"
  $msbuildCommand = "msbuild ""$projectOrSolution"" /t:""$task"" /p:Configuration=""$configuration"" /v:quiet /nologo"
  if($outputFolder){
    $msbuildCommand += " /p:OutputPath=$outputFolder"
  }
  $msbuildExpression = $msbuildCommand
  Exec { Invoke-Expression $msbuildExpression }
}