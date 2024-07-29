import { CodegenConfig } from "@graphql-codegen/cli";

const config: CodegenConfig = {
  schema: "schema.graphql",
  documents: "document.graphql",
  generates: {
    "Types.cs": 
    { 
      plugins: ["c-sharp"],
    },
  },
};

export default config;
