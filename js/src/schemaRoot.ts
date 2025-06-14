import { EntitySchema } from './entitySchema';
import { KnownValueRange } from './KnownValueRange';
import { RelationSchema } from './relationSchema';

/**
 * (from 'FUSE-fx.ModelDescription')
 */
export class SchemaRoot {
  public descriptionFormat: string = '';

  public timestampUtc: string = '';

  public semanticVersion: string = '';

  public entities: EntitySchema[] = [];

  public relations: RelationSchema[] = [];

  public designerData: string = '';

  public knownValueRanges: KnownValueRange[] = [];
}
