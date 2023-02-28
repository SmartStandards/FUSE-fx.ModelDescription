import {IndexSchema} from "./indexSchema"
import {FieldSchema} from "./fieldSchema"

export class EntitySchema {
  
  public name: string = '';
  public namePlural: string = '';
  public inheritedEntityName: string|null = null;
  public summary: string = '';

  public isBlEntrypoint: boolean = false;

  public PrimaryKeyIndexName: string = '';
  public indices: IndexSchema[] = [];

  public fields: FieldSchema[] = [];

}
