﻿using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.Rendering.HighDefinition.ShaderGraph
{
    static class HDIncludes
    {
#region Include Declaration
        //Pre Graph core includes
        const string kCommon = "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl";
        const string kShaderVariables = "Packages/com.unity.render-pipelines.high-definition/Runtime/ShaderLibrary/ShaderVariables.hlsl";
        const string kFragInputs = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/FragInputs.hlsl";
        const string kShaderPass = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPass.cs.hlsl";
        const string kMaterial = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Material.hlsl";
        const string kShaderGraphFunctions = "Packages/com.unity.render-pipelines.high-definition/Runtime/ShaderLibrary/ShaderGraphFunctions.hlsl";
        //pre graph utility includes
        const string kBuiltInUtilities = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/BuiltinUtilities.hlsl";
        const string kMaterialUtilities = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/MaterialUtilities.hlsl";
        const string kDecalUtilities = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Decal/DecalUtilities.hlsl";
        //pre graph material includes
        const string kUnlit = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Unlit/Unlit.hlsl";
        const string kLit = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Lit/Lit.hlsl";
        const string kEye = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Eye/Eye.hlsl";
        const string kFabric = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/Fabric.hlsl";
        const string kHair = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Hair/Hair.hlsl";
        const string kStackLit = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StackLit/StackLit.hlsl";
        const string kStandardLit = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StandardLit/StandardLit.hlsl";
        //pre graph decal includes
        const string kPacking = "Packages/com.unity.render-pipelines.core/ShaderLibrary/Packing.hlsl";
        const string kColor = "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl";
        const string kFunctions = "Packages/com.unity.shadergraph/ShaderGraphLibrary/Functions.hlsl";
        const string kDecal = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Decal/Decal.hlsl";
        //pre graph function includes
        const string kCommonLighting = "Packages/com.unity.render-pipelines.core/ShaderLibrary/CommonLighting.hlsl";
        const string kShadowContext = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/Shadow/HDShadowContext.hlsl";
        const string kHDShadow = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/LightLoop/HDShadow.hlsl";
        const string kLightLoopDef = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/LightLoop/LightLoopDef.hlsl";
        const string kPunctualLightCommon = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/PunctualLightCommon.hlsl";
        const string kHDShadowLoop = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/LightLoop/HDShadowLoop.hlsl";
        const string kNormalSurfaceGradient = "Packages/com.unity.render-pipelines.core/ShaderLibrary/NormalSurfaceGradient.hlsl";
        const string kLitDecalData = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Lit/LitDecalData.hlsl";
        const string kStackLitDecalData = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StackLit/StackLitDecalData.hlsl";
        const string kLighting = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/Lighting.hlsl";
        const string kLightLoop = "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/LightLoop/LightLoop.hlsl";
        const string kSpecularOcclusionDef = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/SphericalCapPivot/SpecularOcclusionDef.hlsl";
        // post graph includes
        const string kPassLightTransport = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassLightTransport.hlsl";
        const string kPassDepthOnly = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassDepthOnly.hlsl";
        const string kPassMotionVectors = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassMotionVectors.hlsl";
        const string kDisortionVectors = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassDistortion.hlsl";
        const string kForwardUnlit = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassForwardUnlit.hlsl";
        const string kPassGBuffer = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassGBuffer.hlsl";
        const string kPassForward = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassForward.hlsl";
        const string kPassDecal = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassDecal.hlsl";
        //pregraph raytracing includes
        const string kRaytracingMacros = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl";
        const string kShaderVariablesRaytracing = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl";
        const string kShaderVariablesRaytracingLightLoop = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl";
        const string kRaytracingIntersection = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl";
        const string kLitRaytracing = "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Lit/LitRaytracing.hlsl";
        const string kRaytracingLightLoop = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingLightLoop.hlsl";
        const string kRaytracingCommon = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl";
        //post graph raytracing includes
        const string kPassRaytracingIndirect = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingIndirect.hlsl";
        const string kPassRaytracingVisbility = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingVisibility.hlsl";
        const string kPassRaytracingForward = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingForward.hlsl";
        const string kPassRaytracingGBuffer = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderpassRaytracingGBuffer.hlsl";
        const string kPassPathTracing = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassPathTracing.hlsl";
#endregion

#region Shared Includes
        public static IncludeCollection CorePregraph = new IncludeCollection
        {
            { kCommon, IncludeLocation.Pregraph },
            { kShaderVariables, IncludeLocation.Pregraph },
            { kFragInputs, IncludeLocation.Pregraph },
            { kShaderPass, IncludeLocation.Pregraph },
            { kMaterial, IncludeLocation.Pregraph },
        };
        public static IncludeCollection CoreUtility = new IncludeCollection
        {
            { kBuiltInUtilities, IncludeLocation.Pregraph },
            { kMaterialUtilities, IncludeLocation.Pregraph },
        };
        public static IncludeCollection CoreRaytracing = new IncludeCollection
        {
            { kRaytracingMacros, IncludeLocation.Pregraph },
            { kShaderVariablesRaytracing, IncludeLocation.Pregraph },
            { kShaderVariablesRaytracingLightLoop, IncludeLocation.Pregraph },
            { kRaytracingIntersection, IncludeLocation.Pregraph },
        };
#endregion

#region Unlit
        public static IncludeCollection UnlitMeta = new IncludeCollection
        {
            { CorePregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection UnlitDepthOnly = new IncludeCollection
        {
            { CorePregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection UnlitMotionVectors = new IncludeCollection
        {
            { CorePregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection UnlitForwardOnly = new IncludeCollection
        {
            { CorePregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kCommonLighting, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kShadowContext, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kHDShadow, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kLightLoopDef, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kPunctualLightCommon, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kHDShadowLoop, IncludeLocation.Pregraph, new FieldCondition(HDFields.EnableShadowMatte, true) },
            { kForwardUnlit, IncludeLocation.Postgraph },
        };

        public static IncludeCollection UnlitDistortion = new IncludeCollection
        {
            { CorePregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kDisortionVectors, IncludeLocation.Postgraph },
        };
#endregion

#region Lit
        public static IncludeCollection LitCommon = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kLitDecalData, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection LitGBuffer = new IncludeCollection
        {
            { LitCommon },
            { kPassGBuffer, IncludeLocation.Postgraph },
        };

        public static IncludeCollection LitMeta = new IncludeCollection
        {
            { LitCommon },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection LitDepthOnly = new IncludeCollection
        {
            { LitCommon },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection LitMotionVectors = new IncludeCollection
        {
            { LitCommon },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection LitForward = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kLit, IncludeLocation.Pregraph },
            { kLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kLitDecalData, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassForward, IncludeLocation.Postgraph },
        };

        public static IncludeCollection LitDistortion = new IncludeCollection
        {
            { LitCommon },
            { kDisortionVectors, IncludeLocation.Postgraph },
        };
#endregion

#region Eye
        public static IncludeCollection EyeCommon = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kEye, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection EyeMeta = new IncludeCollection
        {
            { EyeCommon },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection EyeDepthOnly = new IncludeCollection
        {
            { EyeCommon },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection EyeMotionVectors = new IncludeCollection
        {
            { EyeCommon },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection EyeForwardOnly = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kEye, IncludeLocation.Pregraph },
            { kLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassForward, IncludeLocation.Postgraph },
        };
#endregion

#region Fabric
        public static IncludeCollection FabricCommon = new IncludeCollection 
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kFabric, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection FabricMeta = new IncludeCollection
        {
            { FabricCommon },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricDepthOnly = new IncludeCollection
        {
            { FabricCommon },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricMotionVectors = new IncludeCollection
        {
            { FabricCommon },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricForwardOnly = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kFabric, IncludeLocation.Pregraph },
            { kLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassForward, IncludeLocation.Postgraph },
        };
#endregion

#region Hair
        public static IncludeCollection HairCommon = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kHair, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection HairMeta = new IncludeCollection
        {
            { HairCommon },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HairDepthOnly = new IncludeCollection
        {
            { HairCommon },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HairMotionVectors = new IncludeCollection
        {
            { HairCommon },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HairForwardOnly = new IncludeCollection
        {
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kHair, IncludeLocation.Pregraph },
            { kLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassForward, IncludeLocation.Postgraph },
        };
#endregion

#region StackLit
        public static IncludeCollection StackLitCommon = new IncludeCollection
        {
            { kSpecularOcclusionDef, IncludeLocation.Pregraph },
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kStackLit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kStackLitDecalData, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection StackLitMeta = new IncludeCollection
        {
            { StackLitCommon },
            { kPassLightTransport, IncludeLocation.Postgraph },
        };

        public static IncludeCollection StackLitDepthOnly = new IncludeCollection
        {
            { StackLitCommon },
            { kPassDepthOnly, IncludeLocation.Postgraph },
        };

        public static IncludeCollection StackLitMotionVectors = new IncludeCollection
        {
            { StackLitCommon },
            { kPassMotionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection StackLitDistortion = new IncludeCollection
        {
            { StackLitCommon },
            { kDisortionVectors, IncludeLocation.Postgraph },
        };

        public static IncludeCollection StackLitForwardOnly = new IncludeCollection
        {
            { kSpecularOcclusionDef, IncludeLocation.Pregraph },
            { CorePregraph },
            { kNormalSurfaceGradient, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kStackLit, IncludeLocation.Pregraph },
            { kLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kDecalUtilities, IncludeLocation.Pregraph },
            { kStackLitDecalData, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassForward, IncludeLocation.Postgraph },
        };
#endregion

#region Decal
        public static IncludeCollection Decal = new IncludeCollection
        {
            { CorePregraph },
            { kPacking, IncludeLocation.Pregraph },
            { kColor, IncludeLocation.Pregraph },
            { kFunctions, IncludeLocation.Pregraph },
            { kDecal, IncludeLocation.Pregraph },
            { kPassDecal, IncludeLocation.Postgraph },
        };
#endregion

#region HDLitRaytracing
        public static IncludeCollection LitRaytracingCommon = new IncludeCollection
        {
            { CorePregraph },
            { CoreRaytracing },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { kLit, IncludeLocation.Pregraph },
            { kLitRaytracing, IncludeLocation.Pregraph },
            { kRaytracingLightLoop, IncludeLocation.Pregraph },
            { CoreUtility },
            { kRaytracingCommon, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
        };
        public static IncludeCollection HDLitRaytracingIndirect = new IncludeCollection
        {
            { LitRaytracingCommon },
            { kPassRaytracingIndirect, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDLitRaytracingVisibility = new IncludeCollection
        {
            { LitRaytracingCommon },
            { kPassRaytracingVisbility, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDLitRaytracingForward = new IncludeCollection
        {
            { LitRaytracingCommon },
            { kPassRaytracingForward, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDLitRaytracingGBuffer = new IncludeCollection
        {
            { CorePregraph },
            { CoreRaytracing },
            { kLit, IncludeLocation.Pregraph },
            { kStandardLit, IncludeLocation.Pregraph },
            { CoreUtility },
            { kRaytracingCommon, IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { kPassRaytracingGBuffer, IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDLitRaytracingPathTracing = new IncludeCollection
        {
            { LitRaytracingCommon },
            { kPassPathTracing, IncludeLocation.Postgraph },
        };
#endregion

#region HDUnlitRaytracing
        public static IncludeCollection UnlitRaytracingCommon = new IncludeCollection
        {
            { CorePregraph },
            { CoreRaytracing },
            { kUnlit, IncludeLocation.Pregraph },
            { kUnlitRaytracing, IncludeCollection.Pregraph },
            { CoreUtility },
            { kRaytracingCommon, IncludeLocation.Pregraph },
        };
        public static IncludeCollection HDUnlitRaytracingIndirect = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Unlit/UnlitRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingIndirect.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDUnlitRaytracingForward = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Unlit/UnlitRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingForward.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDUnlitRaytracingVisibility = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Unlit/UnlitRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingVisibility.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection HDUnlitRaytracingGBuffer = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/Deferred/RaytracingIntersectonGBuffer.hlsl", IncludeLocation.Pregraph },
            { kUnlit, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/NormalBuffer.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StandardLit/StandardLit.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Unlit/UnlitRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderpassRaytracingGBuffer.hlsl", IncludeLocation.Postgraph },
        };
#endregion

#region FabricRaytracing
        public static IncludeCollection FabricRaytracingIndirect = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/Fabric.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/FabricRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingIndirect.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricRaytracingForward = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kLightLoopDef, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/Fabric.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/FabricRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingForward.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricRaytracingVisibility = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/Fabric.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/FabricRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPassRaytracingVisibility.hlsl", IncludeLocation.Postgraph },
        };

        public static IncludeCollection FabricRaytracingGBuffer = new IncludeCollection
        {
            { CorePregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingMacros.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/Deferred/RaytracingIntersectonGBuffer.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/Fabric.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StandardLit/StandardLit.hlsl", IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Fabric/FabricRaytracing.hlsl", IncludeLocation.Pregraph },
            { CoreUtility },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingCommon.hlsl", IncludeLocation.Pregraph },
            { kShaderGraphFunctions, IncludeLocation.Pregraph },
            { "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderpassRaytracingGBuffer.hlsl", IncludeLocation.Postgraph },
        };
#endregion
    }
}
