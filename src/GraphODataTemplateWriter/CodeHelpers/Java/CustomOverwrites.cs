﻿// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.Graph.ODataTemplateWriter.CodeHelpers.Java
{
    /**
     * This class contains a list of constants that define code snippets that should
     * be overwritten at generation time 
     * The field name should be equal to the name of the class you wish to edit
     * The dictionary value should contain two string, the first is the search value
     * and the latter is the replace value
     * This will be used in BaseModel.template.tt in the PostProcess() method
     */
    public class CustomOverwrites
    {
        public static Dictionary<string, string> BaseOnenotePageCollectionRequest = new Dictionary<string, string>() {
            {
                "public void post(final OnenotePage newOnenotePage, final ICallback<OnenotePage> callback) {",
                "public void post(final byte[] newOnenotePage, final ICallback<OnenotePage> callback) {"
            },
            {
                "public OnenotePage post(final OnenotePage newOnenotePage) throws ClientException {",
                "public OnenotePage post(final byte[] newOnenotePage) throws ClientException {"
            }
        };

        public static Dictionary<string, string> BaseOnenotePageRequest = new Dictionary<string, string>()
        {
            {
                "public void post(final OnenotePage newOnenotePage, final ICallback<OnenotePage> callback) {",
                "public void post(final byte[] newOnenotePage, final ICallback<OnenotePage> callback) {"
            },
            {
                "public OnenotePage post(final OnenotePage newOnenotePage) throws ClientException {",
                "public OnenotePage post(final byte[] newOnenotePage) throws ClientException {"
            }
        };

        public static Dictionary<string, string> IBaseOnenotePageCollectionRequest = new Dictionary<string, string>()
        {
            {
                "void post(final OnenotePage newOnenotePage, final ICallback<OnenotePage> callback);",
                "void post(final byte[] newOnenotePage, final ICallback<OnenotePage> callback);"
            },
            {
                "OnenotePage post(final OnenotePage newOnenotePage) throws ClientException;",
                "OnenotePage post(final byte[] newOnenotePage) throws ClientException;"
            }
        };

        public static Dictionary<string, string> IBaseOnenotePageRequest = new Dictionary<string, string>()
        {
            {
                "void post(final OnenotePage newOnenotePage, final ICallback<OnenotePage> callback);",
                "void post(final byte[] newOnenotePage, final ICallback<OnenotePage> callback);"
            },
            {
                "OnenotePage post(final OnenotePage newOnenotePage) throws ClientException;",
                "OnenotePage post(final byte[] newOnenotePage) throws ClientException;"
            }
        };

        public static Dictionary<string, string> BasePlannerAssignments = new Dictionary<string, string>()
        {
            {
                "public class BasePlannerAssignments implements IJsonBackedObject {",
                "public class BasePlannerAssignments extends HashMap<String, PlannerAssignment> implements IJsonBackedObject {"
            }
        };

        public static Dictionary<string, string> BasePlannerChecklistItems = new Dictionary<string, string>()
        {
            {
                "public class BasePlannerChecklistItems implements IJsonBackedObject {",
                "public class BasePlannerChecklistItems extends HashMap<String, PlannerChecklistItem> implements IJsonBackedObject {"
            }
        };

        public static Dictionary<string, string> BasePlannerExternalReferences = new Dictionary<string, string>()
        {
            {
                "public class BasePlannerExternalReferences implements IJsonBackedObject {",
                "public class BasePlannerExternalReferences extends HashMap<String, Object> implements IJsonBackedObject {"
            }
        };

        public static Dictionary<string, string> BasePlannerOrderHintsByAssignee = new Dictionary<string, string>()
        {
            {
                "public class BasePlannerOrderHintsByAssignee implements IJsonBackedObject {",
                "public class BasePlannerOrderHintsByAssignee extends HashMap<String, String> implements IJsonBackedObject {"
            }
        };
    }
}
