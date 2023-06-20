import { IndexSchema } from "./indexSchema";
import { FieldSchema } from "./fieldSchema";
export declare class EntitySchema {
    name: string;
    namePlural: string;
    inheritedEntityName: string | null;
    summary: string;
    isBlEntrypoint: boolean;
    PrimaryKeyIndexName: string;
    indices: IndexSchema[];
    fields: FieldSchema[];
}
//# sourceMappingURL=entitySchema.d.ts.map